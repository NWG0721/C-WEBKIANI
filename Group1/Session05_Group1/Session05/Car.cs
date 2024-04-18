public abstract class Car
{
        public Car(int maxSpeed)
        {
                this.MaxSpeed = maxSpeed;
        }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
    
        public virtual string GetInfo()
        {
                return $"{this.GetName()}:{this.MaxSpeed}:{this.Color}";
        }

        public abstract string GetName();
}
