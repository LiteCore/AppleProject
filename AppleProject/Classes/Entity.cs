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
        public string Name { get; set; }
        public string Description { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Protection { get; set; }
        public Weapon Weapon { get; set; }
        public Armor Armor { get; set; }
        public Rarity Rarity { get; set; }
        public FileInfo Texture { get; set; }

    }
}
