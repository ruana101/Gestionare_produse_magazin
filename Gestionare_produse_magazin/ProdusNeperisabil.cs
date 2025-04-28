using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1
{
    public class ProdusNeperisabil : Produs
    {
        public string Observatii { get; set; }

        public ProdusNeperisabil(string nume, double pret, string observatii) : base(nume, pret)
        {
            Observatii = observatii;
        }

        public override void Descriere()
        {
            Console.WriteLine($"Produs Neperisabil: {Nume}, ID: {ID}, Pret: {Pret} RON");
            Console.WriteLine($"Observatii: {Observatii}");
        }
    }
}
