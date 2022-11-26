class Truck : Car
    {
        public int max {get; set;}
        public string fio {get; set;}
        public Dictionary<string, int> gruz = new Dictionary<string, int>();
        public Truck(string marka, int power, int year, int max, string fio) : base(marka, power, year)
        {
            this.max = max;
            this.fio = fio;
        }

        public void Voditel(string name)
        {
            fio = name;
        }

        public void AddGruz(string name, int mass)
        {
            gruz.Add(name, mass);
        }

        public void DeleteGruz(string name)
        {
            gruz.Remove(name);
        }

        public void PrintGruz()
        {
            foreach (var item in gruz)
            {
                Console.WriteLine($"{item.Key}: {item.Value}kg");
            }
        }

        public override string ToString()
        {
            return $"{base.ToString()}\nМаксимальная грузоподъемность: {max}\nФИО водител: {fio}";
        }

    }