using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FightSim
{
    class Tentomon : Fighter
    {
        static Random Generator = new Random();

        int hp = 125;

        static RestRequest request = new RestRequest("Tentomon");

        static IRestResponse response = client.Get(request);

        Fighter tentomon = JsonConvert.DeserializeObject<Fighter[]>(response.Content)[0];

        void Method()
        {
            Console.WriteLine(tentomon.name);

            Console.ReadLine();
        }
        public override int Attack()
        {
            return Generator.Next(16);
        }
    }
}
