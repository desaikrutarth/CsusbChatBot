using ChatBot.Models;
using ChatBot.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatBot.Controllers
{
    public class CoursesController : Controller
    {
        ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Courses
        public ActionResult Index()
        {
            //var courses = _context.Courses.Include(c => c.professors).ToList();
            return View();
        }

        public ActionResult AddCourses()
        {
            var viewModel = new ProfessorCourseViewModel()
            {
                Professors = _context.Professors.ToList()
            };
            return View(viewModel);
        }

        public ActionResult Create(Courses courses)
        {
            _context.Courses.Add(courses);
            _context.SaveChanges();
            return RedirectToAction("Index", "Courses");
        }
    }
}