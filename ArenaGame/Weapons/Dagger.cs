using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Weapons
{
    public class Dagger : IWeapon
    {
        public string Name { get; set; }

        public double AttackDamage { get; private set; }

        public double BlockingPower { get; private set; }

        public Dagger(string name)
        {
            Name = name;
            AttackDamage = 30;
            BlockingPower = 1;
        }

        public string SpecialAbility()
        {
            Random random = new Random();
            double chance = random.NextDouble();
            if (chance < 0.25)
            {
                double criticalDamage = AttackDamage * 2;
                return "doing a successful critical hit";
            }
            return "and failing a critical hit";
        }
    }
}
