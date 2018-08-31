using labQuiz_TARATHEP_ORA03_NETCore.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;


namespace labQuiz_TARATHEP_ORA03.Controllers
{
    public class EmployeeController : Controller
    {

        //change
        private EmployeeContext db = new EmployeeContext();
        private IHostingEnvironment _env;

        //add
        public EmployeeController(EmployeeContext db, IHostingEnvironment env)
        {
            this.db = db;
            this._env = env;
        }

       
        public IActionResult employeeJson()
        {
            var data = db.Employees.ToList();
            return Json(data);
        }

        // GET: Employee
        public IActionResult Index()
        {
            var webRoot = _env.WebRootPath;

            var file = System.IO.Path.Combine(webRoot, "test.txt");

            System.IO.File.WriteAllText(file, "Hello World!");
            //System.IO.TextWriter();

            return View();
        }

        public ActionResult Details(int? id)
        {
            return View(db.Employees.Find(id));
        }

        public ActionResult Create()
        {
            ViewData["title_dl"] = new SelectList(db.Titles.Select(p=>p.titleName));
            ViewData["gen_dl"] = new SelectList(db.Genders, "genderId", "genderDescription");
            ViewData["department_dl"] = new SelectList(db.Departments.Select(p => p.DeptName));
            
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employees emp)
        {
            //CREARE AUTO INCREATEMENT KEY
            var k = db.Employees.OrderByDescending(s => s.empNo).ToList()[0].empNo;
            emp.empNo = k+1;

            db.Employees.Add(emp);
            db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int? id)
        {
            Employees emp = db.Employees.Find(id);
         
            //change mapping for match model data
            ViewData["title_dl"] = new SelectList(db.Titles.Select(p => p.titleName));
            ViewData["gen_dl"] = new SelectList(db.Genders, "genderId", "genderDescription");
            ViewData["department_dl"] = new SelectList(db.Departments, "DeptNo", "DeptName");

            return View(emp);
      
        }
        [HttpPost]
        public ActionResult Edit(Employees emp)
        {
            
            var data = db.Employees.Single(p => p.empNo == emp.empNo);
            data.titleName = emp.titleName;
            data.firstName = emp.firstName;
            data.lastName = emp.lastName ;
            data.gender = emp.gender;
            data.department = emp.department;
            data.salary = emp.salary;

            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int? id)
        {
            
            Employees data = db.Employees.Find(id);
         
            return View(data);
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            Employees data = db.Employees.Find(id);
            db.Employees.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

       
    }
}