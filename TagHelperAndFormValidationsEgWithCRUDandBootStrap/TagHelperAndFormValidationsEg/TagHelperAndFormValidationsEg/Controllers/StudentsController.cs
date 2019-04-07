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
            SchoolDbContext schoolDbContext = new SchoolDbContext();
            var students = schoolDbContext.Students.ToList();
            return View(students);
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

        [HttpGet]
        public IActionResult Edit(int StudentId)
        {
            SchoolDbContext schoolDbContext = new SchoolDbContext();
            Student S = schoolDbContext.Students.Find(StudentId);
            return View(S);
        }

        [HttpPost]
        public IActionResult Edit(StudentUpdate SU)
        {
            if (ModelState.IsValid)
            {
                SchoolDbContext schoolDbContext = new SchoolDbContext();
                Student S = schoolDbContext.Students.Find(SU.StudentId);
                S.Name = SU.Name;
                S.Email = SU.Email;
                schoolDbContext.Update<Student>(S);
                schoolDbContext.SaveChanges();
                return RedirectToAction("Index", "Students");
            }
            return View();
        }

        [HttpGet]
        public IActionResult Delete(int StudentId)
        {
            SchoolDbContext schoolDbContext = new SchoolDbContext();
            Student S = schoolDbContext.Students.Find(StudentId);
            return View(S);
        }

        [HttpPost]
        public IActionResult Delete(Student S)
        {
                SchoolDbContext schoolDbContext = new SchoolDbContext();
                schoolDbContext.Remove<Student>(S);
                schoolDbContext.SaveChanges();
                return RedirectToAction("Index", "Students");
        }
    }
}