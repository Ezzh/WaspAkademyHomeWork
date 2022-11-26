public class Car
    {
        public int power {get; set;}
        public int year {get; set;}
        public string marka {get; set;}

        public Car(string marka, int power, int year)
        {
            this.power = power;
            this.marka = marka;
            this.year = year;
        }

        public override string ToString()
        {
            return $"Марка: {marka} \nМощность: {power} \nГод производства: {year}";
        }

    }