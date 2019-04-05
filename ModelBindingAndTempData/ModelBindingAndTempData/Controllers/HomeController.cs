using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewDataVsViewBagEg.Data;
using ViewDataVsViewBagEg.Models;

namespace ViewDataVsViewBagEg.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            #region SimpleVDAndVB
            //ViewData["VD_MyData"] = 25;
            //ViewBag.VB_MyData = 45; 
            #endregion
            return View();
        }

        public IActionResult ReadStudent(int StudentId)
        {
            SchoolDbContext schoolDbContext = new SchoolDbContext();
            //Student S = schoolDbContext.Students.Find(StudentId);
            //ViewBag.myStudent = S;

            List<Student> students = schoolDbContext.Students.ToList();
            //ViewBag.students = students;

            return View(students);
        }
    }
}