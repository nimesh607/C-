namespace AccessModifier
{
    public class Program //Default type  is internal or we can change it to public
    {
        //Consuming members of class from same class
        // Public: accessible from anywhere
        public void PublicMethod()
        {
            Console.WriteLine("Public Method called");
        }

        // Private: accessible only within this class
        private void PrivateMethod()
        {
            Console.WriteLine("Private Method called");
        }

        // Protected: accessible within this class and by derived classes
        protected void ProtectedMethod()
        {
            Console.WriteLine("Protected Method called");
        }

        // Internal: accessible within the same assembly
        internal void InternalMethod()
        {
            Console.WriteLine("Internal Method called");
        }

        // Protected Internal: accessible within the same assembly or from derived classes
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("Protected Internal Method called");
        }

        // Private Protected: accessible within this class or derived classes in the same assembly (C# 7.2+)
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("Private Protected Method called");
        }

        static void Main(string[] args)
        {
            Program program = new Program();
            program.PublicMethod();
            program.PrivateMethod();
            program.ProtectedMethod();
            program.ProtectedInternalMethod();
            program.InternalMethod();
            program.PrivateProtectedMethod();
        }
       
    }
}
