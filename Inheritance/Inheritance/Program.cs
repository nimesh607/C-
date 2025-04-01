namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Class2 obj = new Class2();// obj is instance  (Child Instance)
            Class1 obj1 = obj;// parent  variable can intialize by child class instance but cannot access the members of child class and obj1 is reference(Child->Parent)
            //obj1.print2();//cannot access members of child class
            Console.WriteLine(obj1);
            obj1.print();
           //Class2 obj2 = obj1;//Parent ->Child not possible implicitly
            Class2 obj4 = (Class2)obj1;//Possible through explicitly.(Parent ->Child)
          
            Console.WriteLine(obj4);
            Class1 obj3 = obj;//Child -> Parent possible
            //obj3.print();
            obj.print();
            //Console.WriteLine(obj2);

            //Class1 b= new Class1();//Invalid and Implicit Conversion
            //Class2 b2 = (Class2)b;//Invalid and Explicit Conversion 
            //Console.WriteLine(b2);
            /*Notes:1)Parent cannot be converted into Child 
                    2)Child Can be converted into parent
                    3)We can convert a parent class Refrence that is initialized by child class instance back into class reference 
            4) WE can send the parameteres from child class constructor to parent  class constructor if parent class constructor is parameterised constructor by using base keyword in child class constructor 
            Like this : public Class2(x):base(x)
        {
            Console.WriteLine("Calling Constructor of class 2");
            
        }
            Child Instance => Parent Reference //Valid
            Child Instance => Parent Reference => Child Reference // Valid
            Parent Instance =>Child Reference//Invalid
            */
            Student s = new Student();
            s.RollNo = 123;
            s.Print();

            // Working with the nested DerivedClass
            Student.DerivedClass derivedObj = new Student.DerivedClass();
            derivedObj.ShowValues();


        }
    }
}
