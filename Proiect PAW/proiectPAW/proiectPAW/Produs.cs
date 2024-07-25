using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiectPAW
{
    public class Produs
    {
        public string NumeProdus { get; set; }
        public int Cantitate { get; set; }
        public decimal Pret { get; set; }

        //Constructor
        public Produs(string numeProdus, int cantitate, decimal pret)
        {
            NumeProdus = numeProdus;
            Cantitate = cantitate;
            Pret = pret;
        }

        //Afisare detalii produse
        public void AfisareDetaliiProduse()
        {
            Console.WriteLine($"Produs: {NumeProdus}");
            Console.WriteLine($"Cantitate: {Cantitate}");
            Console.WriteLine($"Pret per unitate: {Pret}");
        }
        public override string ToString()
        {
            return $"Produs: {NumeProdus}\n" + $"Cantitate: {Cantitate}\n" + $"Pret per unitate: {Pret}\n";
        }
    }
}