using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using trpo6.Windows;

namespace trpo6
{
   public class Cow
    {
        public string Name { get; set; }
        public string Voise { get; set; }
        public string Image { get; set; }
        public int Age { get; set; }

        public string FullAgeString
        {
            get
            {
                return $"{DateTime.Now.ToShortDateString()} {Name} {Age} years";
            }
        }
    }
}
