import socket
import threading

HOST = '127.0.0.1'
PORT = 65432

def bucla_primire(sock):
    while True:
        try:
            data = sock.recv(1024)
            if not data:
                break
            print("[SERVER]", data.decode().strip())
        except:
            break

def main():
    with socket.socket(socket.AF_INET, socket.SOCK_STREAM) as s:
        s.connect((HOST, PORT))
        threading.Thread(target=bucla_primire, args=(s,), daemon=True).start()
        print("Conectat la serverul de semafoare. Introdu comenzi:")
        print("Comenzi valide: ACQUIRE <nume_semafor>, RELEASE <nume_semafor>, exit")
        while True:
            try:
                comanda = input("> ")
                if comanda.strip().lower() == "exit":
                    break
                s.sendall(comanda.encode() + b"\n")
            except KeyboardInterrupt:
                break

if __name__ == "__main__":
    main()