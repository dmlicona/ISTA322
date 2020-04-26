using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08a
{
    class Utility
    {
        public Utility()
        {
            rouLette();
        }
        private void rouLette()
        {
            Console.WriteLine($"Spinning The Roulette Wheel....");
            Console.ReadKey();
            int[] r = new int[] { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,0, 00 };
            int rndRoll = ranDom(r);
            Console.WriteLine($"Number: Winning number is {rndRoll}");
            Color(r, rndRoll);
            evenOdd(rndRoll);
            highLow(rndRoll);
            doZens(rndRoll);
            coLumns(rndRoll);
            Console.WriteLine($"Row: The Winner is {Rows(rndRoll)}");
            dblrOws(rndRoll);
            spLit(rndRoll);
            coRner(rndRoll);
            Console.WriteLine($"Press Any Key to Continue.... Press Spacebar To Exit!!!");
            Console.WriteLine($"\n");
        }
        private int ranDom(int[] a)
        {
            Random random = new Random();
            int rndRoll = a[random.Next(a.Length)];
            return rndRoll;
        }
        private void Color(Array a, int val)
        {
            if (Array.IndexOf(a, val) <= 17)
                Console.WriteLine($"Color: Winning color is Red");
            else if (Array.IndexOf(a, val) > 17 & Array.IndexOf(a, val) < 36)
                Console.WriteLine($"Color: Winning color is Black");
        }
        private void evenOdd(int num)
        {
            if (num % 2 == 0 & num != 0)
                Console.WriteLine($"Even/Odds: Winner is Evens");
            else if (num % 2 == 1 & num != 0)
                Console.WriteLine($"Even/Odds: Winner is Odds");
        }
        private void highLow(int number)
        {
            if (number >= 1 & number <= 18)
                Console.WriteLine($"High/Low: Winner is Lows");
            else if (number >= 19 & number != 0)
                Console.WriteLine($"High/Low: Winner is Highs");
        }
        private void doZens(int numb)
        {
            if (numb >= 1 & numb <= 12)
                Console.WriteLine($"Dozen: Winner is 1st Dozen");
            else if (numb >= 13 & numb <= 24)
                Console.WriteLine($"Dozen: Winner is 2nd Dozen");
            else if (numb >= 25 & numb != 0)
                Console.WriteLine($"Dozen: Winner is 3rd Dozen");
        }
        private void coLumns(int roll)
        {

            if (roll % 3 == 0 & roll > 0)
                Console.WriteLine($"Column: Winner is 3rd Column");
            else if (roll % 3 == 2)
                Console.WriteLine($"Column: Winner is 2nd Column");
            else if (roll % 3 == 1)
                Console.WriteLine($"Column: Winner is 1st Column");
        }
        private (object, object, object) Rows(int rOll)
        {
            if (rOll % 3 == 0 & rOll != 0)
                return (rOll - 2, rOll - 1, rOll);
            else if (rOll % 3 == 2 & rOll != 0)
                return (rOll - 1, rOll, rOll + 1);
            else if (rOll % 3 == 1 & rOll != 0)
                return (rOll, rOll + 1, rOll + 2);
            else
                return ("No", "Winning", "Row");
        }
        private void dblrOws(int rndnum)
        {
            int lStreet = rndnum - 3;
            int rStreet = rndnum + 3;
            if (rndnum >= 1 & rndnum <= 3)
                Console.WriteLine($"Double Row: Winner is {Rows(rndnum)} / {Rows(rStreet)}");
            else if (rndnum >= 34 & rndnum <= 36)
                Console.WriteLine($"Double Row: Winner is {Rows(rndnum)} / {Rows(lStreet)}");
            else if (rndnum >= 4 & rndnum <= 33)
                Console.WriteLine($"Double Row: Winners are {Rows(lStreet)} {Rows(rndnum)} / {Rows(rndnum)} {Rows(rStreet)}");
        }
        private void spLit(int rndNum)
        {
            int lStreet = rndNum - 3;
            int rStreet = rndNum + 3;
            if (rndNum == 1)
                Console.WriteLine($"Split: Winners are ({rndNum}, {rndNum + 1}) / ({rndNum}, {rStreet})");
            else if (rndNum == 2)
                Console.WriteLine($"Split: Winners are ({rndNum}, {rndNum - 1}) / ({rndNum}, {rndNum + 1}) / ({rndNum}, {rStreet})");
            else if (rndNum == 3)
                Console.WriteLine($"Split: Winners are ({rndNum}, {rndNum - 1}) / ({rndNum}, {rStreet})");
            else if (rndNum == 34)
                Console.WriteLine($"Split: Winners are ({rndNum}, {rndNum + 1}) / ({rndNum}, {lStreet})");
            else if (rndNum == 35)
                Console.WriteLine($"Split: Winners are ({rndNum}, {rndNum - 1}) / ({rndNum}, {rndNum + 1}) / ({rndNum}, {lStreet})");
            else if (rndNum == 36)
                Console.WriteLine($"Split: Winners are ({rndNum}, {rndNum - 1}) / ({rndNum}, {lStreet})");
            else if (rndNum % 3 == 0 & rndNum > 3 & rndNum < 34)
                Console.WriteLine($"Split: Winners are ({rndNum}, {lStreet}) / ({rndNum}, {rStreet}) / ({rndNum}, {rndNum - 1})");
            else if (rndNum % 3 == 2 & rndNum > 3 & rndNum < 34)
                Console.WriteLine($"Split: Winners are ({rndNum}, {lStreet}) / ({rndNum}, {rStreet}) / ({rndNum}, {rndNum - 1}) / ({rndNum}, {rndNum + 1})");
            else if (rndNum % 3 == 1 & rndNum > 3 & rndNum < 34)
                Console.WriteLine($"Split: Winners are ({rndNum}, {lStreet}) / ({rndNum}, {rStreet}) / ({rndNum}, {rndNum + 1})");
        }
        private void coRner(int rndRoll)
        {
            int lStreet = rndRoll - 3;
            int rStreet = rndRoll + 3;
            if (rndRoll == 1)
                Console.WriteLine($"Corner: Winners are ({rndRoll}, {rndRoll + 1}, {rStreet}, {rStreet + 1})");
            else if (rndRoll == 2)
                Console.WriteLine($"Corner: Winners are ({rndRoll - 1}, {rndRoll}, {rStreet - 1}, {rStreet}) / ({rndRoll}, {rndRoll + 1}, {rStreet}, {rStreet + 1})");
            else if (rndRoll == 3)
                Console.WriteLine($"Corner: Winners are ({rndRoll - 1}, {rndRoll}, {rStreet - 1}, {rStreet})");
            else if (rndRoll == 34)
                Console.WriteLine($"Corner: Winners are ({lStreet}, {lStreet + 1}) / ({rndRoll}, {rndRoll + 1})");
            else if (rndRoll == 35)
                Console.WriteLine($"Corner: Winners are ({lStreet - 1}, {lStreet}, {rndRoll - 1}, {rndRoll}) / ({lStreet}, {lStreet + 1}, {rndRoll}, {rndRoll + 1})");
            else if (rndRoll == 36)
                Console.WriteLine($"Corner: Winners are ({lStreet - 1}, {lStreet}, {rndRoll - 1}, {rndRoll})");
            else if (rndRoll % 3 == 0 & rndRoll > 3 & rndRoll < 34)
                Console.WriteLine($"Corner: Winners are ({lStreet - 1}, {lStreet}, {rndRoll - 1}, {rndRoll}) / ({rndRoll - 1}, {rndRoll}, {rStreet - 1}, {rStreet})");
            else if (rndRoll % 3 == 2 & rndRoll > 3 & rndRoll < 34)
                Console.WriteLine($"Corner: Winners are ({lStreet - 1}, {lStreet}, {rndRoll - 1}, {rndRoll}) / ({lStreet}, {lStreet + 1}, {rndRoll}, {rndRoll + 1}) / ({rndRoll - 1}, {rndRoll}, {rStreet - 1}, {rStreet}) / ({rndRoll}, {rndRoll + 1}, {rStreet}, {rStreet + 1})");
            else if (rndRoll % 3 == 1 & rndRoll > 3 & rndRoll < 34)
                Console.WriteLine($"Corner: Winners are ({lStreet}, {lStreet + 1}, {rndRoll}, {rndRoll + 1}) / ({rndRoll}, {rndRoll + 1}, {rStreet}, {rStreet + 1})");
        }
    }
}