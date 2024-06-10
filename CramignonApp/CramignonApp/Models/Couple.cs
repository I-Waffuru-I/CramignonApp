using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CramignonApp.Models
{
    public class Couple
    {
        public int CoupleID { get; set; }

        public Person Member1 { get; set; } = null!;
        public Person Member2 { get; set; } = null!;

        public int Year { get; set; }
    }
}
