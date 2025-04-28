using tema_lab1;

class Program
{
    static void Main()
    {
        Magazin magazin = new Magazin();

        magazin.AdaugaProdus(new ProdusPerisabil("Lapte", 8.5, new DateTime(2025, 4, 15), 4));
        magazin.AdaugaProdus(new ProdusPerisabil("Branza", 15.0, new DateTime(2025, 6, 10), 5));
        magazin.AdaugaProdus(new ProdusNeperisabil("Farfurii", 25.0, "Set de 6 bucati"));
        magazin.AdaugaProdus(new ProdusNeperisabil("Lanterna", 35.0, "Cu LED si baterii incluse"));

        magazin.AfiseazaProduse();

        Client client = new Client(magazin);

        client.AdaugaProduse(1);  
        client.AdaugaProduse(2);

        Console.WriteLine($"Total de plată: {client.Plata():F2} RON");

        Console.WriteLine("\nProduse rămase în magazin:");
        magazin.AfiseazaProduse();
    }
}

