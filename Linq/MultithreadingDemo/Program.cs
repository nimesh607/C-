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
            static void Test2()
            {
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);

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
}