using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BenOrigas.com.Models
{
    public class ExperienceBullet
    {
        public ExperienceBullet()
        {
            SubBullets = new List<string>();
        }

        public string Bullet { get; set; }
        public List<string> SubBullets { get; set; }
    }
}