// Methods
//به مجموعه ای کد های که در قابل یک نام
//تعریف می شوند
//و عملکرد مشخصی را انجام می دهند.
// متد گفته می شود.
// متدها می توانند دارای پارامتر ورودی باشند
//هر متد الزاما باید نوع بازگشتی داشته باشد
// متد هایی که هیچ مقداری بر نمی گردانند، نوع
//بازشگتی آنها را
//void
//قرار می دهیم
class Program
{

    static void Main()
    {
        // int sum = Add(); // == > 15 (5+10)
        //int sum = Add(25); // => 35
        // int sum = Add(b: 17, a: 10);
        //int sum2 = AddParam(10, 10, 25, 236, 240);
        //Console.WriteLine("The sum is : {0}",sum);
        //Console.WriteLine("The sum is : {0}", sum2);

        //int x = 15;
        //int result = AddRec(x);
        //Console.WriteLine(fibo(7));
        // Console.WriteLine(Bar(9));

        //Exceptions...

        Console.WriteLine("Enter First Numaber:");
        //int a = int.Parse(Console.ReadLine());
        if (!int.TryParse(Console.ReadLine(), out int a))
        {
            Console.WriteLine("Invalid value for a.");
            return;
        }
        Console.WriteLine("Enter Second Numaber:");
        //int b = int.Parse(Console.ReadLine());
        if (int.TryParse(Console.ReadLine(), out int b) == false)
        {
            Console.WriteLine("Invalid value for b.");
            return;
        }
        if (b == 0)
        {

            Console.WriteLine("Invalid value for secod number");
        }
        else
        {
            try
            {
                int result = Div(a, b);
                Console.WriteLine("The div result is :{0}", result);
            }
            catch(Exception ex)
            {
                 Console.WriteLine(ex.Message);                 
                 Console.WriteLine(ex.StackTrace);
                 Console.WriteLine("Could not divie a/b.");
            }
            finally
            {
                Console.WriteLine("Finally code");
            }


        }

    }
    static int fibo(int n)
    {
        if (n <= 2)
            return 1;
        return fibo(n - 1) + fibo(n - 2);

    }

    static int Add(int a = 5, int b = 10)
    {
        return a + b;
    }
    static int AddParam(params int[] values)
    {
        int sum = 0;
        for (int i = 0; i < values.Length; i++)
        {
            sum += values[i];
        }
        return sum;
    }
    static int Fact(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        return n * Fact(n - 1);
    }

    //
    // 1- F(n)= 1+2+3+...+n
    // 2- F(n)= n+ F(n-1)
    // F(5) => 1 ) = 1+2+3+4+5
    // F(5) => 2 ) = 5 + F(4)
    // F(4) => 1+2+3+4
    // F(5)  = 5 +1+2+3+4
    static int AddRec(int n)
    {
        if (n == 1)
            return 1;
        else
            return n + AddRec(n - 1);
    }

    static int Bar(int n)
    {
        if (n == 1)
            return 1;
        return 2 * Bar(n - 1) + 1;
    }

    //Exception Handling
    //مدیریت استثناها
    // 

    static int Div(int a, int b)
    {
        //throw new Exception("Manual Exception.");
        return a / b;
    }
}