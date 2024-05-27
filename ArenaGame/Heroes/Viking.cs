using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArenaGame.Heroes
{
    public class Viking : Hero
    {
        public int Berserk { get; private set; } = 0;
        public Viking(string name, double armor, double strenght, IWeapon weapon) : base(name, armor, strenght, weapon)
        {
        }

        public override double Attack()
        {
            double damage = base.Attack();
            if (Berserk == 0)
            {

                double probability = random.NextDouble();
                if (probability < 0.30)
                {
                    Berserk += 2;
                }
                return damage;

            }

            else
            {
                Berserk--;
                return damage * 3;
            }
        }

        public override double Defend(double damage)
        {
            if (Berserk == 0)
            {
                return base.Defend(damage);
            }

            else
            {
                Berserk--;
                return base.Defend(damage) * 2;
            }

        }
    }
}
