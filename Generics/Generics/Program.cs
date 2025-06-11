using System.Security.Cryptography.X509Certificates;

namespace Generics
{
    internal class Program
    {
        /*
         * This method demonstrates how equality is currently being checked using objects.
         * Although this allows any data type to be passed (because all types inherit from object),
         * there are three main disadvantages:
         * 
         * 1. **Lack of Type Safety** – This allows comparing values of different types (e.g., int vs string), which is usually undesirable.eg:AreEqual(10, "10");This will compile just fine, but it's comparing an int and a string, which makes no real sense logically.You won’t know it’s a bad comparison until runtime — it could even silently return false.
         * 2. **Runtime Errors** – Type mismatches may only show errors at runtime, not compile time.eg:AreEqual(10, null);It could throw a NullReferenceException if you’re not handling null properly.Even worse, it won’t catch type mismatch errors at compile time, so bugs can slip in easily.
         * 3. **Boxing and Unboxing Overhead** – For value types like int or double, boxing (converting to object) and unboxing (back to original type) occur, which affects performance.
         * 
         * For example, comparing two integers using objects involves converting them to object type first, which is inefficient.
         * A better way would be to use Generics to enforce type safety and avoid boxing.
         */
        /*   public bool AreEqual(object a, object b)
           {
               if (a.Equals(b)) return true;
               return false;
           }*/

        public bool AreEqual<T1,T2>(T1 a, T2 b) //One method ,still achieving type safety
        {
            if (a.Equals(b)) return true;
            return false;
        }

        public bool AreEqual<T>(T a, T b) //One method ,still achieving type safety
        {
            if (a.Equals(b)) return true;
            return false;
        }

        static void Main(string[] args)
        {
            // Create an instance of Program to call non-static AreEqual method
            Program program = new Program();

            // Comparing integers
            Console.WriteLine(program.AreEqual<int>(10, 20));   // Output: False
            Console.WriteLine(program.AreEqual<int>(20, 20));   // Output: True
            Console.WriteLine(program.AreEqual<bool>(true,true));

            // Comparing strings
            Console.WriteLine(program.AreEqual<String>("Hello", "Hello")); // Output: True
            // This works correctly because strings override Equals and == operator to compare content, not reference

            // Comparing doubles
            Console.WriteLine(program.AreEqual<double>(34.32, 34.32)); // Output: True
            Console.WriteLine(program.AreEqual<double>(34.32, 34.34)); // Output: false
            // Here, Equals checks the value content, so it works.
            // However, using object type still involves boxing and should be avoided in performance-critical code.

            // Note:
            // Console.WriteLine(program.AreEqual(34.34, 53.3)); // This would work with object parameters, but still suffers the issues discussed.

            //To overcome all these problems ,we can use Generics


        }
    }
}
