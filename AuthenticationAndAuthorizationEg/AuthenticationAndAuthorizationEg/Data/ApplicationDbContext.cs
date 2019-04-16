using AuthenticationAndAuthorizationEg.Models;
//1
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationAndAuthorizationEg.Data
{
    //2
    public class ApplicationDbContext: IdentityDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-O84LAFN;Database=MyApplicationWithSecurityDb;Trusted_Connection=True;");
        }

        public DbSet<Student> Students { get; set; }
    }
}
