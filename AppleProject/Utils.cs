using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject
{
    static class Utils
    {
        public static bool DropChance(this Random random, float chance)
        {
            return chance > random.NextDouble();
        }
    }
}
