using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokebattle    
{
    class Program
    {
        string[] Bulbasaur = new string[4] { "Leech seed", "Tackle", "Sleep Powder", "Razor Leaf" };
        string[] Charmander = new string[4] { "Ember", "Scratch", "Swords Dance", "Flamethrower" };
        string[] Squirtle = new string[4] { "Water Gun", "Bubble", "Tackle", "Bite" };
        string[] Pikachu = new string[4] { "Thunderbolt", "Quick Attack", "Thunder Wave", "Thunder" };

        static string userpoke;
        static int userpokenum;
        static int rivalpoke;

        static Random rnd = new Random();
        static string rivalpoke2;

        static Pokemon userpoke2;
        static Pokemon[] PokemonArray = new Pokemon[4];

        static Move[] MoveArray = new Move[16];
        static Move movenum;

        static void composeMove()
        {
            MoveArray[0] = new Move();
            MoveArray[0].movename = "Leech Seed";
            MoveArray[0].type = "Grass";
            MoveArray[0].power = PokemonArray[userpokenum].hp * 15 / 16;
            MoveArray[0].accuracy = 90;
            MoveArray[0].pp = 10;
            MoveArray[0].debuff = "Leech Seed";
            MoveArray[0].turns = 16;


            MoveArray[1] = new Move();
            MoveArray[1].movename = "Tackle";
            MoveArray[1].type = "Normal";
            MoveArray[1].power = 50;
            MoveArray[1].accuracy = 100;
            MoveArray[1].pp = 35;
            MoveArray[1].turns = 1;
            // MoveArray[1].damage = damage(MoveArray[movenum]);

            MoveArray[2] = new Move();
            MoveArray[2].movename = "Sleep Powder";
            MoveArray[2].type = "Grass";
            MoveArray[2].debuff = "Sleep";
            MoveArray[2].accuracy = 100;
            MoveArray[2].pp = 35;

            //MoveArray[2].turns = 
        }

        struct Pokemon
        {
            public string pokename;
            public string type;
            public int hp;
            public int attack;
            public int defence;
            public int speed;
            public Move[] move;
        }
        struct Move
        {
            public string movename;
            public string type;
            public int accuracy;
            public int power;
            public int pp;
            public string debuff;
            public int turns;
            public int damage;
        }




        static void composePoke()
        {
            PokemonArray[0] = new Pokemon();
            PokemonArray[0].pokename = "Bulbasaur";
            PokemonArray[0].type = "Grass";
            PokemonArray[0].hp = 45;
            PokemonArray[0].attack = 49;
            PokemonArray[0].defence = 49;
            PokemonArray[0].speed = 45;
            PokemonArray[0].move = new Move[] { MoveArray[0], MoveArray[1], MoveArray[2], MoveArray[3] };


            PokemonArray[1] = new Pokemon();
            PokemonArray[1].pokename = "Charmander";
            PokemonArray[1].type = "Fire";
            PokemonArray[1].hp = 39;
            PokemonArray[1].attack = 52;
            PokemonArray[1].defence = 43;
            PokemonArray[1].speed = 65;

            PokemonArray[2] = new Pokemon();
            PokemonArray[2].pokename = "Squirtle";
            PokemonArray[2].type = "Water";
            PokemonArray[2].hp = 44;
            PokemonArray[2].attack = 48;
            PokemonArray[2].defence = 65;
            PokemonArray[2].speed = 43;

            PokemonArray[3] = new Pokemon();
            PokemonArray[3].pokename = "Pikachu";
            PokemonArray[3].type = "Electric";
            PokemonArray[3].hp = 35;
            PokemonArray[3].attack = 55;
            PokemonArray[3].defence = 40;
            PokemonArray[3].speed = 90;

        }





        static int damage(int attack, int defence, int power)
        {
            return ((2 * 15 + 10) / 250 * attack / defence * power);
        }




        static void Main(string[] args)
        {
            composePoke();
            composeMove();
            bool correctpoke = false;
            while (correctpoke == false)
            {
                Console.Clear();
                Console.WriteLine("Choose a Pokemon: Bulbasaur, Charmander, Squirtle or Pikachu");
                userpoke = Console.ReadLine();

                switch (userpoke)
                {
                    case "Bulbasaur":
                        userpoke2 = PokemonArray[0];
                        userpokenum = 0;
                        Console.WriteLine("I choose you " + userpoke2.pokename + "!");
                        correctpoke = true;
                        break;

                    case "Charmander":
                        userpoke2 = PokemonArray[1];
                        userpokenum = 1;
                        Console.WriteLine("I choose you " + userpoke2.pokename + "!");
                        correctpoke = true;
                        break;

                    case "Squirtle":
                        userpoke2 = PokemonArray[2];
                        userpokenum = 2;
                        Console.WriteLine("I choose you " + userpoke2.pokename + "!");
                        correctpoke = true;
                        break;

                    case "Pikachu":
                        userpoke2 = PokemonArray[3];
                        userpokenum = 3;
                        Console.WriteLine("I choose you " + userpoke2.pokename + "!");
                        correctpoke = true;
                        break;
                }
            }
            Console.ReadKey();


            rivalpoke = rnd.Next(0, 4);
            switch (rivalpoke)
            {
                case 0:
                    rivalpoke2 = "Bulbasaur";
                    break;
                case 1:
                    rivalpoke2 = "Charmander";
                    break;
                case 2:
                    rivalpoke2 = "Squirtle";
                    break;
                case 3:
                    rivalpoke2 = "Pikachu";
                    break;

            }

            Console.WriteLine("Rival choses " + rivalpoke2);
            Console.ReadKey();

            Console.WriteLine("Select a move " + PokemonArray[userpokenum].move[0].movename);
            Console.ReadKey();
        }
    }
}
