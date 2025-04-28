using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema_lab1
{
    public class Magazin
    {
        private List<Produs> stoc = new List<Produs>();

        public void AdaugaProdus(Produs produs)
        {
            stoc.Add(produs);
            Console.WriteLine($"Produsul '{produs.Nume}' a fost adaugat in magazin.");
        }

        public Produs StergeProdus(int id)
        {
            var produs = stoc.Find(p => p.ID == id);
            if (produs != null)
            {
                stoc.Remove(produs);
                Console.WriteLine($"Produsul '{produs.Nume}' a fost sters din magazin");
            }
            else
            {
                Console.WriteLine($"Produsul cu ID {id} nu a fost gasit.");
            }
            return produs;
        }

        public void AfiseazaProduse()
        {
            Console.WriteLine("Produsele din magazin:");
            foreach (var produs in stoc)
            {
                produs.Descriere();
                Console.WriteLine("---------------------");
            }
        }
    }
}
