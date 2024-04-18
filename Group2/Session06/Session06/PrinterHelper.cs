public static class PrinterHelper
{
    // Static class
    //static Method

    public static void PrintByHp(string text)
    {
        Console.WriteLine("HP printer is printing : {0}",text);
    }
      public static void PrintBySamsung(string text)
    {
        Console.WriteLine("Samsung printer is printing : {0}",text);
    }
    public static void Print(IPrinter printer,string text)
    {
        printer.Print(text);
    }

}