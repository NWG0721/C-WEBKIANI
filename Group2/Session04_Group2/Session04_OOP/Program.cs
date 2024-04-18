public class Program
{
    public static void Main()
    {
       //OOP => Object Oriented Programming
       
       //Using class
       // [ClassName] [Variable/Pointer Name] = new [ClassName]();
       //exp
       Person p1 =new Person(); //Creating an instance
       // Accessing class member
       // [Variable/Pointer Name].[MemberName]
       p1.FirstName ="123";
       p1.LastName ="456";
       //p1.id ="a0"; id => private => error
       //p1.SetId("1111111111");
       p1.Id ="1111111111";
       

       string fullName = p1.GetFullName();
       //string id =p1.GetId();

       Console.WriteLine(fullName+","+p1.Id);

       

    }
}
