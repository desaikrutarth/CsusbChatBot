using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatBot.Models
{
    public class Courses
    {
        public int id { get; set; }

        [Display(Name = "Course Id")]
        public string number { get; set; }

        [Display(Name = "Course Name")]
        public string name { get; set; }

        [Display(Name = "Time")]
        public string time { get; set; }

        [Display(Name = "Room No.")]
        public string location { get; set; }

        [Display(Name = "No. of Units")]
        public int noOfUnits { get; set; }

        public Professors professors { get; set; }

        [Display(Name = "Professor")]
        public int professorsId { get; set; }
    }
}