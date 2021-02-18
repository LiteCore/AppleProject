using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppleProject.Classes
{
    class Body
    {
        public List<Limb> Limbs { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public bool Dizziness { get; set; }
        public bool Tremor { get; set; }
        public int Temperature { get; set; }

        public Body()
        {
            Limbs.AddRange(
                new Limb[] {
                    new("Head", 35, true),
                    new("Chest", 80, true),
                    new("Stomach", 65),
                    new("Left hand", 35, false, true),
                    new("Right hand", 35, false, true),
                    new("Left leg", 45, false, true),
                    new("Right leg", 45, false, true)});

        }
    }

    class Limb
    {
        public Body Body { get; set; }
        public string Name { get; set; }
        public bool Important { get; set; }
        public bool Bleed { get; set; }
        public int BleedRate { get; set; }
        public bool BrokenBone { get; set; }
        public bool Infection { get; set; }
        public bool Tourniquet { get; set; }
        public bool Necrosis { get; set; }
        public bool OutsideLimb { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public Limb(string name, int maxHealth, bool important = false, bool outsideLimb = false)
        {
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Important = important;
            OutsideLimb = outsideLimb;
        }
    }
}
