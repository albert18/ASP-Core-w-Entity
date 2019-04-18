using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjaxLinksAndForms.Data;
using AjaxLinksAndForms.Models;
using Microsoft.AspNetCore.Mvc;

namespace AjaxLinksAndForms.Controllers
{
    [Produces("application/json")]
    public class JAStudentsController : Controller
    {
        SchoolDbContext schoolDbContext;

        public JAStudentsController(SchoolDbContext _schoolDbContext)
        {
            schoolDbContext = _schoolDbContext;
        }

        //public IActionResult GetStudents()
        //{
        //    var students = schoolDbContext.Students;
        //    return Json(students);
        //}
        
        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            var students = schoolDbContext.Students;
            return students;
        }

        [HttpGet]
        public Student GetByStudentId(int id)
        {
            var student = schoolDbContext.Students.Find(id);
            return student;
        }
        [HttpGet]
        public string DeleteByStudentId(int id)
        {
            var student = schoolDbContext.Students.Find(id);
            schoolDbContext.Remove<Student>(student);
            schoolDbContext.SaveChanges();
            return "Deleted Successfully";
        }

        [HttpPost]
        public string UpdateStudent(Student student)
        {
            schoolDbContext.Update<Student>(student);
            schoolDbContext.SaveChanges();
            return "Updated Successfully";
        }

        [HttpPost]
        public string CreateStudent(Student student)
        {
            schoolDbContext.Add<Student>(student);
            schoolDbContext.SaveChanges();
            return "Created Successfully";
        }
    }
}