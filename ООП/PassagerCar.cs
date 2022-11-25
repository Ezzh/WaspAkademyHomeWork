public class PassagerCar : Car
    {
        public int pas;
        public Dictionary<string, int> remont = new Dictionary<string, int>();
        public PassagerCar(string marka, int power, int year, int pas) : base(marka, power, year)
        {
            this.pas = pas;
        }

        public override string ToString()
        {
            return $"Марка: {marka} \nМощность: {power} \nГод производства: {year}\nКол-во пассажиров: {pas}";
        }
        //Добавление запчасти в словарь
        public void Zamena(string zapchast,int year)
        {
            remont.Add(zapchast, year);
        }
        //Получение года замены запчасти
        public int YearZameni(string zapchast)
        {
            return remont[zapchast];
        }
        //Печать всей ремонтной книжки
        public void PrintRemont()
        {
            foreach (var item in remont)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    
    }