using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FightSim
{
    class Devidramon : Fighter
    {
        int hp = 150;

        static RestRequest request = new RestRequest("Devidramon");

        static IRestResponse response = client.Get(request);

        Fighter devidramon = JsonConvert.DeserializeObject<Fighter[]>(response.Content)[0];

        void Method()
        {
            Console.WriteLine(devidramon.name);

            Console.ReadLine();
        }

        //Console.WriteLine(response.Content);


    }
}
