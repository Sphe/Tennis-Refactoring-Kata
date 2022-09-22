using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Service
{
    public class ScoreLabelMessageList
    {
        private string[] _labelEqualScore = new string[]
        {
            "Love-All",
            "Fifteen-All",
            "Thirty-All",
            "Deuce"
        };

        private string[] _labelScore = new string[]
        {
            "Love",
            "Fifteen",
            "Thirty",
            "Forty"
        };

        private List<((int, int), string)> _labelWinning = new List<((int, int), string)>()
        {
            { ((1, 1), "Advantage player1") },
            { ((-1, -1), "Advantage player2") },
            { ((2, int.MaxValue), "Win for player1") },
            { ((int.MinValue, -2), "Win for player2") }
        };

        public string LabelWinningScoreList(int diffScorePoint)
        {
            foreach(var item in _labelWinning)
            {
                if (!(item.Item1.Item1 <= diffScorePoint && item.Item1.Item2 >= diffScorePoint))
                {
                    continue;
                }

                return item.Item2;
            }

            return string.Empty;
        }

        public string LabelEqualScoreList(int index)
        {
            index = CheckLimitArray(index, _labelEqualScore);
            return _labelEqualScore[index];
        }

        public string LabelNormalScoreList(int index)
        {
            index = CheckLimitArray(index, _labelScore);
            return _labelScore[index];
        }

        private int CheckLimitArray(int index, object[] arr)
        {
            if (arr.Length <= index)
            {
                index = arr.Length - 1;
            }

            return index;
        }
    }
}
