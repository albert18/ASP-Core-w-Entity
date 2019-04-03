using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace GetVsPostWebSite.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        #region Parameterized Method
        //public ViewResult Save(int DeptId,string DeptName)
        //{
        //    //Write Logic to save
        //    return View();
        //}

        //public ViewResult GetDept(int DeptId)
        //{
        //    //Write Logic to read dept
        //    return View();
        //} 
        #endregion

        public ViewResult Save()
        {
            int DeptId = int.Parse(Request.Form["DeptId"].ToString());
            string DeptName = Request.Form["DeptName"].ToString();
            //Write Logic to save
            return View();
        }

        public ViewResult GetDept()
        {
            int DeptId = int.Parse(Request.Query["DeptId"].ToString());
            //Write Logic to read dept
            return View();
        }
    }
}