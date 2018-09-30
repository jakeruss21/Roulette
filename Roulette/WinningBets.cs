using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roulette
{
    class WinningBets
    {
        //1. Numbers: the number of the bin

        public static int BinNumber (int num) => num;

        //2. Evens/Odds: even or odd numbers

        public static string EvenOdds (int num)
        {
            string evenOdd;

            if(num == 0 || num == 37)
            {
                evenOdd = "Neither even or odd";
            }
            else if(num % 2 == 0)
            {
                evenOdd = "Evens";
            }
            else
            {
                evenOdd = "Odds";
            }
            return evenOdd;
        }

        //3. Reds/Blacks: red or black colored numbers

        public static string RedBlack (string redBlack) => redBlack;

        //4. Lows/Highs: low(1 - 18) or high(19 - 36) numbers.

        public static string LowHigh (int num)
        {
            string lowhigh;

            if(num == 0 || num == 37)
            {
                lowhigh = "You Lose";
            }
            else if(num >= 19)
            {
                lowhigh = "High";
            }
            else
            {
                lowhigh = "Low";
            }

            return lowhigh;
        }

        //5.Dozens: row thirds, 1 - 12, 13 - 24, 25 - 36

        public static string Thirds (int num)
        {
            string third;

            if(num == 0 || num == 37)
            {
                third = "No third wins";
            }
            else if(num >= 1 && num <= 12 )
            {
                third = "First third";
            }
            else if(num >= 12 && num <= 24 )
            {
                third = "Second third";
            }
            else
            {
                third = "Third third";
            }

            return third;
        }

        //6.Columns: rst, second, or third columns

        public static string Columns (int num)
        {
            string column;

            if (num == 0 || num == 37)
            {
                column = "No column wins";
            }
            else if (num % 3 == 1)
            {
                column = "First column";
            }
            else if (num % 3 == 2)
            {
                column = "Second column";
            }
            else
            {
                column = "Third column";
            }

            return column;
        }

        //7.Street: rows, e.g., 1 / 2 / 3 or 22 / 23 / 24

        public static int[] Street(int num)
        {
            int[] st = new int[3];

            switch(num)
            {
                case int n when (n == 0 || n == 37):
                    st[0] = 0;
                    st[1] = 0;
                    st[2] = 0;
                    break;
                case int n when (n >= 1 && n <= 3):
                    st[0] = 1;
                    st[1] = 2;
                    st[2] = 3;
                    break;
                case int n when (n >= 4 && n <= 6):
                    st[0] = 4;
                    st[1] = 5;
                    st[2] = 6;
                    break;
                case int n when (n >= 7 && n <= 9):
                    st[0] = 7;
                    st[1] = 8;
                    st[2] = 9;
                    break;
                case int n when (n >= 10 && n <= 12):
                    st[0] = 10;
                    st[1] = 11;
                    st[2] = 12;
                    break;
                case int n when (n >= 13 && n <= 15):
                    st[0] = 13;
                    st[1] = 14;
                    st[2] = 15;
                    break;
                case int n when (n >= 16 && n <= 18):
                    st[0] = 16;
                    st[1] = 17;
                    st[2] = 18;
                    break;
                case int n when (n >= 19 && n <= 21):
                    st[0] = 19;
                    st[1] = 20;
                    st[2] = 21;
                    break;
                case int n when (n >= 22 && n <= 24):
                    st[0] = 22;
                    st[1] = 23;
                    st[2] = 24;
                    break;
                case int n when (n >= 25 && n <= 27):
                    st[0] = 25;
                    st[1] = 26;
                    st[2] = 27;
                    break;
                case int n when (n >= 28 && n <= 30):
                    st[0] = 28;
                    st[1] = 29;
                    st[2] = 30;
                    break;
                case int n when (n >= 31 && n <= 33):
                    st[0] = 31;
                    st[1] = 32;
                    st[2] = 33;
                    break;
                case int n when (n >= 34 && n <= 36):
                    st[0] = 34;
                    st[1] = 35;
                    st[2] = 36;
                    break;
                default:
                    st[0] = 0;
                    st[1] = 0;
                    st[2] = 0;
                    break;
            }
            
            return st;
        }

        //8. 6 Numbers: double rows, e.g., 1 / 2 / 3 / 4 / 5 / 6 or 22 / 23 / 24 / 25 / 26 / 26

        public static int[] DoubleRows(int num)
        {
            int[] tworows = new int[6];

            switch (num)
            {
                case int n when (n == 0 || n == 37):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = 0;
                    }
                    break;
                case int n when (n >= 1 && n <= 6):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = i + 1;
                    }
                    break;
                case int n when (n >= 7 && n <= 12):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = i + 7;
                    }
                    break;
                case int n when (n >= 13 && n <= 18):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = i + 13;
                    }
                    break;
                case int n when (n >= 19 && n <= 24):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = i + 19;
                    }
                    break;
                case int n when (n >= 25 && n <= 30):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = i + 25;
                    }
                    break;
                case int n when (n >= 31 && n <= 36):
                    for (int i = 0; i < tworows.Length; i++)
                    {
                        tworows[i] = i + 31;
                    }
                    break;
                default:
                    break;
            }

            return tworows;
        }

        //9.Split: at the edge of any two contiguous numbers, e.g., 1 / 2, 11 / 14, and 35 / 36

        public static int[] Split(int num)
        {
            int[] splits = new int[4];

            if (num == 0 || num == 37)
            {
                splits[0] = 0;
                splits[1] = 0;
                splits[2] = 0;
                splits[3] = 0;
            }
            else
            {
                if (num - 3 < 1)
                {
                    splits[0] = num;
                }
                else
                {
                    splits[0] = num - 3;
                }

                if (num - 1 < 1)
                {
                    splits[1] = num;
                }
                else
                {
                    splits[1] = num - 1;
                }

                if (num + 1 > 36)
                {
                    splits[2] = num;
                }
                else
                {
                    splits[2] = num + 1;
                }

                if (num + 3 > 36)
                {
                    splits[3] = num;
                }
                else
                {
                    splits[3] = num + 3;
                }
            }

            return splits;
        }

        //10.Corner: at the intersection of any four contiguous numbers, e.g., 1 / 2 / 4 / 5, or 23 / 24 / 26 / 27

    //    public static Corners[] FourCorners(int num)
    //    {
    //        Corners[] winbet = new Corners[4];
    //        //Corners firstCorner = new Corners(0, 0, 0, 0);


    //        if (num == 0 || num == 37)
    //        {
    //            Corners firstCorner = new Corners(0, 0, 0, 0);
    //            Corners secondCorner = new Corners(0, 0, 0, 0);
    //            Corners thirdCorner = new Corners(0, 0, 0, 0);
    //            Corners fourthCorner = new Corners(0, 0, 0, 0);
    //            winbet[0] = firstCorner;
    //            winbet[1] = secondCorner;
    //            winbet[2] = thirdCorner;
    //            winbet[3] = fourthCorner;
    //        }
    //        else
    //        {




    //        }



    //        return winbet;
    //    }

    //}

    //public struct Corners
    //{
    //    public int one, two, three, four;

    //    public Corners(int a, int b, int c, int d)
    //    {
    //        this.one = a;
    //        this.two = b;
    //        this.three = c;
    //        this.four = d;
    //    }
    //}
    }
}
