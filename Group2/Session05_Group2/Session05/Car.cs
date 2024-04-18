namespace Session05
{
    public abstract class Car
    {
        public int MaxSpeed { get; set; }
        public int Year { get; set; }
        public CarColor Color { get; set; }
        public string Name { get; set; }
        //public abstract CarType Type { get;}
        //protected CarType Type { get; set; }
        //public CarType Type { get;protected set; }
        public abstract CarType GetType();
        // public string GetSummery()
        // {
        //     return Name + ":" + MaxSpeed + "," + Year + "," + Color;
        // }

        public override string ToString()
        {
            //return GetSummery();
            return Name + ":" + MaxSpeed + "," + Year + "," + Color + "," + GetType();
        }
    }
}