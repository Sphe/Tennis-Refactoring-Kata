using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tennis.Domain;
using Tennis.Service.Contract;

namespace Tennis.Service
{
    public class ScoreLabelMessageService : IScoreLabelMessageService
    {

        public const string PLAYER1_DEFAULTNAME = "player1";

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

        private List<RangeMessage> _labelWinning = new List<RangeMessage>()
        {
            { new RangeMessage() { Range = (1, 1), Message = "Advantage player1" } },
            { new RangeMessage() { Range = (-1, -1), Message = "Advantage player2" } },
            { new RangeMessage() { Range = (2, int.MaxValue), Message = "Win for player1" } },
            { new RangeMessage() { Range = (int.MinValue, -2), Message = "Win for player2" } }
        };

        public string LabelWinningScoreList(int diffScorePoint)
        {
            string messFinal = string.Empty;
            foreach (var item in _labelWinning)
            {
                if (!(item.Range.Item1 <= diffScorePoint && item.Range.Item2 >= diffScorePoint))
                {
                    continue;
                }

                messFinal = item.Message;
                break;
            }

            return messFinal;
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
