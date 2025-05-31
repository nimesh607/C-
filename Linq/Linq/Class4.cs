using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Class4
    {
        static void Main()
        {
            //Creating instance of Customer class using Object Initializers.
            Customer c1 = new Customer { Id = 101, Name = "Scott", City = "Delhi", Balance = 15000.00, Status = true };
            Customer c2 = new Customer { Id = 102, Name = "Dave", City = "Mumbai", Balance = 10000.00, Status = true };
            Customer c3 = new Customer { Id = 103, Name = "Sunitha", City = "Chennai", Balance = 15600.00, Status = false };
            Customer c4 = new Customer { Id = 104, Name = "David", City = "Delhi", Balance = 22000.00, Status = true };
            Customer c5 = new Customer { Id = 105, Name = "John", City = "Kolkata", Balance = 34000.00, Status = true };
            Customer c6 = new Customer { Id = 106, Name = "Jane", City = "Hyderabad", Balance = 19000.00, Status = true };
            Customer c7 = new Customer { Id = 107, Name = "Kavitha", City = "Mumbai", Balance = 16500.00, Status = true };
            Customer c8 = new Customer { Id = 108, Name = "Steve", City = "Bengaluru", Balance = 34600.00, Status = false };
            Customer c9 = new Customer { Id = 109, Name = "Sophia", City = "Chennai", Balance = 6300.00, Status = true };
            Customer c10 = new Customer { Id = 110, Name = "Rehman", City = "Delhi", Balance = 9500.00, Status = true };
            Customer c11 = new Customer { Id = 111, Name = "Raj", City = "Hyderabad", Balance = 9800.00, Status = false };
            Customer c12 = new Customer { Id = 112, Name = "Rupa", City = "Kolkata", Balance = 13200.00, Status = true };
            Customer c13 = new Customer { Id = 113, Name = "Ram", City = "Bengaluru", Balance = 47700.00, Status = true };
            Customer c14 = new Customer { Id = 114, Name = "Joe", City = "Hyderabad", Balance = 26900.00, Status = false };
            Customer c15 = new Customer { Id = 115, Name = "Peter", City = "Delhi", Balance = 17400.00, Status = true };

            //Created a List of Customers and added all the Customer instances into the List
            List<Customer> Customers = new List<Customer>()
            {
                c1,
                c2,
                c3,
                c4,
                c5,
                c6,
                c7,
                c8,
                c9,
                c10,
                c11,
                c12,
                c13,
                c14,
                c15
            };
            // Select specific fields from customers using an anonymous type.
            // 'IsActive' is an alias for the 'Status' property.
            var Coll = from C in Customers
                       select new { C.Id, C.Name, C.Balance, IsActive = C.Status };

            // Filtering customers based on specific conditions using WHERE clause.
            var Coll1 = from C in Customers where C.City == "Kolkata" select C;
            var Coll2 = from C in Customers where C.Balance > 40000 select C;
            var Coll3 = from C in Customers where C.City == "Hyderabad" && C.Balance > 20000 select C;
            var Coll4 = from C in Customers where C.City == "Delhi" || C.Balance > 20000 select C;

            // Sorting customers by name in ascending order.
            var Coll5 = from C in Customers orderby C.Name select C;

            // Sorting customers by balance in descending order.
            var Coll6 = from C in Customers orderby C.Balance descending select C;

            //Group By is done in 2 steps:
            //1)It will Divide the data present in table  based on Column used in groupby Clause
            //2)It will applies the aggregate function(Count,Max,Min,Sum)  used in query in each group to get a result .
            // Grouping customers by city and getting the count of customers in each group.
            // Equivalent SQL: SELECT City, COUNT(*) AS Customers FROM Customer GROUP BY City
            var Coll7 = from C in Customers
                        group C by C.City into G
                        select new { G.Key, Customers = G.Count() };

            // Explanation
            // // group C by C.City into G:
            // This groups the data from the 'Customers' list based on the 'City' property.
            // The group is assigned to a range variable 'G'. 
            // In C#, to access aggregate functions like Count(), we need an instance of the group.
            // Hence, we assign the group to a variable (in this case, 'G') so we can call methods like G.Count().
            // Example: G.Count() returns the number of elements in that specific city group.
            // Note: In the select clause after a group by, you can only use:
            //   1) Grouping key(s)
            //   2) Aggregate functions (Count, Sum, Max, etc.)
            //   3) Constants (e.g., DateTime.Now)

            var Coll8 = from C in Customers group C by C.City into G select new { City = G.Key, MaxBal = G.Max(C => C.Balance) };
            var Coll9 = from C in Customers group C by C.City into G select new { City = G.Key, MinBal = G.Min(C=> C.Balance) };
            var Coll10 = from C in Customers group C by C.City into G select new {City = G.Key, AvgBal = G.Average(C => C.Balance) };

            //Having Clause
            //used for filtering groups  where as Where clause is used for filtering rows
            //Note:always remember the sequence:
            //First,where will executes and sends data to => GroupBy will execute  sent data to =>Having will execute  sent data to => orderBy
            //when to Where and  when to use Having?
            //1)Analyse you want to filter row or Group ?if the requirement is filter row than use where  and if the requirement is  filter groups than use having
            //2)when the filter should be applied before grouping or after grouping ?=>if the ans is before where clause if the ans is after having .
            //3)is the condition using aggregate ?you cannot use where and aggregate in combination but you can use having and aggregate in combination .
            //4)you can use where clause individually but you cannot use having clause individually ,having clause should use only with group by.
            //in c# we do not have "having" clause, we are having only "where" clause and  it decides where we are using "where" clause if we are using before groupby in a query it will work like actuall "Where" clause but if you using after groupby thn it work  like "having" clause 

            // Example 1: Get cities having more than 2 customers.
            // Equivalent SQL:
            // SELECT City, COUNT(*) AS Customers FROM Customer GROUP BY City HAVING COUNT(*) > 2
            var Coll11 = from C in Customers group C by C.City into G where G.Count() > 2 select new { City = G.Key, Customers = G.Count() };
            
            // Example 2: Get cities where the maximum balance of customers is greater than 25,000.
            // Equivalent SQL:
            // SELECT City, MAX(Balance) AS MaxBalance FROM Customer GROUP BY City HAVING MAX(Balance) > 25000
            var Coll12 = from c in Customers
                       group c by c.City into G
                       where G.Max(c => c.Balance) > 25000 
                       select new
                       {
                           City = G.Key,
                           MaxBalance = G.Max(c => c.Balance)
                       };

            // Example 3: Get cities where the minimum balance is less than 10,000.
            // Equivalent SQL:
            // SELECT City, MIN(Balance) AS MinBalance FROM Customer GROUP BY City HAVING MIN(Balance) < 10000
            var Coll13 = from c in Customers
                       group c by c.City into G
                       where G.Min(c => c.Balance) < 10000
                       select new
                       {
                           City = G.Key,
                           MaxBalance = G.Min(c => c.Balance)
                       };

            foreach (var customer in Coll13)
            {
                Console.WriteLine(customer);
            }

        }
    }

}

