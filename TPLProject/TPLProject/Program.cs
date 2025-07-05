namespace TPLProject
{
    internal class Program
    {
        static void Print1()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print1 Method: {i}");//Every thread have unique id 
            }
        }
        static void Print2()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print2 Method: {i}");
                if (i == 50)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Thread.Sleep(10000);
                }
            }
          
        }
        static void Print3()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine($"Thread Id: {Thread.CurrentThread.ManagedThreadId}; Print3 Method: {i}");
            }
        }
            static void Main(string[] args)
        {
            //Single Threaded model execute by main threaded
            Console.WriteLine("Hello, World!");
            Print1();
            Print2();
            Print3();
        }
    }
}
