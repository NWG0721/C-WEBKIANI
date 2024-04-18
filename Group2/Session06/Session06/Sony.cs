public class Sony : IPrinter
{
    public void Print(string text)
    {
       Console.WriteLine("I am sony printer and i am printing {0}",text);
       Console.WriteLine("I am a black white printer");
    }
}