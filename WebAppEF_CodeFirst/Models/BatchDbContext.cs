using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppEF_CodeFirst.Models
{
    public class BatchDbContext : DbContext
    {
        public BatchDbContext(DbContextOptions<BatchDbContext> options) : base(options)
        {

        }
        public DbSet<Batch> Batches { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
