using proiectPAW;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW
{
    public class Factura
    {
        public int IdFactura { get; set; }
        public Client Client { get; set; }
        public List<Produs> Produs { get; set; }

        //Constructor
        public Factura(int idFactura, Client client, List<Produs> produs)
        {
            IdFactura = idFactura;
            Client = client;
            Produs = produs;
        }

        //Afisare detalii factura
        public void AfisareDetaliiFactura()
        {
            Console.WriteLine($"ID Factura: {IdFactura}");
            Console.WriteLine($"Detalii client:");
            Client.AfisareDetaliiClient();
            Console.WriteLine($"Produse cumparate:");
            foreach( Produs produs in Produs ) 
                 produs.AfisareDetaliiProduse();
        }
    }
}