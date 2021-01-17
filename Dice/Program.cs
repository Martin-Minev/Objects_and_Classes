using System;

namespace Dice
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice dice6 = new Dice(6);
            // dice6.Sides = 6;
            Dice diceDnD = new Dice(20);
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine(diceDnD.Roll());
            }
        }
    }
    class Dice
    {
        public Dice()
        {

        }
        public Dice(int sides)
        {
            Sides = sides;
        }

        public int Sides { get; set; }
        public string Type { get; set; }

        public int Roll()
        {
            Random rnd = new Random();
            return rnd.Next(1, Sides + 1);
        }
    }
}
