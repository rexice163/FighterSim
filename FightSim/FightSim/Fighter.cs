using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FightSim
{
    class Fighter
    {
        //Några basic variabel som behövs, t.ex namn, om de lever eller inte och liv och skada som de tar.
        public string name;

        private int hp = 100;

        //En virtual attack, så man kan overrida det från subklasserna, för att de har olika damage
        public virtual int Attack() {
            return 0;
        }

        public void Hurt(int amount)
        {
            hp -= amount;
        }

        public bool IsAlive()
        {
            return hp > 0;
        }
        //används till att se hur mycket hp de har.
        public int GetHp()
        {
            return hp;
        }
    }
}
