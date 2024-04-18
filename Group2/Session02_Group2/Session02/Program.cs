// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

//number
//short =>  16b || 2B Signed
//int   =>  32b || 4B signed
//long  =>  64b || 8B Signed

//float 
// double 

// char  c='a';

// bool b =true; //false
// Console.WriteLine(short.MaxValue);

//int a1 = 10;
//Int32 a2 = 10;

//short  Int16
//int   Int32
//long  Int64

//bool  Boolean

//char Char

//float Single

//double Double

//decimal d =102.3m;
//Decimal

//char c='\0';
// string s1="";
// string s3=string.Empty;
//string s2=null;

// DayOfWeek2 d2 = DayOfWeek2.Tuesday;
// public enum DayOfWeek2
// {
//     Friday = 5,
//     Monday = 1,
//     Saturday = 6,
//     Sunday = 0,
//     Thursday = 4,
//     Tuesday = 2,
//     Wednesday = 3
// }

//Conditions

// int a = 10;
// bool b = false;
// string s = "C#";
// if (/*conditions*/  a > 10 && !b || s.Contains("c"))
// {
//     Console.WriteLine("True");
// }
// else if (/*conditions*/  a > 10 && !b || s.Contains("c"))
// {
//     Console.WriteLine("True");
// }
// else if (/*conditions*/  a > 10 && !b || s.Contains("c"))
// {
//     Console.WriteLine("True");
// }
// else if (/*conditions*/  a > 10 && !b || s.Contains("c"))
// {
//     Console.WriteLine("True");
// }
// else if (/*conditions*/  a > 10 && !b || s.Contains("c"))
// {
//     Console.WriteLine("True");
// }

// bool b =false;
// //if(b==false) //if(!b)
// if(b==true) // if(b)
// {}

// int a = 10;
// switch (a)
// {
//     case 5:
//         //
//         break;
//     case 10:
//         //
//         break;
//     case 14:
//         //
//         break;
//     default:
//         //
//         break;
// }

//////////////////////FOR LOOP\
//using Microsoft.Win32.SafeHandles;

// Console.WriteLine("*********FOR LOOP***************");
// for (int i = 0; i < 10; i++)
// {
//     Console.WriteLine(i);
// }
// Console.WriteLine("*********WHILE LOOP***************");

// int j = 0;
// while (j > 10)
// {
//     Console.WriteLine(j);
//     j++;
// }
// Console.WriteLine("*********DO WHILE LOOP***************");
// int k = 0;
// do
// {
//     Console.WriteLine(k);
//     k++;
// } while (k > 10);
// Console.WriteLine("*********FOREACH***************");

// string s = "Welcome to C# Programming!";
// foreach(char c in s)
// {

//     Console.WriteLine(c);
// }


int n = int.Parse(Console.ReadLine());
//int i = 0;
//while(i < n){
    //if (n % i == 0){
       // Console.WriteLine(i);
       bool r=true;
     int i=2;
     while(i<n)
     {
        if(n%i==0)
        {
            r=false;
            break;

        }
        i++;
     }
     if(r)
     System.Console.WriteLine("bye");
     else{

        System.Console.WriteLine("bye");
     }



    

