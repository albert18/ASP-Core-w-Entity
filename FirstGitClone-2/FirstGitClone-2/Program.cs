using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FirstGitClone_2
{
    //POCO - Plain Old CLR Object

    class Department
    {
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    

    class EFCoreQorganizationDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AlbertG-PC;Database=ASP-Core-w-Entity;Trusted_Connection=True;");
        }

        public DbSet<Department> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
