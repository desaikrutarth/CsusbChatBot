using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ChatBot.Models;

namespace ChatBot.ViewModel
{
    public class ProfessorCourseViewModel
    {
        public Courses Courses { get; set; }
        public List<Professors> Professors { get; set; }
    }
}