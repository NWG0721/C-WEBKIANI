public static class Program
{
    public static void Main(string[] args)
    {
        //*********** CONSTRUCTOR
        /*
        Person person =new Person(10,"Mehdi","Kiani");
        Console.WriteLine(person.FullName);
        */


        //******************** PROPERTY
        /*
       Person p1=new Person();
       //p1.age =10; => private
       //p1.SetAge(20);

       //Console.WriteLine(p1.GetAge());

       p1.Age=20;
       p1.FirstName="Ali";
       p1.LastName="Akbari";
       Console.WriteLine($"{p1.Age}:{p1.FullName}");
      */
       

       //****************** INHERITANCE

       
        Paykan p1 =new Paykan(10);
        p1.MaxSpeed =280;
        p1.Color = "Gojei";
        Console.WriteLine(p1.GetInfo());

        Benz b1 =new Benz(10);
        //b1.MaxSpeed =340;
        b1.Color = "Black";
        Console.WriteLine(b1.GetInfo());
        
    }
}
