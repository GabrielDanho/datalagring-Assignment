// See https://aka.ms/new-console-template for more informatio


using datalagring.data;
using datalagring.Models;
using Microsoft.EntityFrameworkCore;

bool loop = true;
while (loop)
{
    Console.WriteLine("1. Skapa Ärende");

    Console.WriteLine("2. Visa ärenden");

    Console.WriteLine("3. Stäng av programmet");

    string input = Console.ReadLine();

    switch(input)
    {
        case "1":
            Console.WriteLine("Skapa ett ärende...");
            Console.WriteLine("Förnamn:");
            string förnamn = Console.ReadLine();
            Console.WriteLine("Efternamn:");
            string efternamn = Console.ReadLine();
            Console.WriteLine("Email:");
            string email = Console.ReadLine();
            Console.WriteLine("Telefon nummer:");
            string nummer = Console.ReadLine();
            Console.WriteLine("Beskriv ärendet:");
            string beskrivning = Console.ReadLine();
            Console.WriteLine("Kommentar");
            string kommentar = Console.ReadLine();
            Console.WriteLine("Status");
            string status = Console.ReadLine();
            using (var db = new ÄrendeContext())
            {
                Ärende ärende = new Ärende(förnamn, efternamn, email, nummer, beskrivning, status, kommentar);
                db.Ärenden.Add(ärende);
                db.SaveChanges();
            }
            break;

        case "2":
            Console.WriteLine("Ärenden... ");
            using (var db = new ÄrendeContext())
            {
              foreach(var ärende in db.Ärenden)
                {
                    Console.WriteLine(ärende.Kommentar);
                }
            }

            break;

        case "3":
            Console.WriteLine("stänger av");
            loop = false;
            break;

        default: Console.WriteLine("Fel input!"); break;
    }
}
