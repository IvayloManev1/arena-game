using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Monk : Hero
    {
        private double probability;
        public double Probability { get { return probability; } }
        public Monk(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
            probability = random.NextDouble();
        }

        public override double Attack()
        {
            double damage = base.Attack();
            
            if (probability < 0.30)
            {
                //StunStatus += 2;
                return damage;
            }

            else return damage;

        }

        public override double Defend(double damage)
        {
            double probability = random.NextDouble();
            if (probability < 0.30)
            {
                return 0;
            }

            else return base.Defend(damage);
        }
    }
}
