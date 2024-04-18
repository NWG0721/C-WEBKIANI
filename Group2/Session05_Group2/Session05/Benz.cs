namespace Session05
{
    public class Benz : Car
    {
        // public Benz()
        // {
        //     Type = CarType.Automated;
        // }
        // public Benz()
        // {
        //     Type = CarType.Automated;
        // }
        // A: B , B:C , C:D , D:E
        /*
        public Benz():this(300,2024,"Black")
        {
            //Console.WriteLine("i am constructor");
        }
        public Benz(int maxSpeed):this(maxSpeed,2024,"Black")
        {
            //this.MaxSpeed = maxSpeed;
        }
        public Benz(int maxSpeed, int year):this(maxSpeed,year,"Black")
        {
            //this.MaxSpeed = maxSpeed;
            //this.Year = year;
        }
        public Benz(int maxSpeed, int year, string color)
        {
            this.MaxSpeed = maxSpeed;
            this.Year = year;
            this.Color = color;
        }
        */
        // public int MaxSpeed { get; set; }
        // public int Year { get; set; }
        // public string Color { get; set; }

        // public override CarType Type
        // {
        //     get
        //     {

        //         return CarType.Automated;
        //     }
        // }
        public override CarType GetType()
        {
            return CarType.Automated;
        }

    }
}