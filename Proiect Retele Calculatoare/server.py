import socket
import threading
from collections import deque, defaultdict

HOST = '127.0.0.1'
PORT = 65432

semafoare = {}
cozi_asteptare = defaultdict(deque)

lock = threading.Lock()

def gestioneaza_client(conn, addr):
    print(f"[CONECTAT] Client de la adresa {addr}")
    try:
        while True:
            data = conn.recv(1024).decode()
            if not data:
                break

            parts = data.strip().split()
            if len(parts) < 2:
                continue

            comanda, nume_semafor = parts[0], parts[1]

            with lock:
                if comanda == "ACQUIRE":
                    if nume_semafor not in semafoare:
                        semafoare[nume_semafor] = conn
                        conn.sendall(b"ACCES ACORDAT\n")
                    elif semafoare[nume_semafor] == conn:
                        conn.sendall(b"DEJA DETII ACCESUL\n")
                    else:
                        cozi_asteptare[nume_semafor].append(conn)
                        conn.sendall(b"ESTI IN ASTEPTARE\n")

                elif comanda == "RELEASE":
                    if semafoare.get(nume_semafor) == conn:
                        if cozi_asteptare[nume_semafor]:
                            urmatorul = cozi_asteptare[nume_semafor].popleft()
                            semafoare[nume_semafor] = urmatorul
                            try:
                                urmatorul.sendall(f"ACCES ACORDAT {nume_semafor}\n".encode())
                            except:
                                semafoare[nume_semafor] = None
                        else:
                            del semafoare[nume_semafor]
                        conn.sendall(b"SEMAFOR ELIBERAT\n")
                    else:
                        conn.sendall(b"NU DETII ACEST SEMAFOR\n")
    finally:
        print(f"[DECONECTAT] Client de la adresa {addr}")
        with lock:
            for nume, detinator in list(semafoare.items()):
                if detinator == conn:
                    del semafoare[nume]
                    if cozi_asteptare[nume]:
                        urmatorul = cozi_asteptare[nume].popleft()
                        semafoare[nume] = urmatorul
                        try:
                            urmatorul.sendall(f"ACCES ACORDAT {nume}\n".encode())
                        except:
                            semafoare[nume] = None
            for coada in cozi_asteptare.values():
                if conn in coada:
                    coada.remove(conn)
        conn.close()

def porneste_serverul():
    print(f"[PORNIRE] Serverul de semafoare rulează pe {HOST}:{PORT}")
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.bind((HOST, PORT))
        s.listen()
        while True:
            conn, addr = s.accept()
            threading.Thread(target=gestioneaza_client, args=(conn, addr), daemon=True).start()  

if __name__ == "__main__":
    porneste_serverul()