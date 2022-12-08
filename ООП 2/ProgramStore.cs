using System;


namespace HomeworkOOP2
{
    class Program
    {
        public static void Main()
        {
            Store ggstore = new Store("ggstore", "12/42");
            ggstore += new Audio("biber", "pops", "biber", "USA", 12);
            ggstore += new Audio("Back in black", "rock", "AC/DC", "Jokif", 7);
            ggstore += new Audio("Lesniki urodi", "Pops", "Serega", "Dom", 1);
            ggstore += new DVD("Titanik", "Drama", "Spilberg", "USA", 123);
            ggstore += new DVD("Forsaj", "Gonki", "Rock", "Holliwood", 135);
            Console.WriteLine(ggstore);
            ggstore.dvds[0].Burn("Ostrie kozirki", "Boevik", "Tom", "USA", "1234");
            Console.WriteLine();
            foreach (DVD d in ggstore.dvds)
            {
                Console.WriteLine(d.name + ": " + d.DiskSize);
            }
            foreach (Audio a in ggstore.audios)
            {
                Console.WriteLine(a.name + ": " + a.DiskSize);
            }


        }
    }
}