using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TagHelperAndFormValidationsEg.Data;
using TagHelperAndFormValidationsEg.Models;

namespace TagHelperAndFormValidationsEg.Controllers
{
    public class StudentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student S)
        {
            if (ModelState.IsValid)
            {
                SchoolDbContext schoolDbContext = new SchoolDbContext();
                schoolDbContext.Add<Student>(S);
                schoolDbContext.SaveChanges();
                return RedirectToAction("Create", "Students");
            }
            return View();
        }
    }
}