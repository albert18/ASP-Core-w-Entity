using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFCoreClassdesign
{

    class ClassStandard
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public string Description { get; set; }
        public List<Student> Students{ get; set; }
    }

    class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public string Gender { get; set; }
        public ClassStandard ClassStandard { get; set; }
        public List<Student_Course> Student_Courses { get; set; }
        public List<Exam> Exams { get; set; }
    }

    class Course
    {
        [Key]
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public string Description { get; set; }
        public List<Student_Course> Student_Courses { get; set; }
        public List<Exam> Exams { get; set; }
    }

    class Student_Course
    {
        [Key]
        public int SCid { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }
    }

    class Exam
    {
        public int ExamId { get; set; }
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public DateTime DOE { get; set; }
        public double Marks { get; set; }
        public Student Student { get; set; }
        public Course Course { get; set; }

    }


    class EFCoreQorganizationDb : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=AlbertG-PC;Database=ASP-Core-w-Entity;Trusted_Connection=True;");
        }

        public DbSet<ClassStandard> ClassStandards { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Exam> Exams { get; set; }

    }



    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
