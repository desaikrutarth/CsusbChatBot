using ChatBot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;


namespace ChatBot.Controllers.api
{
    public class ProfessorsController : ApiController
    {
        ApplicationDbContext _context;

        public ProfessorsController()
        {
            _context = new ApplicationDbContext();
        }

        //GET: /api/professors
        public IEnumerable<Professors> GetProfessors()
        {
            return _context.Professors.ToList();
        }

        //GET: /api/professors/1
        public IHttpActionResult GetProfessors(int id)
        {
            var professors = _context.Professors.SingleOrDefault(c => c.id == id);
            if (professors == null)
                return NotFound();
            return Ok(professors);
        }

        //POST: /api/professors
        [System.Web.Http.HttpPost]
        public IHttpActionResult CreateProfessors(Professors professors)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            _context.Professors.Add(professors);
            _context.SaveChanges();
            return Created(new Uri(Request.RequestUri + "/" + professors.id), professors);
        }

        //PUT: /api/professors/1
        [System.Web.Http.HttpPut]
        public IHttpActionResult UpdateProfessors(int id, Professors professors)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var professorsInDB = _context.Professors.SingleOrDefault(c => c.id == professors.id);
            if (professorsInDB == null)
                return NotFound();

            professors.fname = professorsInDB.fname;
            professors.lname = professorsInDB.lname;
            professors.email = professorsInDB.email;
            professors.phone = professorsInDB.phone;
            professors.location = professorsInDB.location;
            professors.officeHours = professorsInDB.officeHours;

            return Ok();
        }

        //DELETE: /api/professors/1
        [System.Web.Http.HttpDelete]
        public IHttpActionResult DeleteProfessors(int id)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var professorsInDB = _context.Professors.SingleOrDefault(c => c.id == id);
            if (professorsInDB == null)
                return NotFound();

            _context.Professors.Remove(professorsInDB);
            _context.SaveChanges();

            return Ok();
        }


    }
}
