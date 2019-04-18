using AjaxLinksAndForms.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxLinksAndForms.Data
{
    public class SchoolDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O84LAFN;Database=AjaxSchoolDb;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
