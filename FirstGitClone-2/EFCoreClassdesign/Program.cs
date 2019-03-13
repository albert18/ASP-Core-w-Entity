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
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
