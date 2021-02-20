using AppleProject.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Entity
    {
        protected Random random;
        public string Name { get; set; }
        public string Description { get; set; }
        public Body Body { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public Helmet Helmet { get; set; }
        public Rarity Rarity { get; set; }
        public FileInfo Texture { get; set; }

        public void GetDamage(Damage damage, Limb limb = null)
        {
            if (random.DropChance(0.2f))
                return;//Miss
            if(Armor != null)
            {
                if(limb == null)
                {
                    limb = Body.Limbs[random.Next(0, Body.Limbs.Count)];
                }
                bool penetrated = Armor.GetDamage(damage, random);
                if (penetrated)
                {

                }
            }
        }
    }
}
