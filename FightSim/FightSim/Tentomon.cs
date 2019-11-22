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
        //Api
        static RestClient client = new RestClient("https://digimon-api.herokuapp.com/api/digimon/name");
        //Random generator till hur mycket damage den ska göra
        static Random Generator = new Random();
        
        static RestRequest request = new RestRequest("Tentomon");

        static IRestResponse response = client.Get(request);
        //den vljer den första saken från arrayen som api ger
        Fighter tentomon = JsonConvert.DeserializeObject<Fighter[]>(response.Content)[0];
        //Ska göra så att dens namn ska synas när man startae, men denna är en failure och ingen namn kommer upp
        void Method()
        {
            Console.WriteLine(tentomon.name);

            Console.ReadLine();
        }
        //overridar attack i main classen
        public override int Attack()
        {
            return Generator.Next(16);
        }
    }
}
