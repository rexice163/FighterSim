using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FightSim
{
    class MegaSeadramon : Fighter
    {
        static Random Generator = new Random();

        int hp = 175;

        static RestRequest request = new RestRequest("MegaSeadramon");

        static IRestResponse response = client.Get(request);

        Fighter megaseadramon = JsonConvert.DeserializeObject<Fighter[]>(response.Content)[0];

        void Method()
        {
            Console.WriteLine(megaseadramon.name);

            Console.ReadLine();
        }
        public override int Attack()
        {
            return Generator.Next(26);
        }
    }
}
