using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace EFCoreFirstProject
{
    //POCO - Plain Old CLR Object
    class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    class EFCoreQorganizationDb : DbContext
    {
        public DbSet<Department> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Department D = new Department() { DepartmentId = 1, Description = "Development", Name = "Dev" };

            EFCoreQorganizationDb efCntx = new EFCoreQorganizationDb();
            //Select all departments
            List<Department> Depts = efCntx.Departments.ToList();

            efCntx.Departments.Add(D);

            efCntx.SaveChanges();
        }
    }
}
