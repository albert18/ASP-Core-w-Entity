using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

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
        public DbSet<Department> Departments { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            EFCoreQorganizationDb efCntx = new EFCoreQorganizationDb();
            //Select all departments
            List<Department> Depts = efCntx.Departments.ToList();

            Department D = new Department() { Description = "Development", Name = "Dev" };
            efCntx.Departments.Add(D);

            efCntx.SaveChanges();
        }
    }
}
