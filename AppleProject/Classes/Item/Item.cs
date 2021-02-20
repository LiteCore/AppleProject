using AppleProject.Enums;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Item
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; protected set; }
        public float Weight { get; set; }
        public Rarity Rarity { get; set; }
        public FileInfo Texture { get; set; }

    }
}
