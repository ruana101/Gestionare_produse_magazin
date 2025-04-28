using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1
{
    public abstract class Produs
    {
        private static readonly Random rnd = new Random(); 
        public int ID { get; } = rnd.Next(1, 10001); 
        public string Nume { get; set; }
        public double Pret { get; set; }
        
        public Produs( string nume, double pret)
        {
            Nume = nume;
            Pret = pret;
        }

        public abstract void Descriere();
    }
}
