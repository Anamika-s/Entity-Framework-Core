using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppEF_CodeFirst.Models
{
    public class Batch
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Subject { get; set; }
        public DateTime StartDate { get; set; }
        public string Trainer { get; set; }
    }
}
