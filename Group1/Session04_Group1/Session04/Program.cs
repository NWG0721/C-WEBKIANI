public class Program
{
    static void Main()
    {
        //Collections
        //مجموعه ها

        //1- [DataType][] [Array Name] = new [DataType][Array Length];

        // int[] ar1 = new int[3];
        // ar1[0]=1;
        // ar1[1]=2;
        // ar1[2]=3;


        //1- [DataType][] [Array Name] = new [DataType][] {Array Data};
        //int[] ar1 =new[]{1,2,3};

        //Array Features
        //1) Static Length
        //2) Same Data Type Value
        //3) could be cause Boxing , unBoxing
        //4) Using Index Value to access array data
        //5) Indexes started from 0 to n-1, Which n is the legnth of array
        //6) example: if lenght = 3 => 0 <= index <3

        /*
                Console.WriteLine("Enter Number");
                if (int.TryParse(Console.ReadLine(), out int n))
                {
                    int[] numbers = new int[n];
                    for (var i = 0; i < n ; i++) // n => numbers.Length
                    {
                        Console.WriteLine("Enter Number{0}", (i+1));
                        if (int.TryParse(Console.ReadLine(), out int num))
                        {
                            numbers[i] = num;
                        }
                        else
                        {

                            Console.WriteLine("Invalid Number. The zero value will set.");
                            numbers[i] = 0;
                        }
                    }

                    int sum = Add(numbers);
                    Console.WriteLine("The sum of values is {0}:",sum);

                }
                else
                {
                    Console.WriteLine("Invalid value. Press any key to exit...");
                    Console.ReadKey();
                }

                */

        //Class Using
        //Create An Instance of a class
        // [Class Name] [Variable Name (reference to class)] = new [Class Name]();
        Person person1 = new Person(); // Instance

        // Using Class Members
        //[Variable Name (reference to class)].[member name] = [member value];
        /*
        person1.firstName ="ali";
        person1.lastName ="Hasani";
        person1.age =22;

        Person person2 =new Person();
        person2.firstName ="akbar"; //
        person2.lastName = "fathi";
        person2.age =44;


        Console.WriteLine("{0},{1},{2}",person1.firstName,person1.lastName,person1.age);
        Console.WriteLine("{0},{1},{2}",person2.firstName,person2.lastName,person2.age);

        */
        Console.WriteLine("Enter Number");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Person[] persons = new Person[n];
            for (var i = 0; i < n; i++)
            {

                Console.WriteLine("Enter person{0} firstName", (i + 1));
                string fn = Console.ReadLine();

                Console.WriteLine("Enter person{0} lastName", (i + 1));
                string ln = Console.ReadLine();

                 Console.WriteLine("Enter person{0} age", (i + 1));
                if (!int.TryParse(Console.ReadLine(), out int age))
                    age = 18;
                
                //numbers[i] =value;
                Person p =new Person();
                p.firstName = fn;
                p.lastName =ln;
                p.age =age;

                persons[i] =p;


            }
            PrintPersonInfo(persons);

        }
        else
        {
            Console.WriteLine("Invalid value. Press any key to exit...");
            Console.ReadKey();
        }


    }
    // static int Add(params int[] values)
    // {
    //     int result = 0;
    //     foreach (var value in values)
    //     {
    //         result += value;
    //     }
    //     return result;
    // }

    static void PrintPersonInfo(params Person[] persons)
    {

        foreach (var person in persons)
        {
            Console.WriteLine("{0},{1},{2}",person.firstName,person.lastName,person.age);
        }
    }

}
