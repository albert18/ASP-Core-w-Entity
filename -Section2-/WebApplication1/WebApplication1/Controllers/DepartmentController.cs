using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //Controller
    public class DepartmentController : Controller
    {
        //Action
        public string GetDept()
        {
            return "Development";
        }
    }
}