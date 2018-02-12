using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ChatBot.Controllers.api
{
    public class CoursesController : ApiController
    {
        ApplicationDbContext _context;

        public CoursesController()
        {
            _context = new ApplicationDbContext();
        }

        //GET: /api/professors
        public IHttpActionResult GetCourses()
        {
            var courses = _context.Courses.Include(c => c.professors).ToList();
            return Ok(courses);
        }

        //GET: /api/professors/1
        public IHttpActionResult GetCourses(int id)
        {
            var courses = _context.Courses.Include(c => c.professors).SingleOrDefault(c => c.id == id);
            if (courses == null)
                return NotFound();
            return Ok(courses);
        }

        //POST: /api/professors
        [System.Web.Http.HttpPost]
        public IHttpActionResult CreatCourses(Courses courses)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Courses.Add(courses);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + courses.id), courses);
        }

        //PUT: /api/professors/1
        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateCourses(int id, Courses courses)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var coursesInDB = _context.Courses.Include(c => c.professors).SingleOrDefault(c => c.id == courses.id);
            if (coursesInDB == null)
                return NotFound();

            courses.name = coursesInDB.name;
            courses.number = coursesInDB.number;
            courses.professorsId = coursesInDB.professorsId;

            return Ok();
        }

        //DELETE: /api/professors/1
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteCourses(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var coursesInDB = _context.Courses.Include(c => c.professors).SingleOrDefault(c => c.id == id);
            if (coursesInDB == null)
                return NotFound();

            _context.Courses.Remove(coursesInDB);
            _context.SaveChanges();

            return Ok();
        }
    }
}
