using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class Program
    {
        static void Main(string[] args)
        {
            int blackcount = 0;
            int redcount = 0;
            int colorpick;

            int winningSpot;

            Random rand = new Random();
            Wheel[] wheel = new Wheel[38];

            //Declare what's in the wheel
            wheel[0] = new Wheel(0, "Green");
            wheel[37] = new Wheel(38, "Green");

            for (int i = 1; i < wheel.Length - 1; i++)
            {
                colorpick = rand.Next();
                if (colorpick % 2 == 0 && blackcount >= 18)
                {
                    wheel[i] = new Wheel(i, "Red");
                    redcount++;
                }
                else if (colorpick % 2 == 1 && redcount >= 18)
                {
                    wheel[i] = new Wheel(i, "Black");
                    blackcount++;
                }
                else if (colorpick % 2 == 0)
                {
                    wheel[i] = new Wheel(i, "Black");
                    blackcount++;
                }
                else if (colorpick % 2 == 1)
                {
                    wheel[i] = new Wheel(i, "Red");
                    redcount++;
                }
                System.Threading.Thread.Sleep(71);
            }

            for (int j = 0; j < wheel.Length; j++)
            {
                if (wheel[j].number != 38)
                    Console.Write($"Space {wheel[j].number} is color {wheel[j].color}\t");
                else
                    Console.Write($"Space 00 is color {wheel[j].color}\t");
            }
            Console.WriteLine("\n");

            winningSpot = rand.Next(0, 37);

            int[] streets = new int[3];
            streets = WinningBets.Street(winningSpot);

            int[] doubleRows = new int[6];
            doubleRows = WinningBets.DoubleRows(winningSpot);

            int[] splits = new int[4];
            splits = WinningBets.Split(winningSpot);

            if (winningSpot != 37)
            {
                Console.WriteLine($"The ball landed on the {wheel[winningSpot].color} {wheel[winningSpot].number}!\n");

                Console.WriteLine("You could have won had you bet on one of the following...");
                Console.WriteLine($"Winning number:         {winningSpot}");
                Console.WriteLine($"Even/Odds:              {WinningBets.EvenOdds(winningSpot)}");
                Console.WriteLine($"Reds/Black:             {WinningBets.RedBlack(wheel[winningSpot].color)}");
                Console.WriteLine($"Lows/Highs:             {WinningBets.LowHigh(winningSpot)}");
                Console.WriteLine($"Dozens (row thirds):    {WinningBets.Thirds(winningSpot)}");
                Console.WriteLine($"Columns:                {WinningBets.Columns(winningSpot)}");

                Console.Write($"Streets:                ");
                for (int i = 0; i < streets.Length; i++)
                {
                    Console.Write($"{streets[i]}\t");
                }

                Console.Write($"\nDouble Rows:            ");
                for (int i = 0; i < doubleRows.Length; i++)
                {
                    Console.Write($"{doubleRows[i]}\t");
                }

                Console.Write($"\nSplit:                  ");
                for (int i = 0; i < splits.Length; i++)
                {
                    Console.Write($"{splits[i]} / {winningSpot}\tor\t");
                }
            }
            else
            {
                string doubZero = "00";

                Console.WriteLine($"The ball landed on the {wheel[winningSpot].color} {doubZero}!\n");

                Console.WriteLine("You could have won had you bet on one of the following...");
                Console.WriteLine($"Winning number:         {doubZero}");
                Console.WriteLine($"Even/Odds:              {WinningBets.EvenOdds(winningSpot)}");
                Console.WriteLine($"Reds/Black:             {WinningBets.RedBlack(wheel[winningSpot].color)}");
                Console.WriteLine($"Lows/Highs:             {WinningBets.LowHigh(winningSpot)}");
                Console.WriteLine($"Dozens (row thirds):    {WinningBets.Thirds(winningSpot)}");
                Console.WriteLine($"Columns:                {WinningBets.Columns(winningSpot)}");

                Console.Write($"Streets:                ");
                for (int i = 0; i < streets.Length; i++)
                {
                    Console.Write($"{streets[i]}\t");
                }

                Console.Write($"\nDouble Rows:            ");
                for (int i = 0; i < doubleRows.Length; i++)
                {
                    Console.Write($"{doubleRows[i]}\t");
                }

                Console.Write($"\nSplit:                  ");
                for (int i = 0; i < splits.Length; i++)
                {
                    Console.Write($"{splits[i]} / {doubZero}\tor\t");
                }
            }
        }

        public struct Wheel
        {
            public int number;
            public string color;

            public Wheel(int num, string color)
            {
                this.number = num;
                this.color = color;
            }
        }

    }

}
