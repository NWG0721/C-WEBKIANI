namespace Session2_Group1
{
    public static class Program
    {
        static void Main(){
            //Console.WriteLine(Add(5,10,15));
            Console.WriteLine(Add(10,12,20,-10,50));
        }

        // static int Add(int a,int b)
        // {
        //     return a+b;
        // }
        
        // static int Add(int a,int b,int c)
        // {
        //     return a+b+c;
        // }

        bool 
        System.Boolean

        int 
        System.Int32

        static int Add (params int[] inputs)
        {
            int result =0;
            foreach (int val in inputs)
            {
                result +=val;
            }
            return result;
        }
    }
}