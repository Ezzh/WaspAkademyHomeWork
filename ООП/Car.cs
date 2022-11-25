public class Car
    {
        public int power;
        public int year;
        public string marka = "";

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