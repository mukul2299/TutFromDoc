using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TutFromDoc.Models;

namespace TutFromDoc.Controllers
{
    public class StudentController : Controller
    {
        static StudentRepo studentRepo = new StudentRepo();
        
        
        // GET: Student
        public ActionResult Index()
        {
            return View(studentRepo.getStudentList());
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(studentRepo.getStudentById(id));
        }
    }
}



           