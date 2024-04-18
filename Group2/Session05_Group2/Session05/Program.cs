using Session05;

public class Program
{
    public static void Main()
    {
        Benz benz1 = new Benz();
        benz1.MaxSpeed = 400;
        //benz1.Color = "White";
        benz1.Color = CarColor.White;
        benz1.Year = 2023;
        benz1.Name = "Benz1:";
        //benz1.Type = CarType.Automated;

        Paykan paykan1 = new Paykan();
        paykan1.MaxSpeed = 120;
        //paykan1.Color = "Red";
        paykan1.Color =CarColor.Red;
        paykan1.Year = 1980;
        paykan1.Name = "paykan1:";
        //paykan1.Type = CarType.Automated;
        
       
        //Console.WriteLine(benz1.GetSummery());
        //Console.WriteLine(paykan1.GetSummery());
        //Console.WriteLine(benz1.ToString());
        //Console.WriteLine(paykan1.ToString());
        Console.WriteLine(benz1);
        Console.WriteLine(paykan1);
        //Console.WriteLine("");

        //Person p1 = new Person();
        //p1.Month = 5;
        //p1.Grade = 17;

    }
}
