using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW
{
    public class Client
    {
        private static HashSet<int> idClienti = new HashSet<int>(); //Set pentru a urmari id-urile
        public int IdClient { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public string AdresaClient { get; set; }
        public string NumarTelefon { get; set; }

        //Constructor

        public Client()
        {

        }
        public Client(int idClient, string nume, string prenume, string adresaClient, string numarTelefon)
        {
            if (idClienti.Contains(idClient))
            {
                Console.WriteLine($"ID-ul {idClient} exista deja. Alege un alt ID.");
                return;
            }
            idClienti.Add(idClient); //Adauga IdClient in set

            IdClient = idClient;

            if (string.IsNullOrWhiteSpace(nume) || string.IsNullOrWhiteSpace(prenume))
            {
                Console.WriteLine("Numele si prenumele trebuie introduse obligatoriu.");
                return;
            }

            Nume = nume;
            Prenume = prenume;

            if (string.IsNullOrWhiteSpace(adresaClient))
            {
                Console.WriteLine("Adresa trebuie introdusa obligatoriu.");
                return;
            }

            AdresaClient = adresaClient;

            if (numarTelefon.Length == 10 && numarTelefon.All(char.IsDigit))
                NumarTelefon = numarTelefon;
            else
                Console.WriteLine("Numarul de telefon trebuie introdus corect.");
        }

        //Afisare detalii dlient
        public void AfisareDetaliiClient()
        {
            Console.WriteLine($"ID Client: {IdClient}");
            Console.WriteLine($"Nume: {Nume}");
            Console.WriteLine($"Prenume: {Prenume}");
            Console.WriteLine($"Adresa domiciliu: {AdresaClient}");
            Console.WriteLine($"Numar telefon: {NumarTelefon}");
        }

        public override string ToString()
        {
            return $"ID Client: {IdClient}\n" + $"Nume: {Nume}\n" + $"Prenume: {Prenume}\n" + $"Adresa domiciliu: {AdresaClient}\n" + $"Numar telefon: {NumarTelefon}\n";
        }
    }
}