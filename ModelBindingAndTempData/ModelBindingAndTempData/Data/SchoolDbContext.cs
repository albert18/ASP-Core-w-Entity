using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ViewDataVsViewBagEg.Models;

namespace ViewDataVsViewBagEg.Data
{
    public class SchoolDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O84LAFN;Database=MVCSchoolDb;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
