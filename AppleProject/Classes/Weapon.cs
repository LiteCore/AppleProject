using AppleProject.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Weapon : Item
    {
        public int Accuracy { get; set; }
        public WeaponType FireMode { get; set; }
        public List<WeaponType> AllFireMode { get; set; }
        public float BulletSpeedMod { get; set; }
        public Ammo Chamber { get; set; }
        public Magazine Magazine { get; set; }
        public string Caliber { get; set; }

        public Weapon()
        {

        }

        public Ammo RechargeChamber()
        {
            var oldAmmo = Chamber;
            Chamber = Magazine.RemoveAmmo();
            return oldAmmo;
        }

    }
}
