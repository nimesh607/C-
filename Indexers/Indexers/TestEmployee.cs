using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    public class Employee
    {
        int? _Id;
        string? _Name, _Job;
        double? _Salary;
        bool? _Status;


        public Employee(int id)
        {
            _Id = id;
            _Name = "Nicholas";
            _Job = "Manager";
            _Salary = 0.0;
            _Status = true;
        }

        public object? this[int Index] //Define Indexers
        {
            get
            {
                if (Index == 0)
                {
                    return _Id;
                }
                else if (Index == 1)
                {
                    return _Name;
                }
                else if (Index == 2)
                {
                    return _Job;
                }
                else if (Index == 3)
                {
                    return _Salary;
                }
                else if (Index == 4)
                {
                    return _Status;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (Index == 0)
                {
                    _Id = (int?)value;//value is object type so we need to convert it into int
                }
                else if (Index == 1)
                {
                    _Name = (string?)value;
                }
                else if (Index == 2)
                {
                    _Job = (string?)value;
                }
                else if (Index == 3)
                {
                    _Salary = (double?)value;
                }
                else if (Index == 4)
                {
                    _Status = (bool?)value;
                }

            }
        }

        public object? this[string Key] //Define Indexers Overloading
        {
            get
            {
                if (Key.ToUpper() == "ID")
                {
                    return _Id;
                }
                else if (Key.ToUpper() == "NAME")
                {
                    return _Name;
                }
                else if (Key.ToUpper() == "JOB")
                {
                    return _Job;
                }
                else if (Key.ToUpper() == "SALARY")
                {
                    return _Salary;
                }
                else if (Key.ToUpper() == "STATUS")
                {
                    return _Status;
                }
                else
                {
                    return null;
                }
            }

            set
            {
                if (Key.ToUpper() == "ID") //ID cannot be modified so to make read-only you can delete it 
                {
                    _Id = (int?)value;//value is object type so we need to convert it into int
                }
                else if (Key.ToUpper() == "NAME")
                {
                    _Name = (string?)value;
                }
                else if (Key.ToUpper() == "JOB")
                {
                    _Job = (string?)value;
                }
                else if (Key.ToUpper() == "SALARY")
                {
                    _Salary = (double?)value;
                }
                else if (Key.ToUpper() == "STATUS")
                {
                    _Status = (bool?)value;
                }

            }

        }
    }
        internal class TestEmployee
        {
            public static void Main(string[] args)
            {
                Employee Emp = new Employee(1);
                Console.WriteLine("Employee Id : " + Emp[0]);
                Console.WriteLine("Name  : " + Emp[1]);
                Console.WriteLine("Job : " + Emp[2]);
                Console.WriteLine("Salary: " + Emp[3]);
                Console.WriteLine("Status  : " + Emp[4]);

                Emp[2] = "Sr.Manager";
                Emp["Salary"] = 60000.00;

                Console.WriteLine("Employee Id : " + Emp["Id"]);
                Console.WriteLine("Name  : " + Emp["NAME"]);
                Console.WriteLine("Job : " + Emp["JOB"]);
                Console.WriteLine("Salary: " + Emp["SALARY"]);
                Console.WriteLine("Status  : " + Emp["Status"]);


                Console.WriteLine();

                Console.ReadLine();

            }
        }
    }
