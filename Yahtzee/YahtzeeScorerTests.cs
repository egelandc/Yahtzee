using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    class YahtzeeScorerTests
    {
        YahtzeeScorer yahtzee = new YahtzeeScorer();
        enum category { ONES, TWOS, THREES, FOURS, FIVES, SIX, TWOPAIRS, THREEOFAKIND,FOUROFAKIND, SMALLSTRAIGHT, LARGESTRAIGHT, FULLHOUSE, CHANCE, YAHTZEE};

        public void test()
        {
            if(yahtzee.Score("1,1,1,1,2", yahtzee.categoryList[(int)category.ONES]) != 4)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("1,1,1,1,2", yahtzee.categoryList[(int)category.TWOS]) != 2)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("1,1,1,1,2", yahtzee.categoryList[(int)category.THREES]) != 0)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("1,4,1,1,2", yahtzee.categoryList[(int)category.FOURS]) != 4)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("2,4,5,3,6", yahtzee.categoryList[(int)category.LARGESTRAIGHT]) != 20)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("2,4,5,3,1", yahtzee.categoryList[(int)category.SMALLSTRAIGHT]) != 15)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("1,1,1,1,2", yahtzee.categoryList[(int)category.FOUROFAKIND]) != 4)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("1,1,1,1,2", yahtzee.categoryList[(int)category.THREEOFAKIND]) != 3)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("3,6,3,3,6", yahtzee.categoryList[(int)category.FULLHOUSE]) != 21)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("4,4,4,2,1", yahtzee.categoryList[(int)category.CHANCE]) != 15)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("1,1,1,1,1", yahtzee.categoryList[(int)category.YAHTZEE]) != 50)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("6,6,6,6,6", yahtzee.categoryList[(int)category.YAHTZEE]) != 50)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("4,1,4,2,2", yahtzee.categoryList[(int)category.TWOPAIRS]) != 12)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("4,1,3,2,2", yahtzee.categoryList[(int)category.TWOPAIRS]) != 0)
            {
                throw new Exception("Calculation error!");
            }
            if (yahtzee.Score("4,1,3,2,2", yahtzee.categoryList[(int)category.YAHTZEE]) != 0)
            {
                throw new Exception("Calculation error!");
            }
        }

    }
}
