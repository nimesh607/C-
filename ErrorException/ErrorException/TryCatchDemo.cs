namespace ErrorException
{
    internal class TryCatchDemo
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st number: ");
                int x = int.Parse(Console.ReadLine());
                Console.Write("Enter 2nd number: ");
                int y = int.Parse(Console.ReadLine());
                int z = x / y; //exception manager will identify and Creates the instance of matching exception  
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("The result of division is: " + z);
            }
            catch (DivideByZeroException ex)//Object is assigned to 'ex' variable which was thrown by exception manager .and if an instance is assinged in a variable than variable becomes reference 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value of divisor can't be zero.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (FormatException) // try can have mutliple catch blocks 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Input values must be integers.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex) //Handles every exception with the help of ExceptionClass .Best Practise is First specific exception handling than in  last General exception handling and here ex is Exception type (Parent)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(ex.Message);//Display pre defined message .Here Dynamic Polymorphism concept will applied 
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ForegroundColor= ConsoleColor.Yellow; //after catch all statements will execute  
            Console.WriteLine("End of the Program.");
        }
    }
}
