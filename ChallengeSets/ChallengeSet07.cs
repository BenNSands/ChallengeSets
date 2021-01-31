using System;
using System.Collections.Generic;

namespace ChallengeSets
{
    public class ChallengeSet07
    {
        public int CountOfBusinessesWithNegativeNetProfit(List<Business> businesses)
        {
            var ans = 0;
            if (businesses == null)
            {
                return ans;
            }
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue - biz.TotalExpenses <= 0)
                {
                    ans++;
                }
            }
            return ans;
        }

        public string GetCommaSeparatedListOfProfitableBusinesses(List<Business> businesses)
        {
            var ansList = new List<string>();
            var ansStr = "";
            var ans = "";
            foreach (var biz in businesses)
            {
                if (biz.TotalRevenue > biz.TotalExpenses)
                {
                    ansList.Add(biz.Name.ToString());
                }
            }
            foreach (var profitable in ansList)
            {
                ansStr += profitable + ",";
            }
            for (int i = 0; i < ansStr.Length -1; i++)
            {
                ans += ansStr[i];
            }

            
            return ans;
        }

        public string GetNameOfHighestParentCompany(Business business)
        {
            // If there is Company A, whose parent is Company B, whose parent is Company C, then given Company A return Company C
            if (business.ParentCompany == null)
            {
                return business.Name;
            }
            var newCom = business;
            var listOfParents = new List<Business>();
            while (newCom.ParentCompany != null)
            {
                Business parent = newCom.ParentCompany;
                listOfParents.Add(parent);
                newCom = parent;

            }
       
            var arr = listOfParents.ToArray();
            var lastIndex = arr.Length - 1;
            var ans = arr[lastIndex].Name;
            return ans;
        }

        public enum TicTacToeResult { X, O, Draw }
        public TicTacToeResult GetTicTacToeWinner(char[,] finalBoard)
        {
            //determining placement
            var x11 = false;
            var o11 = false;

            if (finalBoard[0, 0] == 'X')
            {
                x11 = true;
            }
            else if (finalBoard[0, 0] == 'O')
            {
                o11 = true;
            }

            var x12 = false;
            var o12 = false;

            if (finalBoard[0, 1] == 'X')
            {
                x12 = true;
            }
            else if (finalBoard[0, 1] == 'O')
            {
                o12 = true;
            }

            var x13 = false;
            var o13 = false;

            if (finalBoard[0, 2] == 'X')
            {
                x13 = true;
            }
            else if (finalBoard[0, 2] == 'O')
            {
                o13 = true;
            }

            var x21 = false;
            var o21 = false;

            if (finalBoard[1, 0] == 'X')
            {
                x21 = true;
            }
            else if (finalBoard[1, 0] == 'O')
            {
                o21 = true;
            }

            var x22 = false;
            var o22 = false;

            if (finalBoard[1, 1] == 'X')
            {
                x22 = true;
            }
            else if (finalBoard[1, 1] == 'O')
            {
                o22 = true;
            }

            var x23 = false;
            var o23 = false;

            if (finalBoard[1, 2] == 'X')
            {
                x23 = true;
            }
            else if (finalBoard[1, 2] == 'O')
            {
                o23 = true;
            }

            var x31 = false;
            var o31 = false;

            if (finalBoard[2, 0] == 'X')
            {
                x31 = true;
            }
            else if (finalBoard[2, 0] == 'O')
            {
                o31 = true;
            }

            var x32 = false;
            var o32 = false;

            if (finalBoard[2, 1] == 'X')
            {
                x32 = true;
            }
            else if (finalBoard[2, 1] == 'O')
            {
                o32 = true;
            }

            var x33 = false;
            var o33 = false;

            if (finalBoard[2, 2] == 'X')
            {
                x33 = true;
            }
            else if (finalBoard[2, 2] == 'O')
            {
                o33 = true;
            }
            //end determining placement

            //check for winner
            //checking rows
            if (x11 && x12 && x13)
            {
                return TicTacToeResult.X;
            }
            else if (o11 && o12 && o13)
            {
                return TicTacToeResult.O;
            }
            else if (x21 && x22 && x23)
            {
                return TicTacToeResult.X;
            }
            else if (o21 && o22 && o23)
            {
                return TicTacToeResult.O;
            }
            else if (x31 && x32 && x33)
            {
                return TicTacToeResult.X;
            }
            else if (o31 && o32 && o33)
            {
                return TicTacToeResult.O;
            }
            //checking columns
            else if (x11 && x21 && x31)
            {
                return TicTacToeResult.X;
            }
            else if (o11 && o21 && o31)
            {
                return TicTacToeResult.O;
            }
            else if (x12 && x22 && x32)
            {
                return TicTacToeResult.X;
            }
            else if (o12 && o22 && o32)
            {
                return TicTacToeResult.O;
            }
            else if (x13 && x23 && x33)
            {
                return TicTacToeResult.X;
            }
            //checking crosses
            else if (x11 && x22 && x33)
            {
                return TicTacToeResult.X;
            }
            else if (o11 && o22 && o33)
            {
                return TicTacToeResult.O;
            }
            else if (x31 && x22 && x13)
            {
                return TicTacToeResult.X;
            }
            else if (o31 && o22 && o13)
            {
                return TicTacToeResult.O;
            }
            else
            {
                return TicTacToeResult.Draw;
            }

        }

        public bool EachArrayInJaggedArrayContainsTargetNumber(int[][] numbers, int targetNumber)
        {
            if (numbers.Length == 0)
            {
                return false;
            }
            var count = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                foreach (var num in numbers[i])
                {
                    if (num == targetNumber)
                    {
                        count++;
                        break;
                    }
                }
            }
            if (count == numbers.Length)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
