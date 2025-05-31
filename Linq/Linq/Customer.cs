using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    internal class Customer //Complex type because it have multiple datatypes property 
    {
         
            public int Id { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
        public double Balance { get; set; }
        public bool Status { get; set; }
        public override string ToString() => $"Id: {Id}; Name: {Name}; City: {City}; Balance: {Balance}; Status: {Status}";
    }
}
