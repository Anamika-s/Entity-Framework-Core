using System;
using System.Collections.Generic;

#nullable disable

namespace WebApp_EF.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Batch { get; set; }
        public DateTime StartDate { get; set; }
    }
}
