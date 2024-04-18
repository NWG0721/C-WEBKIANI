using System.Collections.Generic;
public  class Program
{
    public static void Main(string[] args)
    {

        //******************** INTERFACE
        //PrinterHelper printer1 =new PrinterHelper();
        //PrinterHelper.PrintByHp("Hi");
       // PrinterHelper.PrintBySamsung("Hi");

/*
       HP hp= new HP();
       Samsung  samsung= new Samsung();

       PrinterHelper.Print(hp,"Hi");
       PrinterHelper.Print(samsung,"Hi");

       Sony sony= new Sony();
       PrinterHelper.Print( sony,"Hi");
*/

        //******************** DELEGATE
    /*
    int[] a ={1,2,3};
    //SortCallback callback = new SortCallback(SortByAlgoB);
    SortCallback callback = SortByAlgoB;
    Sorter.Sort(callback,a);
    */

    //******************** GENERIC

    //*********** BOXING < UNBOXING , LOSSELY TYPE
    /*
    Person p1= new Person();
    p1.Id=10;

    Person p2= new Person();
    p2.Id="akbar";


    int id =(int)p1.Id;

    int x=(int)p2.Id;
    */

    /*
    Person<int,string> p3 = new Person<int,string>();
    p3.Id =10;
    p3.X ="ddd";
    

    Person<string,Samsung> p4= new Person<string,Samsung>();
    p4.Id = "akbar";
    p4.X =new Samsung();

    */

    //******************** GENERIC COLLECTIONS

    /*
    List<int> l1= new List<int>();
    l1.Add(10);
    l1.Add(2);
    l1.Add(33);
    l1.Add(4);
    l1.Add(50);
    l1.Sort();
    for (int i = 0;i <l1.Count;i++)
    {
        Console.WriteLine(l1[i]);
    }

    foreach(int a in l1)
    {
        Console.WriteLine(a);
    }
    */

    List<Student> students = new List<Student>();

    for (int i = 0;i<10;i++)
    {

        students.Add(new Student{
            Id=i,
            Name =GetRandomName()
        });
    }

    foreach (Student student in students)
    {
        Console.WriteLine(student);
    }

    Console.WriteLine("################################");
    Comparison<Student> studentComparer = SortStudent;
    students.Sort(studentComparer);

    foreach (Student student in students)
        {
        Console.WriteLine(student);
        }   
    }

    public static void SortByAlgoB(int[] x)
    {
        //Sort by algo b
        Console.WriteLine("Sorting by algo B");
    }
    public static int SortStudent(Student std1,Student st2)
    {
        return string.Compare(std1.Name, st2.Name);
    }

    public static string GetRandomName()
    {
        string alphabet ="abcdefghijklmnopqrstuvwxyz";
        alphabet +=alphabet.ToUpper();
        alphabet +="_";
        string result="";
        Random random= new Random();
        int alphaLen =alphabet.Length;
        for (int i = 0; i < 10;i++)
        {
              int index= random.Next(0,alphaLen);
              result+=alphabet[index];
        }
        return result;
    }
}
