using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Magazine : Item
    {
        public int MaxAmmo { get; set; }
        public string Caliber { get; set; }
        public Queue<Ammo> BulletsQueue { get; set; }
        public Magazine(int maxAmmo)
        {
            BulletsQueue = new Queue<Ammo>(maxAmmo);
            MaxAmmo = maxAmmo;
        }
        public void AddAmmo(Ammo ammo)
        {
            if (!ammo.Caliber.Equals(Caliber) || BulletsQueue.Count == MaxAmmo)
                return;
            BulletsQueue.Enqueue(ammo);
        }
        public Ammo RemoveAmmo()
        {
            return BulletsQueue.Dequeue();
        }
    }
}