 global using System.Collections;
namespace Collections

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Stack stack = new Stack();
            stack.Push(1); stack.Push(false);
            stack.Push(34.56);
            stack.Push(DateTime.Now);
            stack.Push("Nine");
           

            foreach (var item in stack)
            {
                Console.WriteLine(item + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Pop Operation : " + stack.Pop());


            foreach (var item in stack)
            {
                Console.WriteLine(item + " ");
                Console.WriteLine();
            }

            Console.WriteLine("Peek Operation : " + stack.Peek());// returns topmost element present in stack

            Console.WriteLine(stack.Count);
            Console.WriteLine(stack.Clear);

        }
    }
}
