using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightSim
{
    class Fighter
    {
        private int hp = 100;

        public string name;

        static Random Generator = new Random();

        public int Attack()
        {
            return Generator.Next(21);
        }

        public void Hurt(int amount)
        {
            hp -= amount;
        }

        public bool IsAlive()
        {
            return hp > 0;
        }
        
        public int GetHp()
        {
            return hp;
        }
    }
}
