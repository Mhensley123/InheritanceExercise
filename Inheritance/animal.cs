using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Animal
    {
            public Animal()
        {
            IsAMammal = true;
            Lifespan = 10;
            AverageWeight = 10;
            CanBeAPet = "yes";
          

        }

        public bool IsAMammal { get; set; }
        public int Lifespan { get; set;}
        public int AverageWeight { get; set; }
        public string CanBeAPet { get; set; }
    }
}
