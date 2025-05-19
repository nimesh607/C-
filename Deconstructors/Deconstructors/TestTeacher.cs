using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deconstructors
{
    public class Teacher
    {
        int? Id;
        string? Name, Subject, Designation;
        double? Salary;

        public Teacher(int? Id, string? Name, string? Subject, string? Designation, double? Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Subject = Subject;
            this.Designation = Designation;
            this.Salary = Salary;
        }
        //Deconstructor:This member of the class is also use for exposing values that are associated with class to the outside environment just like props and indexers,but deconstructor can give only read only acess to the values but not read-write or write access.
        //A Deconstructor is just a method in  the class with the name Deconstruct and the logic of this method will reverse to the content in constructor
        public void Deconstruct(out int? Id, out string? Name, out string? Subject, out string? Designation, out double? Salary)//opposite of input parameter is out 
        {
            Id = this.Id;//reverse field value to parameter
            Name = this.Name;
            Subject = this.Subject;
            Designation = this.Designation;
            Salary = this.Salary;
        }

        public void Deconstruct(out int? Id,  out string? Subject, out string? Designation, out double? Salary)//Deconstructor overloading
        {
            Id = this.Id;
            Subject = this.Subject;
            Designation = this.Designation;
            Salary = this.Salary;
        }


    }
    internal class TestTeacher
    {
        static void Main(string[] args)
        {
            Teacher obj = new Teacher(1005, "Suresh", "English", "Lecturer", 25000.00);
            (int? Id1, string? Name1, string? Subject1, string? Designation1, double? Salary1) = obj;//Read the values
            Console.WriteLine("Teacher Id: " + Id1);
            Console.WriteLine("Teacher Name: " + Name1);
            Console.WriteLine("Teacher Subject: " + Subject1);
            Console.WriteLine("Teacher Designation: " + Designation1);
            Console.WriteLine("Teacher Salary: " + Salary1 + "\n");

            Console.WriteLine();

          (var Id2, var Name2, var Subject2, var Designation2, var Salary2) = obj;//we can also load values like this way.if we dont know datatype we can use var or dynamic
            Console.WriteLine("Teacher Id: " + Id2);
            Console.WriteLine("Teacher Name: " + Name2);
            Console.WriteLine("Teacher Subject: " + Subject2);
            Console.WriteLine("Teacher Designation: " + Designation2);
            Console.WriteLine("Teacher Salary: " + Salary2 + "\n");

            var (Id3, Name3, Subject3, Designation3, Salary3) = obj;//Simplified Version
            Console.WriteLine("Teacher Id: " + Id3);
            Console.WriteLine("Teacher Name: " + Name3);
            Console.WriteLine("Teacher Subject: " + Subject3);
            Console.WriteLine("Teacher Designation: " + Designation3);
            Console.WriteLine("Teacher Salary: " + Salary3 + "\n");

            var (Id4, Subject4, Designation4, Salary4) = obj;//if i want to read only id,subject,designation and salary than i need to overload deconstructor 
            Console.WriteLine("Teacher Id: " + Id4);
            Console.WriteLine("Teacher Subject: " + Subject4);
            Console.WriteLine("Teacher Designation: " + Designation4);
            Console.WriteLine("Teacher Salary: " + Salary4 + "\n");

            var (Id5,_, Subject5,_, Salary5) = obj;//Now suppose i want to load values mix and match that means sometime only name,only id ,or only id and name etc than do i need that much amount od deconstructor overloading ?No  just put “_” in the  place whose values we don’t want to access
            Console.WriteLine("Teacher Id: " + Id5);
            Console.WriteLine("Teacher Subject: " + Subject5);
            
            Console.WriteLine("Teacher Salary: " + Salary5 + "\n");

        }

    }
}
