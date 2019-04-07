using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using TagHelperAndFormValidationsEg.Data;

namespace TagHelperAndFormValidationsEg.Models
{
    public class UniqueEmailAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            SchoolDbContext schoolDbContext = new SchoolDbContext();

            if (value != null)
            {
                int count = schoolDbContext.Students.Where(x => x.Email == value.ToString()).Count();
                if (count == 0)
                    return ValidationResult.Success;
                else
                    return new ValidationResult("This Email already exist!");
            }
            else
            {
                return new ValidationResult("Email is required!");
            }
        }
    }

    [Table("Student")]
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "User Name is required!")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        [UniqueEmail]
        public string Email { get; set; }

    }

    [NotMapped]
    public class StudentUpdate
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "User Name is required!")]
        public string Name { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}
