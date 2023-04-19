using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class bird : animal
    {
        public bird()
        {

        }

        public string StateBird { get; set; }
        public bool CanSing { get; set; }
        public bool EatsWorms { get; set; }
        public double Wingspan { get; set; }


    }
}
