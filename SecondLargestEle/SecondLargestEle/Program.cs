namespace SecondLargestEle
{
    internal class Program
    {
        static int[] arr = { 10, 20, 4, 45, 99, 99, 23 };
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            for (int i = 0; i < arr.Length; i++)
            {
               
                if (arr[i] > arr[i+1])
                {
                    int lar = arr[i]; 
                }
              
            }
        }
    }
}
