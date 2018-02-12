using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ChatBot.Controllers
{
    public class ProfessorsController : Controller
    {
        ApplicationDbContext _context;

        public ProfessorsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Professors
        public ActionResult Index()
        {
            var professors = _context.Professors.ToList();
            return View(professors);
        }

        public ActionResult AddProfessor()
        {
            return View();
        }

        public ActionResult Create(Professors professors)
        {
            _context.Professors.Add(professors);
            _context.SaveChanges();
            return RedirectToAction("Index", "Professors");
        }
    }
}