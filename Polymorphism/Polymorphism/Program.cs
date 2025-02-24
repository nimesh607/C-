namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class2 obj = new Class2();
            obj.Show();
            obj.Show2();
            Class1 class1 = obj;
            obj.Show();
            obj.Show3();
        
        }
    }
}
