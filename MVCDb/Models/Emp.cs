using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using MVCDb.Controllers;

#nullable disable

namespace MVCDb.Models
{
    public partial class Emp
    {
        [Display(Name = "Emp-Code")]
        public int Id { get; set; }
        [Display(Name ="Emp Name")]
        [Required(ErrorMessage ="Name Cannot be Blank")]
        public string Name { get; set; }
        [Display(Name="Salary")]
        [Range(10000,90000,ErrorMessage ="Salary Must in the Range of 10000-90000")]
        public int? Salary { get; set; }
        [Display(Name="Department")]
        [Required(ErrorMessage = "Department is Required")]
        public int? Deptid { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode =true,DataFormatString ="{0:yyyy-MM-dd}")]
        [DOBCheck(ErrorMessage ="You must be atleast 25 to work in LTI")]
        public DateTime? Dob { get; set; }
        [DataType(DataType.EmailAddress)]
        
        [Remote("EmailCheck","Emp",ErrorMessage ="Email already Exists")]
        [Required(ErrorMessage ="Email is Required")]
        public string Email { get; set; }

        public virtual Dept Dept { get; set; }
    }
}
