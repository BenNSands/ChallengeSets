using System;
using System.Collections.Generic;
namespace ChallengeSets
{
    public class ChallengeSet08
    {
        public bool CanHopAcross(int[] hopAmount)
        {
            throw new NotImplementedException();
        }

        public enum Frogger { Y, N }
        public Frogger GetTheFrogAcross(char[,] finalResult)
        {
            //rearranging into columns

            var col3 = new List<char>();
            col3.Add(finalResult[0, 2]);
            col3.Add(finalResult[1, 2]);
            col3.Add(finalResult[2, 2]);
            col3.Add(finalResult[3, 2]);

            var col2 = new List<char>();
            col2.Add(finalResult[0, 1]);
            col2.Add(finalResult[1, 1]);
            col2.Add(finalResult[2, 1]);
            col2.Add(finalResult[3, 1]);

            var col1 = new List<char>();
            col1.Add(finalResult[0, 0]);
            col1.Add(finalResult[1, 0]);
            col1.Add(finalResult[2, 0]);
            col1.Add(finalResult[3, 0]);

            var hasExit = 0;
            foreach (var spot in col3)
            {
                if (spot == 'X')
                {
                    hasExit++;
                }
                if (hasExit >= 4)
                {
                    return Frogger.N;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                if (col3[i] == 'O')
                {
                    if (col3[i] == col2[i])
                    {

                    }
                }
                
            }


            throw new NotImplementedException();
        }
    }
}
