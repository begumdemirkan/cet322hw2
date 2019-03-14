using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using CET322_HW1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace CET322_HW1.Controllers
{
    public class StudentsController : Controller
    {

        StudentContext StudentContext;

        public StudentsController(StudentContext context)
        {
            StudentContext = context;

        }
        public IActionResult Index()
        {
        var students = StudentContext.Students.ToList();
       
            return View(students);
        }
     

        public IActionResult Detail(int id)
        {
            Student student = StudentContext.Students.Where(s => s.Id == id).FirstOrDefault();
            if (student != null)
            {
                return View(student);
            }
            else
            {
                return NotFound();
            }
        }
        public ActionResult Add()
        {
            Student student = new Student();
            IEnumerable<Department> dep = StudentContext.Department.ToList();
            student.departments = GetDepartments(dep);
            return View(student);
          
            
        }
        private IEnumerable<SelectListItem> GetDepartments(IEnumerable<Department> departments)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="State Name">State Name</option>
            foreach (var element in departments)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element.Id.ToString(),
                    Text = element.Dname
                });
            }

            return selectList;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Add(Student student)
        {
            if (ModelState.IsValid)
            {
                student.Department = StudentContext.Department.Where(x => x.Id == student.DepartmentId).FirstOrDefault();
                StudentContext.Students.Add(student);

                await StudentContext.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(student);
        }




        [HttpGet]
        public ActionResult Edit(int id)
        {
            var stu = StudentContext.Students.Find(id);
            var list = new List<String>() { "Computer Education and Educational Technology", "Geography", "International Relationship", "Psychology" };
            return View("Edit", stu);
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            StudentContext.Entry(student).State = EntityState.Modified;
            StudentContext.SaveChanges();
            return RedirectToAction("Index");
        }



        public ActionResult Delete(int id = 0)
        {
            Student stu = StudentContext.Students.Find(id);
            if (stu == null)
            {
                return HttpNotFound();
            }
            return View(stu);
        }

        private ActionResult HttpNotFound()
        {
            throw new NotImplementedException();
        }



        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Student stu = StudentContext.Students.Find(id);
            StudentContext.Students.Remove(stu);
            StudentContext.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            StudentContext.Dispose();
            base.Dispose(disposing);
        }

    }
}


