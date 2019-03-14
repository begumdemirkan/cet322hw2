using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CET322_HW1.Models
{
    public class Student
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public int DepartmentId{ get; set; }

        public Department Department{ get; set; }
        [NotMapped]
        public virtual IEnumerable<SelectListItem> departments { get; set; }


    }
}
