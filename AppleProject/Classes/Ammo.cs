using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Ammo : Item
    {
        public int Damage { get; set; }
        public int Penetration { get; set; }
        public float BleedRate { get; set; }
        public int Speed { get; set; }
        public bool Tracer { get; set; }
        public string Caliber { get; set; }
    }
}
