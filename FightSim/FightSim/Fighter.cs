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
        protected static RestClient client = new RestClient("https://digimon-api.herokuapp.com/api/digimon");

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
