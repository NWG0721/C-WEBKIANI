using System.Collections;
class Program
{
    static void Main()
    {

        
        // int a =10;
        //Collection
        // Array 
        //آرایه: یک نوع داده ای است
        // که می تواند چندین مقدار
        //را از یک نوع و در قالب یک نام
        //در خود ذخیره کند

        //نحوه تعریف آرایه
        //1 ) [DataType][] [array_name] =new [DataType][Array_Length];
        //1.exp ) 
        int[] ar1 = new int[3];
        ar1[0] =5;
        ar1[1]=1;
        ar1[2]=17;
        //2) [DataType][] [array_name] =new [DataType][]{Values};
        //2.exp )
        int[] ar2 = new int[] { 10, 20, 30, 40 };
        //3) [DataType][] [array_name] ={Values};
        //3.exp )
        int[] ar3 = { 10, 20, 30, 40 };

        //نحوه دسترسی به اعضای آرایه
        // توسط اندیس خواهد بود
        // اندیس مجموعه ها از صفر شروع و تا
        //n-1
        //ادامه دارد که 
        //n
        // تعداد اعضای آرایه یا همان طول آرایه می باشد
        Console.WriteLine(ar3[0]);
        Console.WriteLine(ar3[1]);
        Console.WriteLine(ar3[2]);
        Console.WriteLine(ar3[3]);
        //Console.WriteLine(ar3[4]); => error

        //نکته: آرایه ها طول ثابتی دارند

        // از هر نوع داده می توان آرایه تعریف کرد
        Person[] prAra =new Person[4];
        prAra[0] =new Person();
        prAra[1] =new Person();
        prAra[2] =new Person();
        prAra[3] =new Person();
        //prAra[4] =new Person(); => error

        //َطول آرایه
        //Length => Returns the length of the array
        //exp
        Console.WriteLine(prAra.Length);

        //استفاده از حلقه ها برای دسترسی به مجموعه ها
        //for
        for (var i = 0; i < ar3.Length; i++)
        {
            Console.WriteLine("The value at index {0} => {1}",i,ar3[i]);
        }
        Console.WriteLine("************************");
        //foreach
        foreach (var item in ar3)
        {
            Console.WriteLine("The value is : {0}",item);
        }

        /*
        object[] objAr =new object[3];
        objAr[0] =10;
        objAr[1]="ali";
        objAr[2] =new Person();
        */
        
        ArrayList arList =new ArrayList();
        
        arList.Add(10);
        arList.Add(20);
        arList.Add("Ali");
        arList.Add(new Person());
        arList[3] ="aaaaa";
        Console.WriteLine("ArrayList[0]=>{0}",arList[0]);

        //Sorting Array

        Array.Sort(ar1); 

        foreach (var item in ar1)
        {
             Console.WriteLine("ar1 value after sort=>{0}",item);
        }
        Console.WriteLine("************************");

        //
        int[] arcp =new int[10];
        ar1.CopyTo(arcp,0);
        foreach (var item in arcp)
        {
             Console.WriteLine("arcp value after sort=>{0}",item);
        }
        


    }
}

