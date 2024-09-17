using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGCombatKata
{
    public class Character

    {
        public string Name { get; private set; }
        public int Health { get; private set; }
        public int Level { get; private set; }

        public bool IsAlive { get; private set; }

        public Character(string name)
        {
            Name = name;
            Health = 1000;
            Level = 1;
            IsAlive = true;
        }

        public void TakeDamage(int DamageDealt, Character Source)
        {

            if (Name == Source.Name)
            {
                return;
            }

            if( Level - Source.Level >= 5)
            {
                DamageDealt /= 2;
            }

            else if (Source.Level - Level  >= 5)
            {
                DamageDealt = (int)(DamageDealt * 1.5);
            }

            Health -= DamageDealt;

            if (Health < 0)
            {
                Health = 0;
                IsAlive = false;
            }
        }
        public void Heal(int HealAmount, Character Source)


        {
            if (Name != Source.Name)
            {
                return;
            }


            if (!IsAlive)

                return;

            Health += HealAmount;

            if (Health > 1000)
            {
                Health = 1000;
            }
        }

        public void AddLevel(int AddLevel)
        {
            Level += AddLevel;
        }
    }
                                                                                               
}
