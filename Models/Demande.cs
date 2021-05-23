using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity1.Models
{
    public class Demande
    {

        public int  DemandeID {get ; set; }
        public int ID_stage { get; set; }
        public int ID_student { get; set; }
        public string  etat { get; set; }
    }
}
