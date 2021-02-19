using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    interface IUsable
    {
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
    }
}
