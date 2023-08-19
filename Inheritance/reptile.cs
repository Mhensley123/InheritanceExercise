using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Reptile : Animal
    {
        public Reptile()
        {
            IsAMammal = false;
            Lifespan = 10;
            AverageWeight = 20;
            CanBeAPet = "yes";
        }
        public bool IsCute { get; set; }
        public bool IsPoisonous { get; set; }
        public string Habitat { get; set; }
        public bool IsSlimy { get; set; }
    }
}
