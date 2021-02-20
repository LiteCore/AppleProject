using AppleProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Armor : Item, IBreakable
    {
        public int Durability { get; set; }
        public int MaxDurability { get; set; }
        public int ProtectionClass { get; set; }
        public Material Material { get; set; }
        public List<ProtectionZoneType> ProtectionZones { get; set; }

        public bool GetDamage(Damage damage, Random random)
        {
            var armorDamage = Math.Round(damage.Penetration * damage.ArmorDamageValue * Material.DestructionModifier / ProtectionClass, 0, MidpointRounding.AwayFromZero);
            Durability -= Math.Min(Durability, Convert.ToInt32(armorDamage));
            if (damage.Penetration > ProtectionClass * 10)
                if (damage.Penetration - 10 > ProtectionClass * 10)
                    return true;
                else if (random.DropChance((ProtectionClass * 10 - damage.Penetration) / 10f))
                    return true;
                else
                    return false;
            else
                return false;
        }

    }
}
