using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using RestSharp;

namespace FightSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Fighter f1 = ChooseFighter("Which Digimon do you want to choose?");
            Fighter f2 = ChooseFighter("Which Digimon do enemy want to choose?");

            f1.GetHp();
            f2.GetHp();

            int dmgA;
            int dmgB;

            while(f1.IsAlive() && f2.IsAlive())
            {
                dmgA = f1.Attack();
                dmgB = f2.Attack();

                Console.WriteLine(f1.name + " just dealt " + dmgA + " damage");
                Console.WriteLine(f2.name + " just dealt " + dmgB + " damage");

                f2.Hurt(dmgA);
                f1.Hurt(dmgB);

                Console.WriteLine(f1.name + " has " + f1.GetHp() + "HP left");
                Console.WriteLine(f2.name + " has " + f2.GetHp() + "HP left");

                Console.ReadLine();

                Console.Clear();
            }
            if (f1.GetHp() < 0 && f2.GetHp() >= 0)
            {
                Console.WriteLine("Winner is " + f2.name);
            }
            else if (f1.GetHp() >= 0 && f2.GetHp() < 0)
            {
                Console.WriteLine("Winner is " + f1.name);
            }
            else
            {
                Console.WriteLine("It's a tie");
            }
            Console.ReadLine();


        }
        static Fighter ChooseFighter (string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("Tentomon\nRaremon\nDevidramon\nMegaSeadramon");

            while (true)
            {
                string answer = Console.ReadLine();

                if (answer == "Tentomon")
                {
                    return new Tentomon();
                }
                else if (answer == "2")
                {
                    return new Raremon();
                }
                else
                {
                    Console.WriteLine("Skrvi et siffra");
                }
            }
        } 
    }
}
