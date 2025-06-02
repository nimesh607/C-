namespace MultithreadingDemo
{
    internal class Program
    {
        static void Test1()
        {
            for (int i = 0; i <= 100; i++)
            {
                Console.WriteLine(i);
                
            }
        }
            static void Test2()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);
                if (i == 50)
                {
                    Console.WriteLine("Main thread going to Sleep");
                    Thread.Sleep(5000);//5 seconds
                    Console.WriteLine("Main thread Woke Up");
                }
            }

            }
            static void Test3()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);

                }
            }
        static void Main(string[] args)
        {
            Test1();
            Test2();
            Test3();

        }
    }
       
    
}