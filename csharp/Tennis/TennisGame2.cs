using Tennis.Domain;
using Tennis.Service;

namespace Tennis
{
    public class TennisGame2 : ITennisGame
    {

        private Player _player1;
        private Player _player2;
        private ScoreLabelService _scoreLabelService;

        public TennisGame2(string player1Name, string player2Name)
        {
            _player1 = new Player(player1Name);
            _player2 = new Player(player2Name);
            _scoreLabelService = new ScoreLabelService();
        }

        public string GetScore()
        {
            return _scoreLabelService.Create(_player1, _player2);
        }

        public void WonPoint(string player)
        {
            if (string.Compare(player, ScoreLabelMessageList.PLAYER1_DEFAULTNAME, true) == 0)
            {
                _player1.Scoring();
            }
            else
            {
                _player2.Scoring();
            }
        }

    }
}

