namespace Session05
{
    public class Paykan : Car
    {
        // public Paykan()
        // {
        //     Type = CarType.Manually;
        // }
        // public Paykan()
        // {
        //     Type = CarType.Manually;
        // }
        // public override CarType Type
        // {
        //     get
        //     {

        //         return CarType.Manually;
        //     }
        // }
        public override CarType GetType()
        {
            return CarType.Manually;
        }
    }
}