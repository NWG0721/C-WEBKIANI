using System.Collections;

public class Program
{
    static Student[] students = new Student[10];
    static int totalCount = 0;
    const int INCREASE_STPE = 10;
    static int lastId = 1;
    //static ArrayList students = new ArrayList();
    public static void Main()
    {

        PrintMenu();
        bool isExiting = false;
        while (true)
        {
            var menu = GetMenu();
            if (!IsValidMenu(menu))
                continue;
            switch (menu)
            {
                case "a":
                    AddStudent();
                    break;
                case "p":
                    PrintStudents();
                    break;
                case "d":
                    DeletStudent();
                    break;
                case "e":
                    isExiting = true;
                    break;
                default:
                    break;
            }
            if (isExiting)
                break;


        }
    }

    private static void DeletStudent()
    {
        Console.WriteLine("Get Id");
        string id = Console.ReadLine();
        bool found = false;
       

        for (int i = 0; i < students.Length; i++)
        {
            if (students[i] !=null && students[i].Id == id)
            {
                students[i].Deleted =true;
                found = true;
            }
        }
        if (found)
            ReArrangeStudens();

    }
    private static void ReArrangeStudens()
    {
        int length =students.Length;
        Student[] newStudents = new Student[length];
        int index =0;
         int deletedCount =0;
        for (var i = 0; i < length; i++)
        {
            if(students[i] != null && students[i].Deleted== false)
            {

                newStudents[index]=students[index];
                index ++;
            }
            else
            {
                deletedCount ++;
            }
        }
        students =newStudents;
        totalCount -= deletedCount;
    }

    public static void PrintMenu()
    {
        Console.WriteLine("1)Add Student(a)");
        Console.WriteLine("2)Print Students(p)");
        Console.WriteLine("3)Delete Student(d)");
        Console.WriteLine("4)Exit(e)");

    }

    public static string GetMenu()
    {
        Console.WriteLine("Select a menu:");
        return Console.ReadLine();
    }
    public static bool IsValidMenu(string menu)
    {
        if (menu == "a" || menu == "e" || menu == "p" || menu == "d")
            return true;
        return false;

    }
    public static void AddStudent()
    {
        Student s = new Student();
        s.Id = lastId.ToString();
        s.FirstName = "ffas";
        s.LastName = "afadfaf";
        s.Average = 14.2;
        //students.Add(s);
        if (totalCount >= students.Length)
        {
            //Increase Array Length
            IncreaseArrayLength();
        }

        students[totalCount] = s;
        totalCount += 1;
        lastId++;
    }
    private static void IncreaseArrayLength()
    {
        int currentLength = students.Length;
        int newLength = currentLength + INCREASE_STPE;
        ReFillArray(newLength);

    }
    private static void ReFillArray(int newLength)
    {
        Student[] newStudents = new Student[newLength];
        for (var i = 0; i < students.Length; i++)
        {
            newStudents[i] = students[i];
        }
        students = newStudents;
    }
    public static void PrintStudents()
    {
        Console.WriteLine("Printing students");
        foreach (var item in students)
        {
            Student std = item as Student;
            if (std != null)
            {
                Console.WriteLine("{0}=>{1}", std.Id, std.FirstName);
            }

        }
    }
}


