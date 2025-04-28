using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1
{
    public class Client
    {
        private List<Produs> cos = new List<Produs>();
        private Magazin magazin;

        public Client(Magazin magazin)
        {
            this.magazin = magazin;
        }

        public void AdaugaProduse(int id)
        {
            var produs = magazin.StergeProdus(id);

            if(produs != null)
            {
                cos.Add(produs);
                Console.WriteLine($"Produsul: {produs.Nume} a fost adaugat in cos.");
            }
            else
            {
                Console.WriteLine("Produsul nu exista in magazin.");
            }
        }

        public void StergeProdus(int id)
        {
            var produs = cos.Find(p => p.ID == id);
            if (produs != null)
            {
                cos.Remove(produs);
                magazin.AdaugaProdus(produs);
                Console.WriteLine($"Produsul '{produs.Nume}' a fost scos din cos si adaugat inapoi in magazin");
            }
            else
            {
                Console.WriteLine("Produsul nu exista in cos.");
            }
        }

        public double Plata()
        {
            double total = 0;
            foreach(var produs in cos)
            {
                total += produs.Pret;
            }
            cos.Clear();
            return total;
        }
    }
}
