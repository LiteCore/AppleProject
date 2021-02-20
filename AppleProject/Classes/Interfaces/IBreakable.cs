using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    interface IBreakable
    {
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
    }
}
