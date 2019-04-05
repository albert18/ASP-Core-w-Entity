using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewDataVsViewBagEg.Data;
using ViewDataVsViewBagEg.Models;

namespace ViewDataVsViewBagEg.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            SchoolDbContext schoolDbContext = new SchoolDbContext();
            List<Student> students = schoolDbContext.Students.ToList();
            return View(students);
        }

        [HttpGet]
        public IActionResult Create()
        {
            //if (TempData["Msg"] != null)
            //{
            //    string Msg = TempData["Msg"].ToString();
            //    ViewBag.Msg = TempData["Msg"].ToString();
            //}
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student S)
        {
            //string Msg;
            try
            {
                SchoolDbContext schoolDbContext = new SchoolDbContext();
                schoolDbContext.Add<Student>(S);
                schoolDbContext.SaveChanges();
                TempData["Msg"] = "Success!";
            }
            catch (Exception E)
            {
                TempData["Msg"] = "Failed!";
            }

            return RedirectToAction("Create", "Students");

        }

        public IActionResult Test()
        {
            string Msg = TempData["Msg"].ToString();
            return View();
        }
    }
}