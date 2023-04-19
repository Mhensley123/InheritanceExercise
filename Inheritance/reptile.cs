using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class reptile : animal
    {
        public reptile()
        {

        }
        public bool IsScary { get; set; }
        public bool IsPoisonous { get; set; }
        public string Habitat { get; set; }
        public bool IsSlimy { get; set; }
    }
}
