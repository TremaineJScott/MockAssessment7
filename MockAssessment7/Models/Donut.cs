using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MockAssessment7.Models
{
    public class Donut
    {
        public int id { get; set; }
        public string name { get; set; }
        public int calories { get; set; }
        public string photo { get; set; }
        public List<string> extras { get; set; }
    }
}
