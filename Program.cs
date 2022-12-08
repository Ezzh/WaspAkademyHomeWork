using System;


namespace HomeworkOOP
{
    class Program
    {
        public static void K2()
        {
            Audio biber = new Audio("biber", "pops", "biber", "USA", 12);
            DVD titanic = new DVD("Titanik", "Drama", "Spilberg", "USA", 123);
            Store ggstore = new Store("ggstore", "12/42");
            ggstore += biber;
            ggstore += titanic;
            Console.WriteLine(ggstore);
            titanic.Burn("Ostrie kozirki", "Boevik", "Tom", "USA", "1234");
            Console.WriteLine(ggstore.dvds[0].DiskSize);

        }
    }
}