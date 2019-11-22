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
        static RestClient client = new RestClient("https://digimon-api.herokuapp.com/api/digimon/name/");

        static Random Generator = new Random();

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
