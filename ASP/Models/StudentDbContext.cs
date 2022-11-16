using ASP.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ASP.Models
{
    public class StudentDbContext : DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> contextOptions)
               : base(contextOptions)
        {

        }
        public DbSet<Student> Students { get; set; }

    }
}