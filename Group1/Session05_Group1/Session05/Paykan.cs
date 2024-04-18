using System.IO.Compression;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

public class Paykan : Car
{
    public Paykan(int maxSpeed) :base(maxSpeed)
    {
      
    }
       public override string GetInfo()
        {
                return $"{this.GetName()}:{this.Color}:{this.MaxSpeed}";
        }
         public override string GetName()
         {
            return "Paykan Javanan";
         }
    // A :B,C,D,E ERROR
   //A :B
   // B:C
   //C:D
}