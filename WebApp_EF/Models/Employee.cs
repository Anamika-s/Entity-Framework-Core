using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_EF.Models
{
    public partial class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dept { get; set; }
        public int Salary { get; set; }
    }
}
