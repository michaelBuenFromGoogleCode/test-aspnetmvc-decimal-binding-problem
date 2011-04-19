using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TestBindingProblem.Models
{
    public class Person
    {
        public int PersonId { get; set; }
        public string Lastname { get; set; }
        public string Firstname { get; set; }
        public DateTime Birthday { get; set; }
        public decimal Salary { get; set; }
    }
}