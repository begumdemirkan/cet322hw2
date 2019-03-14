using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CET322_HW1.Models
{
    public class Department
    {

        public int Id { get; set; }
        [Display(Name = "Department")]
        public string Dname { get; set; }
        public virtual IEnumerable<Student> Students { get; set; }


    }
}
