using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class FirstAidKit : Item, IUsable
    {
        public int HealPerUse { get; set; }
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
    }
}
