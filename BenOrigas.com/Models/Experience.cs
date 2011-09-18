using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenOrigas.com.Models
{
    public class Experience
    {
        public Experience()
        {
            Details = new List<Company>();
            Bullets = new List<ExperienceBullet>();
        }

        public string Title { get; set; }
        public string DateRange { get; set; }
        public List<Company> Details { get; set; }
        public List<ExperienceBullet> Bullets { get; set; }
    }
}