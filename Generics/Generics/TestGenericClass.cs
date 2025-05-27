using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    /// <summary>
    /// A generic Math class that supports basic arithmetic operations (Add, Subtract, Multiply, Divide)
    /// using a generic type T. This avoids writing separate methods for each data type like int, float, etc.
    /// 
    /// Note:
    /// This approach uses 'dynamic' internally to support operations on generic types,
    /// as C# does not support operators like '+' directly on generic types.
    /// </summary>
    public class Math<T>
    {
        /*
         * This method is a type-specific version and was useful only for integers.
         * It's commented out because the generic method below handles all supported types.
         */
        // public int Add(int a, int b)
        // {
        //     return a + b;
        // }

        /*
         * Previously, we also had a method with its own generic type parameter:
         * public T Add<T>(T a, T b) { ... }
         * 
         * But since the entire class is already generic (Math<T>),
         * there's no need to declare <T> again in the method.
         * We can use the class-level generic type directly.
         */

        T x; // Example of a class-level generic field (not used in operations below)

        /// <summary>
        /// Adds two values of generic type T using dynamic typing.
        /// </summary>
        public T Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 + d2; // Runtime '+' operation
        }

        /// <summary>
        /// Subtracts the second value from the first, using dynamic typing.
        /// </summary>
        public T Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 - d2; // Runtime '-' operation
        }

        /// <summary>
        /// Multiplies two values using dynamic typing.
        /// </summary>
        public T Multiply(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 * d2; // Runtime '*' operation
        }

        /// <summary>
        /// Divides the first value by the second using dynamic typing.
        /// </summary>
        public T Division(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            return d1 / d2; // Runtime '/' operation
        }
    }

    /// <summary>
    /// This class is used to test the generic Math<T> class functionality with different data types.
    /// </summary>
    internal class TestGenericClass
    {
        static void Main(string[] args)
        {
            // Create an instance of Math with int type
            Math<int> obj = new Math<int>();     // All operations will work on integers

            // Create an instance of Math with float type
            Math<float> obj2 = new Math<float>(); // All operations will work on float values

            // Create an instance of Math with string type
            Math<string> obj3 = new Math<string>(); // Only Add will work meaningfully (string concatenation), others will throw at runtime

            // Example usage (optional, you could add these for demonstration)
            Console.WriteLine(obj.Add(10, 20));           // Output: 30
            Console.WriteLine(obj2.Multiply(2.5f, 4.0f)); // Output: 10
            Console.WriteLine(obj3.Add("Hello, ", "World!")); // Output: Hello, World!
        }
    }
}
