public class Samsung : IPrinter
{
    public void Print(string text)
    {
         Console.WriteLine("Samsung printer is printing : {0}",text);
    }
}