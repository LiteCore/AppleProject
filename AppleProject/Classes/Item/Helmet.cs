using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Helmet : Item, IBreakable
    {
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public int ProtectionClass { get; set; }
        public Material Material { get; set; }

        public void GetDamage(Damage damage)
        {
            var armorDamage = Math.Round(damage.Penetration * damage.ArmorDamageValue * Material.DestructionModifier / ProtectionClass, 0, MidpointRounding.AwayFromZero);
            Durability -= Math.Min(Durability, Convert.ToInt32(armorDamage));
        }
    }
}
