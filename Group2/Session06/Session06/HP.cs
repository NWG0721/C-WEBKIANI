public class HP : IPrinter
{
    public void Print(string text)
    {
       Console.WriteLine("HP printer is printing : {0}",text);
    }
}