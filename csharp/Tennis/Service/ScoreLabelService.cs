using System;
using Tennis.Domain;

namespace Tennis.Service
{
    public class ScoreLabelService
    {

        private ScoreLabelMessageList _scoreLabelMessageList;

        public ScoreLabelService()
        {
            _scoreLabelMessageList = new ScoreLabelMessageList();
        }

        public string Create(Player player1, Player player2)
        {

            var score1 = player1.Score;
            var score2 = player2.Score;

            string finalScore;

            if (score1 == score2)
            {
                finalScore = _scoreLabelMessageList.LabelEqualScoreList(score1);
            }
            else if (score1 >= 4 || score2 >= 4)
            {
                var minusResult = score1 - score2;
                finalScore = _scoreLabelMessageList.LabelWinningScoreList(minusResult);
            }
            else
            {
                finalScore = string.Concat(_scoreLabelMessageList.LabelNormalScoreList(score1), "-", _scoreLabelMessageList.LabelNormalScoreList(score2));
            }

            return finalScore;

        }

    }
}
