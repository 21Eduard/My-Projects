using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW
{
    public class Comanda
    {
        public int IdComanda { get; set; }
        public DateTime DataPlasare { get; set; }
        public string AdresaLivrare { get; set; }
        public Client Client { get; set; } //Referinta catre clientul asociat comenzii
        public List<Produs> Produs { get; set; } //Referinta catre produsele asociate comenzii

        //Constructor
        public Comanda()
        {

        }
        public Comanda(int idComanda, DateTime dataPlasare, string adresaLivrare, Client client, List<Produs> produs)
        {
            IdComanda = idComanda;
            DataPlasare = dataPlasare;
            AdresaLivrare = adresaLivrare;
            Client = client;
            Produs = produs;
        }

        //Afisare detalii comanda
        public void AfisareDetaliiComanda()
        {
            Console.WriteLine($"Comanda cu ID-ul {IdComanda} a fost plasata la data de {DataPlasare}");
            Console.WriteLine($"Produse comandate:");
            foreach( Produs produs in Produs )
                produs.AfisareDetaliiProduse();
            Console.WriteLine($"Adreasa de livrare: {AdresaLivrare}");
            Console.WriteLine($"Clientul asociat comenzii:");
            Client.AfisareDetaliiClient();
        }
    }
}