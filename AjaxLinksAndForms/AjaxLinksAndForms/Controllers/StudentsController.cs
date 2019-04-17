﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxLinksAndForms.Data;
using AjaxLinksAndForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxLinksAndForms.Controllers
{
    public class StudentsController : Controller
    {
        SchoolDbContext schoolDbContext;

        public StudentsController(SchoolDbContext _schoolDbContext)
        {
            schoolDbContext = _schoolDbContext;
        }

        public IActionResult Index()
        {
            var students = schoolDbContext.Students;
            return View(students);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = schoolDbContext.Students.Find(id);
            schoolDbContext.Remove<Student>(student);
            schoolDbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = schoolDbContext.Students.Find(id);
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                schoolDbContext.Update<Student>(student);
                schoolDbContext.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public IActionResult AjaxDelete(int id)
        {
            var student = schoolDbContext.Students.Find(id);
            schoolDbContext.Remove<Student>(student);
            schoolDbContext.SaveChanges();
            var students = schoolDbContext.Students;
            return PartialView(students);
        }
    }
}