using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Reptile : Animal
    {
        public bool IsColdBlooded { get; set; }
        public string ScaleType { get; set; }
        public bool CanRegenerate { get; set; }
        public bool HasTail { get; set; }
    }
}
