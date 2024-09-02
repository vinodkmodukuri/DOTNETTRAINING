using ASPDOTNETMVCPractice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPDOTNETMVCPractice.Controllers
{
    public class AcademicsController : Controller
    {
        // GET: Academics
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ListOfPrograms ()
        {
            Programs programs = new Programs();
            programs.Program1 = "Accounting";
            programs.Program2 = " Automation";
            programs.Program3 = "Computer Science";

            //ViewData["AcademicPrograms"] = programs;
            //ViewBag.Programs = programs;

            return View(programs);
        }

        public ActionResult ListOfProgramsWithStats()
        {
            Programs programs = new Programs()
            {
                Program1 = "Accounting",
                Program2 = "Automation",
                Program3 = "Computer Science"
            };

            Stats stats = new Stats()
            {
                AcademicPrograms = 170,
                StudentOrganizations =500,
                StudyAbroadCities =200,
                CountriesRepresented = 135
            };

            ProgramsStatsViewModel programsStatsViewModel = new ProgramsStatsViewModel()
            {
                ListOfPrograms = programs,
                ListOfStats = stats,
                Title = "University Programs",
                Description = "we put our pride to work. We strive for excellence beyond the classroom, beyond the lab, and beyond the playing field. We transcend borders and create a place of belonging for all."
            };
            return View(programsStatsViewModel);
        }
    }
}