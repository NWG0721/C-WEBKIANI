// Loops in Loops
/*
for (int i = 0; i < 10; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (var k = 0; k < 4; k++)
        {
            // Console.WriteLine(i);
             Console.WriteLine("{0},{1},{2}",i,j,k);
        }
    }

}
*/

// Methods
//مجموعه دستوراتی است
//که در قالب یک نام مشخص دسته بندی می شوند
//هر متد می تواند دارای آرگومان های ورودی باشد
//هر متد باید دارای نوع خروجی باشد
// نکته
// متد هایی که مقداری را بر نمی گردانند از کلمه کلیدی
//void
//برای نوع بازگشتی متد استفاده می کنیم
//تعریف متد:
// static [return type / void] [method name] ([method arguments]){ [Method body => statements] }
//در این دوره متد ها درون کلاس تعریف می شوند
// نام متد  ها الزما به صورت پاسکال نوشته می شوند.
// این الزام یک استاندار است
public class Program
{
    static void Main()
    {
        //method call
        //SayHello();
        //PrintData("Welcome to Programming.");
        //Console.WriteLine("Enter your name:");
        //SayWelcomeToUser(Console.ReadLine());       
        // int sum= Add(10,20,30,20);       
        // Console.WriteLine("Sum:{0}",sum);
        Console.WriteLine("Enter number:");
        int n = int.Parse(Console.ReadLine());
        //int result= Fact(n);
        //MaghsumAlayh(n);
        //Console.WriteLine("Result:{0}",result);

        // int factRecResult= FactRec(n);
        // Console.WriteLine("Result:{0}",factRecResult);

        // int fiboRecResult = FiboRec(n);
        // Console.WriteLine("Result:{0}", fiboRecResult);

        long hanoiResult= Hanoi(n);
        Console.WriteLine("Result:{0}", hanoiResult);

    }

    //Method definition

    // static void SayHello()
    // {
    //     Console.WriteLine("Hello");
    // }
    // static void PrintData(string data)
    // {
    //     Console.WriteLine(data);
    // }   
    //   static void SayWelcomeToUser(string userName)
    // {
    //     Console.WriteLine("Welcome {0}",userName);
    // } 

    /*
     static int Add(int value1,int value2)
     {
         int result=value1+value2;
         return result;
     }
     // Method Overloading
      static int Add(int value1,int value2,int value3)
     {
         int result=value1+value2 +value3;
         return result;
     }
     */
    //   static int Add(params int[] values)
    // {
    //     int sum =0;
    //     for (var i = 0; i < values.Length; i++)
    //     {
    //         sum +=values[i];
    //     }
    //    return sum;

    // }

    // 5 => 1*2*3*4*5 
    // int result=1;
    // for => i=1 to 5
    // result= result *i;
    static int Fact(int n)
    {
        int result = 1;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        return result;
    }

    static void MaghsumAlayh(int n)
    {

        for (int i = 1; i <= n; i++)
        {
            if (n % i == 0)
            {
                Console.WriteLine(i);

            }
        }
    }

    // متدهای بازگشتی
    //Recursive Method
    //در متدهای بازگشتی
    //یک متد می تواند خودش را فراخوانی کند
    // مانند زیر
    //static void X()
    //{
    //X();     
    // }


    // static int FactRec(int n)
    // {
    //     if (n == 1)
    //         return 1;
    //     return n * FactRec(n - 1);
    // }

    //   static int FiboRec(int n)
    // {
    //     if (n  <3)
    //         return 1;
    //     return FiboRec(n-2) + FiboRec(n-1);
    // }

    static long Hanoi(int n)
    {
        if (n < 2)
            return 1;
        //return (2 * Hanoi(n - 1)) + 1;
       return Hanoi(n-1) +Hanoi(n-1) +1;

    }

}