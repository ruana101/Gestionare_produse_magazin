using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1
{
    public class ProdusPerisabil : Produs
    {
        public DateTime DataExpirare { get; set; }
        public int TemperaturaStocare { get; set; }

        public ProdusPerisabil(string nume, double pret, DateTime dataExpirare, int temperaturaStocare) : base(nume, pret)
        {
            DataExpirare = dataExpirare;
            TemperaturaStocare = temperaturaStocare;
        }

        public override void Descriere()
        {
            Console.WriteLine($"Produs Perisabil: {Nume}, ID: {ID}, Pret: {Pret} RON");
            Console.WriteLine($"Expira la: {DataExpirare.ToShortDateString()}, Stocare la: {TemperaturaStocare} grade C");
        }
    }
}
