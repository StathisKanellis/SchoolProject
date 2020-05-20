using System;
using System.ComponentModel.DataAnnotations;

namespace SchoolProject.Models
{
    public class Student
    {
        public int Id { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter your name/use only letters")]
        [Required(ErrorMessage = "Name required")]
        [MaxLength(30, ErrorMessage = "Characters exceed 30")]
        [Display(Name = "Name")]
        public string FirstName { get; set; }

        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Please enter your surname/use only letters")]
        [Required(ErrorMessage = "Surname required")]
        [MaxLength(30, ErrorMessage = "Characters exceed 30")]
        [Display(Name = "Surname")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Date of Birth reguired")]
        [DisplayFormat(DataFormatString ="{0:yyyy-MM-dd}", ApplyFormatInEditMode =true)]
        [DataType(DataType.DateTime)]
        [Display(Name="Date of birth")]
        public DateTime Birth { get; set; }

        [DataType(DataType.Currency)]
        [Range(0,5000)]
        [Display(Name="Fees")]
        public double? Fees { get; set; }
    }
}