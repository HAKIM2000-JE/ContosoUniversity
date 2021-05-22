using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity1.Models
{
    public class Stage
    {

        public int StageID { get; set; }
        public string titre { get; set; }
        public string description { get; set; }
        public DateTime debut { get; set; }
        public DateTime fin { get; set; }
        public string etat { get; set; }
    }
}
