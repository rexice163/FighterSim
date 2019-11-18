﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FightSim
{
    class Raremon : Fighter
    {
        int hp = 150;

        static RestRequest request = new RestRequest("Rareamon");

        static IRestResponse response = client.Get(request);

        Fighter raremon = JsonConvert.DeserializeObject<Fighter[]>(response.Content)[0];

        void Method()
        {
            Console.WriteLine(raremon.name);

            Console.ReadLine();
        }
    }
}
