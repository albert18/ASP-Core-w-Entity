using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TagHelperAndFormValidationsEg.Models;

namespace TagHelperAndFormValidationsEg.Data
{
    public class SchoolDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O84LAFN;Database=MVCSchoolDbValidations;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
