using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegionCRUD.Models
{
    public class VolunteerList
    {
        public int VolunteerId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Age { get; set; }
        public int Birthdate { get; set; }
        public int sex_id { get; set; }
        public int region_code { get; set; }
    }
}
