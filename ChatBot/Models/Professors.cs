using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ChatBot.Models
{
    public class Professors
    {
        public int id { get; set; }

        [Display(Name ="First Name")]
        public string fname { get; set; }

        [Display(Name = "Last Name")]
        public string lname { get; set; }

        [Display(Name = "Email Id")]
        public string email { get; set; }

        [Display(Name = "Phone No")]
        public string phone { get; set; }

        [Display(Name = "Office Hours")]
        public string officeHours { get; set; }

        [Display(Name = "Office Location")]
        public string location { get; set; }

    }
}