namespace Generic_Delegate
{
    /*  public delegate double Delegate1(int x, int y, double z);
       public  delegate void Delegate2(int x, int y, double z);
       public delegate bool Delegate3(string str);*/

    //without defining expictly delegates, we can use Func, Action and Predicate which are built-in delegates in C#.
    internal class Program
    {

        /* As i have used lambda expression in Delegate1, i don't need to define it explicitly.
         * public static double AddNums1(int x,int y,double z)
         {
             return x + y + z;
         }*/

        //As i have used lambda expression in Delegate2, i don't need to define it explicitly.
        /* public static void  AddNums2(int x, int y, double z)
         {
             Console.WriteLine(x+y+z);

         }*/

        public static bool CheckLength(string str)
        {
            if (str.Length > 5)
            {

                return true;
            }
                return false;
               
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            /// Delegate1 obj1 = AddNums1;
            Func<int, int, double, double> obj1 = (x, y, z) => x + y + z;//use Func for return type with parameters

            double result1 = obj1(10, 20, 30.00);
            Console.WriteLine(result1);


            //Delegate2 obj2 = new Program().AddNums2;
            Action<int, int, double> obj2 = (x, y, z) => Console.WriteLine(x + y + z);//use action for void return type
            obj2.Invoke(10, 20, 30.00);

            //Delegate3 obj3 = CheckLength;
            Predicate<string> obj3 = CheckLength;//use predicate for boolean return type
            bool status = obj3.Invoke("Hello");
            Console.WriteLine(status );
        }
    }
}
