using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Domain;

namespace Tennis.Service
{
    public class ScoreLabelService
    {

        private string[] _labelEqualScore = new string[]
        {
            "Love-All",
            "Fifteen-All",
            "Thirty-All"
        };

        private string[] _labelScore = new string[]
        {
            "Love",
            "Fifteen",
            "Thirty",
            "Forty"
        };

        public string Create(Player player1, Player player2)
        {

            var score1 = player1.Score;
            var score2 = player2.Score;

            var finalScore = string.Empty;

            if (score1 == score2 && score1 >= 3 && score2 >= 3)
            {
                finalScore = "Deuce";
            }
            else if (score1 == score2)
            {
                finalScore = _labelEqualScore[score1];
            }
            else if (score1 >= 4 || score2 >= 4)
            {
                var minusResult = score1 - score2;

                if (minusResult == 1)
                {
                    finalScore = "Advantage player1";
                }
                else if (minusResult == -1)
                {
                    finalScore = "Advantage player2";
                }
                else if (minusResult >= 2)
                {
                    finalScore = "Win for player1";
                }
                else
                {
                    finalScore = "Win for player2";
                }

            }
            else
            {
                var i = 1;
                while (i < 3)
                {

                    int tempScore;

                    if (i == 1)
                    {
                        tempScore = score1;
                    }
                    else
                    {
                        tempScore = score2;
                        finalScore = String.Concat(finalScore, "-");
                    }

                    finalScore = String.Concat(finalScore, _labelScore[tempScore]);
                    i++;
                }
            }

            return finalScore;

        }

    }
}
