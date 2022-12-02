using System;


namespace HomeworkOOP
{
    class Program
    {
        public static void Main()
        {
            Truck Lada = new Truck("Lamba", 123, 1456, 65, "Goblin");
            PassagerCar hob = new PassagerCar("Javelin", 100, 1567, 45);
            PassagerCar ferra = new PassagerCar("Ferra", 100, 1890, 3);
            Autopark park = new Autopark("Novobiha");
            park.AddCar(Lada);
            park.AddCar(hob);
            park.AddCar(ferra);
            Console.WriteLine(park);

        }
    }
}