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
        public int Blood { get; set; }
        public bool Dizziness { get; set; }
        public bool Tremor { get; set; }
        public float Temperature { get; set; }
        private Random random;

        public Body()
        {
            random = new Random();
            Limbs = new(
                new Limb[] {
                    new(this, "Head", 35, true),
                    new(this, "Chest", 80, true),
                    new(this, "Stomach", 65),
                    new(this, "Left hand", 35, false, true),
                    new(this, "Right hand", 35, false, true),
                    new(this, "Left leg", 45, false, true),
                    new(this, "Right leg", 45, false, true)});
            Temperature = 36.6f;
            MaxHealth = GetMaxHealth();
            Health = GetHealth();
            Blood = 12000;
        }

        public void Update(object sender, UpdateEventArgs args)
        {
            int bloodLoss = 0;
            foreach (var limb in Limbs)
            {
                bloodLoss += limb.Bleed ? limb.BleedRate : 0;
                limb.SetNecrosis();
            }
            Blood -= bloodLoss;
            if (Blood < 5000)
                Death();
            //if (Blood < 10000)
            //    Dizziness = true;
            //if (Blood < 8000)
            //    Tremor = true;
        }

        public void Death()
        {
            //Death
        }

        public void TakeDamage(Limb limb, Damage damage)
        {
            limb.Health -= Math.Min(damage.DamageValue, limb.Health);
            if (random.DropChance(damage.BleedRate))
                ApplyBleed(limb);
            if (limb.Health == 0 && limb.Important)
                Death();
        }

        public void ApplyBleed(Limb limb)
        {
            limb.Bleed = true;
            bool heavyBleed = random.DropChance(0.2f);
            if (heavyBleed)
                limb.BleedRate += random.Next(60, 120);
            else
                limb.BleedRate += random.Next(20, 40);
        }

        public void HealLimb(Limb limb, FirstAidKit medicine)
        {
            int healRate = Math.Min(medicine.Durability, (limb.MaxHealth - limb.Health));
            limb.Health += healRate;
            medicine.Durability -= healRate;
        }

        public bool ApplyTourniquet(Limb limb)
        {
            if (limb.Bleed)
            {
                limb.Tourniquet = true;
                limb.Bleed = false;
                return true;
            }
            return false;
        }
        public void RemoveTourniquet(Limb limb)
        {
            limb.Tourniquet = false;
            limb.Bleed = true;
        }

        public void UpdateHealth()
        {
            Health = GetHealth();
        }

        private int GetHealth()
        {
            var hp = 0;
            foreach (var limb in Limbs)
            {
                hp += limb.Health;
            }
            return hp;
        }

        private int GetMaxHealth()
        {
            var mhp = 0;
            foreach (var limb in Limbs)
            {
                mhp += limb.MaxHealth;
            }
            return mhp;
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
        public float Necrosis { get; set; }
        public bool OutsideLimb { get; set; }
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public Limb(Body body, string name, int maxHealth, bool important = false, bool outsideLimb = false)
        {
            Body = body;
            Name = name;
            MaxHealth = maxHealth;
            Health = maxHealth;
            Important = important;
            OutsideLimb = outsideLimb;
        }
        public void SetNecrosis()
        {
            if (Infection)
                Necrosis += 0.08f;
            if (Tourniquet)
                Necrosis += 0.05f;
            if (Body.Temperature < 33f)
                Necrosis += 0.1f;

            if (!Infection && !Tourniquet && Body.Temperature >= 35f)
                Necrosis -= 0.04f;

            if (Necrosis > 1f)
                Health = 0;
            if (Necrosis < 0f)
                Necrosis = 0;
        }
    }
}
