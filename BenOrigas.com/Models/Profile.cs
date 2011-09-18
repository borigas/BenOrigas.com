using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenOrigas.com.Models
{
    public class Profile
    {
        public Profile()
        {
            ExperienceCategories = new List<ExperienceCategory>();
        }

        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public List<ExperienceCategory> ExperienceCategories { get; set; }
    }
}