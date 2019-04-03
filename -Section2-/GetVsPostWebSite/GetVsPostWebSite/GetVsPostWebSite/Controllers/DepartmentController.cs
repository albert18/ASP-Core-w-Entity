using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GetVsPostWebSite.Controllers
{
    //Controller
    public class DepartmentController : Controller
    {
        //Action
        public string GetDept(int id)
        {
            string[] Depts = new string[] {
                "Testing","Development","HR","QA","Admin"
            };

            return Depts[id].ToString();
        }

        public string Index()
        {
            return "Manzoor The Trainer - From Index";
        }
    }
}