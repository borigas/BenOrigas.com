using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenOrigas.com.Models
{
    public class ExperienceCategory
    {
        public ExperienceCategory()
        {
            Experiences = new List<Experience>();
        }

        public string CategoryName { get; set; }
        public List<Experience> Experiences { get; set; }
    }
}