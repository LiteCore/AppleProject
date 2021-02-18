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
        private Weapon DefaultWeapon = new() { Name = "Fists", Description = "Your fists.", Rarity = Enums.Rarity.Unique, Damage = 1, Weight = 0 };
        private Armor DefaultArmor = new() { Name = "No armor", Description = "Naked body.", Protection = 0 };
        public Player()
        {
            Name = "Player";
            Description = "This is you.";
            Health = 20;
            Protection = 0;
            Damage = 0;
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
            if (Weapon != DefaultWeapon)
                Inventory.Add(this.Weapon);
            Weapon = weapon;
            Damage = weapon.Damage;
        }
        public void UnequipWeapon()
        {
            EquipWeapon(DefaultWeapon);
        }
        public void EquipArmor(Armor armor)
        {
            Inventory.Remove(armor);
            if (Armor != DefaultArmor)
                Inventory.Add(this.Armor);
            Armor = armor;
            Protection = armor.Protection;
        }
        public void UnequipArmor()
        {
            EquipArmor(DefaultArmor);
        }
    }
}
