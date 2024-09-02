using Antlr.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace ASPDOTNETMVCPractice.Controllers
{
    public class Professor
    {
        public string professorName { get; set; }

        public string professorDept { get; set; }

        public override string ToString()
        {
            return this.professorName + " " + this.professorDept;
        }

    }

    public class CoursesController : Controller
    {

        // GET: Courses
        public ActionResult Index()
        {
            return View();
        }

        public string list()
        {
            return "Engineering" + " " + "Nursing" + " " + "MBA";
        }

        public Professor ListOfProfessors()
        {
            Professor professor = new Professor();

            professor.professorName = "David North";
            professor.professorDept = "Engineering";

            return professor;
        }


        //non-action methods 
        [NonAction]
        public string Directors()
        {

            return " The new director is Kevin";
        }

        public ActionResult Amenities()
        {


            return View();
        }
    }
}