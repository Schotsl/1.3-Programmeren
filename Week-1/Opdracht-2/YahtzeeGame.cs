using System;
using System.Collections.Generic;
using System.Linq;

namespace Opdracht_2
{
    class YahtzeeGame
    {
        private Dobbelsteen[] dobbelStenen = new Dobbelsteen[5];

        public YahtzeeGame()
        {
            for (int i = 0; i < dobbelStenen.Length; i++)
            {
                Random random = new Random();
                dobbelStenen[i] = new Dobbelsteen(random);
            }
        }

        public void Gooi()
        {
            for (int i = 0; i < dobbelStenen.Length; i++)
            {
                dobbelStenen[i].Gooi();
            }
        }

        public void ToonWorp()
        {
            for (int i = 0; i < dobbelStenen.Length; i ++)
            {
                dobbelStenen[i].ToonWaarde();
                Console.Write(" ");
            }

            Console.WriteLine();
        }

        int getMatching()
        {
            int finalMatchingValues = 0;

            for (int i = 0; i < dobbelStenen.Length; i ++)
            {
                int temporaryMatchingValues = 0;

                for (int j = 0; j < dobbelStenen.Length; j ++)
                {
                    if (dobbelStenen[i].waarde == dobbelStenen[j].waarde) temporaryMatchingValues++;
                }

                if (temporaryMatchingValues > finalMatchingValues)
                {
                    finalMatchingValues = temporaryMatchingValues;
                }
            }

            return finalMatchingValues;
        }

        int getDiffrent()
        {
            List<int> diffrentArray = new List<int>();

            for (int i = 0; i < dobbelStenen.Length; i++)
            {
                if (!diffrentArray.Contains(dobbelStenen[i].waarde))
                {
                    diffrentArray.Add(dobbelStenen[i].waarde);
                }
            }

            return diffrentArray.Count;
        }

        int[] getPattern()
        {
            int[] emptyPattern = { 0, 0, 0, 0, 0, 0 };

            for (int i = 0; i < dobbelStenen.Length; i++)
            {
                emptyPattern[dobbelStenen[i].waarde - 1] = 1;
            }

            return emptyPattern;
        }

        public bool FullHouse()
        {
            return getDiffrent() == 3 && getDiffrent() == 2;
        }

        public bool Yahtzee()
        {
            return getMatching() == 5;
        }

        public bool FourOfAKind()
        {
            return getMatching() == 4;
        }

        public bool ThreeOfAKind()
        {
            return getMatching() == 3;
        }

        public bool KleineStraat()
        {
            int[][] validPatterns = { new int[] { 0, 0, 1, 1, 1, 1 },
                                      new int[] { 0, 1, 1, 1, 1, 0 },
                                      new int[] { 1, 1, 1, 1, 0, 0 } };
     
            for (int i = 0; i < validPatterns.Length; i ++)
            {
                if (validPatterns[i].SequenceEqual(getPattern()))
                {
                    return true;
                }
            }

            return false;
        }

        public bool GroteStraat()
        {
            int[][] validPatterns = { new int[] { 0, 1, 1, 1, 1, 1 },
                                      new int[] { 1, 1, 1, 1, 1, 0 } };

            for (int i = 0; i < validPatterns.Length; i++)
            {
                if (validPatterns[i].SequenceEqual(getPattern()))
                {
                    return true;
                }
            }

            return false;
        }
    }
}
