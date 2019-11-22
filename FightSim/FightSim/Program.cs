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
            //Man väjler två digimons som finns i listan
            Fighter f1 = ChooseFighter("Which Digimon do you want to choose?\nUse numbers");
            Fighter f2 = ChooseFighter("Which Digimon do enemy want to choose?\n Use numbers");

            f1.GetHp();
            f2.GetHp();

            int dmgA;
            int dmgB;

            Console.Clear();
            // De slåss tills ena dör eller båda
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

        //en metod till att kunna välja vilken digimon och den körs två gånger.
        static Fighter ChooseFighter (string message)
        {
            Console.WriteLine(message);
            Console.WriteLine("1.Tentomon\n2.Raremon\n3.Devidramon\n4.MegaSeadramon");

            while (true)
            {
                string answer = Console.ReadLine();

                if (answer == "1")
                {
                    Console.WriteLine("You chose Tentomon");
                    Console.ReadKey();
                    return new Tentomon();
                }
                else if (answer == "2")
                {
                    Console.WriteLine("You chose Raremon");
                    Console.ReadKey();
                    return new Raremon();
                }
                else if (answer == "3")
                {
                    Console.WriteLine("You chose Devidramon");
                    Console.ReadKey();
                    return new Devidramon();
                }
                else if (answer == "4")
                {
                    Console.WriteLine("You chose MegaSeadramon");
                    Console.ReadKey();
                    return new MegaSeadramon();
                }
                else
                {
                    Console.WriteLine("Skriv en av dem siffrorna");
                }
            }
        } 
    }
}
