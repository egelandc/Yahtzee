using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public interface Category
    {
        // Score function
        int score(int[] values);
    }

    class YahtzeeScorer
    {
        
        Random rand = new Random();

        public bool[] holdDice = new bool[5];
        public int[] diceValue = new int[5];
        public string roll;
        public int rollsLeft = 3;

        public List<Category> categoryList = new List<Category>();

        public YahtzeeScorer()
        {
            //Add category objects.
            categoryList.Add(new Ones());
            categoryList.Add(new Twos());
            categoryList.Add(new Threes());
            categoryList.Add(new Fours());
            categoryList.Add(new Fives());
            categoryList.Add(new Sixes());
            categoryList.Add(new TwoPairs());
            categoryList.Add(new ThreeOfaKind());
            categoryList.Add(new FourOfaKind());
            categoryList.Add(new SmallStraight());
            categoryList.Add(new LargeStraight());
            categoryList.Add(new FullHouse());
            categoryList.Add(new Chance());
            categoryList.Add(new Yahtzee());
        }

        public void resetGame()
        {
            holdDice = new bool[5];
            diceValue = new int[5];
            roll = null;
            rollsLeft = 3;
        }

        //Shuffle dice
        public void shuffleAll()
        {
            if(rollsLeft > 0) { 
                if(roll != null)
                {
                    diceValue = Array.ConvertAll(roll.Split(','), s => int.Parse(s));
                }
            
                roll = "";
                for (int i = 0; i < 5; i++)
                {
                    if (!holdDice[i])
                    { roll += RollDie(); }
                    else
                    {
                        roll += diceValue[i];
                    }
                    if (i < 4)
                    {
                        roll += ",";
                    }

                }

                if (rollsLeft > 0)
                {
                    rollsLeft--;
                }
            }
            else
            {
                holdDice = new bool[5];
            }
        }


        public Score Max(string roll)
        {

            int maxScore = 0;
            Category cat = null;
            foreach(Category category in categoryList)
            {
                int tempScore = Score(roll, category);
                if (maxScore < tempScore)
                {
                    maxScore = tempScore;
                    cat = category;
                }
            }
            cat.ToString();
            return new Score(cat, maxScore);
        }


        //Roll a die
        public int RollDie()
        {
            return rand.Next(1, 7);
        }

        /// <summary>
        /// Function for computing a score value from a given roll and category
        /// </summary>
        /// <param name="roll">String representing a dice roll</param>
        /// <param name="category"></param>
        /// <returns></returns>
        public int Score(string roll, Category category)
        {
            //Convert roll string into integer array.
            int[] values = Array.ConvertAll(roll.Split(','), s => int.Parse(s));
            return category.score(values);
        }


        //Count number of dice of same value
       public static int[] diceValues(int[] values)
        {
            int[] diceVal = new int[6];

            //Initialize array
            for(int i = 0; i < diceVal.Length;i++)
            {
                diceVal[i] = 0;
            }

            foreach (int num in values)
            {
                diceVal[num-1]++;
            }

            return diceVal;
        }
    }

    class Score
    {
        public Category category;
        public int score;
        public Score(Category _cat, int _score)
        {
            category = _cat;
            score = _score;
        }
    }

    class Ones : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int num in values)
            {
                if (num == 1) score += 1;
            }
            return score;
        }
    }

    class Twos : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int num in values)
            {
                if (num == 2) score += 2;
            }
            return score;
        }
    }

    class Threes : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int num in values)
            {
                if (num == 3) score += 3;
            }
            return score;
        }
    }

    class Fours : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int num in values)
            {
                if (num == 4) score += 4;
            }
            return score;
        }
    }

    class Fives : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int num in values)
            {
                if (num == 5) score += 5;
            }
            return score;
        }
    }

    class Sixes : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int num in values)
            {
                if (num == 6) score += 6;
            }
            return score;
        }
    }

    class TwoPairs : Category
    {
        public int score(int[] values)
        {
            int[] diceVal = YahtzeeScorer.diceValues(values);
            int score = 0;

            int numberOfPairs = 0;
            for (int i = 6; i > 0; i--)
            {
                if (diceVal[i-1] > 1)
                {
                    score += 2 * (i);
                    numberOfPairs++;
                }

                if (numberOfPairs == 2)
                {
                    return score;
                }
            }
            return 0;//No score
        }
    }


    class ThreeOfaKind : Category
    {
        public int score(int[] values)
        {
            int[] diceVal = YahtzeeScorer.diceValues(values);

            for (int i = 0; i < 6; i++)
            {
                if (diceVal[i] > 2)
                {
                    return (i + 1) * 3;
                }
            }

            return 0;
        }
    }


    class FourOfaKind : Category
    {
        public int score(int[] values)
        {
            int[] diceVal = YahtzeeScorer.diceValues(values);

            for (int i = 0; i < 6; i++)
            {
                if (diceVal[i] > 3)
                {
                    return (i + 1) * 4;
                }
            }

            return 0;
        }
    }




    class Chance : Category
    {
        public int score(int[] values)
        {
            int score = 0;
            foreach (int val in values)
            {
                score += val;
            }

            return score;
        }
    }

    class Yahtzee : Category
    {
        public int score(int[] values)
        {
            int[] diceVal = YahtzeeScorer.diceValues(values);

            for (int i = 0; i < 6; i++)
            {
                if (diceVal[i] == 5)
                {
                    return 50;
                }
            }

            return 0;
        }
    }


    class SmallStraight : Category
    {
        public int score(int[] values)
        {
            int[] diceVal =YahtzeeScorer.diceValues(values);

            for (int i = 0; i < 5; i++)
            {
                if (diceVal[i] == 0)
                {
                    return 0;
                }
            }

            return 15;
        }
    }


    class LargeStraight : Category
    {
        public int score(int[] values)
        {
            int[] diceVal =YahtzeeScorer.diceValues(values);

            for (int i = 1; i < 6; i++)
            {
                if (diceVal[i] == 0)
                {
                    return 0;
                }
            }

            return 20;
        }
    }


    class FullHouse : Category
    {
        public int score(int[] values)
        {

            int[] diceVal = YahtzeeScorer.diceValues(values);
            bool twos = false;
            bool threes = false;
            
            for (int i = 0; i < 6; i++)
            {
                if (diceVal[i] == 2)
                {
                    twos = true;
                }
                if (diceVal[i] == 3)
                {
                    threes = true;
                }
            }

            if(twos && threes)
            {
                int score = 0;
                foreach (int val in values)
                {
                    score += val;
                }
                return score;
            }

            return 0;
        }
    }
}
