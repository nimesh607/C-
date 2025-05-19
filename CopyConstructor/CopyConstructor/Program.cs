namespace CopyConstructor
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            CopyConDemo obj1 = new CopyConDemo(105);
            Console.WriteLine(obj1);
            obj1.Display();
            CopyConDemo obj2 = new CopyConDemo(obj1);
            obj2.Display();
            Console.WriteLine();
            obj1.balance = 1000.00;


        }
    }
}
