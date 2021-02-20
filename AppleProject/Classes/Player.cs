using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Player : Entity
    {
        public List<Item> Inventory { get; set; }
        //private Weapon DefaultWeapon = new() { Name = "Fists", Description = "Your fists.", Rarity = Enums.Rarity.Unique, Weight = 0 };
        //private Armor DefaultArmor = new() { Name = "No armor", Description = "", Protection = 0 };
        public Player()
        {
            Name = "Player";
            Description = "This is you.";
            Body = new Body();
            random = new Random();
        }

        public void Shoot(Enemy enemy, int distantion, Limb limb = null)
        {
            if (Weapon == null)
                return;
            if (Weapon.Chamber == null)
                return;
            
        }

        public void TakeItem(Item item)
        {
            Inventory.Add(item);
        }
        public void DropItem(Item item)
        {
            Inventory.Remove(item);
        }
        public void EquipWeapon(Weapon weapon)
        {
            Inventory.Remove(weapon);
            //if (Weapon != DefaultWeapon)
            if(this.Weapon != null)
                Inventory.Add(this.Weapon);
            Weapon = weapon;
            //Damage = weapon.Damage;
        }
        public void UnequipWeapon()
        {
            EquipWeapon(null);
        }
        public void EquipArmor(Armor armor)
        {
            Inventory.Remove(armor);
            if (Armor != null)
                Inventory.Add(this.Armor);
            Armor = armor;
        }
        public void UnequipArmor()
        {
            EquipArmor(null);
        }
    }
}
