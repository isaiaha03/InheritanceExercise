using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Bird : Animal
    {
        public string Color { get; set; }
        public bool CanFly { get; set; }
        public bool HasBeak { get; set; }
        public string MigrationPattern { get; set; }
    }
}
