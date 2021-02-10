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
            var ans = Frogger.N;
            //rearranging into columns
            int pos = 10;

            var col3 = new List<char>();
            col3.Add(finalResult[0, 2]);
            col3.Add(finalResult[1, 2]);
            col3.Add(finalResult[2, 2]);
            col3.Add(finalResult[3, 2]);
            col3.Add(finalResult[4, 2]);

         
            var col2 = new List<char>();
            col2.Add(finalResult[0, 1]);
            col2.Add(finalResult[1, 1]);
            col2.Add(finalResult[2, 1]);
            col2.Add(finalResult[3, 1]);
            col2.Add(finalResult[4, 1]);

     
            var col1 = new List<char>();
            col1.Add(finalResult[0, 0]);
            col1.Add(finalResult[1, 0]);
            col1.Add(finalResult[2, 0]);
            col1.Add(finalResult[3, 0]);
            col1.Add(finalResult[4, 0]);

            

            //determine position of exit, if any
            var hasExit = 0;
            for (int i = 0; i < col3.Count; i++)
            {
                if (col3[i] == 'X')
                {
                    hasExit++;
                }

                if (hasExit >= 5)
                {
                    return Frogger.N;
                }

                if (col3[i] == 'O')
                {
                    pos = i;
                }
            }

         

            //checks for straight line out
            if (col2[pos] == col1[pos])
            {
                return Frogger.Y;
            }

            //finds all enterances if more than one
            var numOfEnts = 0;
            int ent = 10;
            int ent2 = 10;//need more vars if you want to test for all entrances
            for (int i = 0; i < col1.Count; i++)
            {
                if (col1[i] == 'O' && numOfEnts == 0)
                {
                    ent = i;
                    numOfEnts++;
                }
                else if (col1[i] == 'O' && numOfEnts > 0)
                {
                    ent2 = i;
                }
            }

            //checks if only entrance doesn't have an out
            if (col1[ent] != col2[ent] && ent2 == 10)
            {
                return Frogger.N;
            }

            var midPath = 0;
            var diff = 0;
            //checks if mid path connects on first entry
            if (ent2 == 10)
            {
                if (ent > pos)
                {
                    diff = ent - pos;
                    for (int i = pos; i < ent; i++)
                    {
                        if (col2[i] == 'O')
                        {
                            midPath++;
                        }

                    }
                }
                if (ent < pos)
                {
                    diff = pos - ent;
                    for (int i = ent; i < pos; i++)
                    {
                        if (col2[i] == 'O')
                        {
                            midPath++;
                        }

                    }
                }
                if (midPath == diff)
                {
                    ans = Frogger.Y;
                }
                else
                {
                    ans = Frogger.N;
                }
            }
            //checks if mid path connects on second entry
            if (ent2 != 10)
            {
                if (ent2 > pos)
                {
                    diff = ent2 - pos;
                    for (int i = pos; i < ent2; i++)
                    {
                        if (col2[i] == 'O')
                        {
                            midPath++;
                        }

                    }
                }
                if (ent2 < pos)
                {
                    diff = pos - ent2;
                    for (int i = ent2; i < pos; i++)
                    {
                        if (col2[i] == 'O')
                        {
                            midPath++;
                        }

                    }
                }
                if (midPath == diff)
                {
                    ans = Frogger.Y;
                }
                else
                {
                    ans = Frogger.N;
                }
            }
            return ans;
        }
    }
}
