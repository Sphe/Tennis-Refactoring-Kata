using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tennis.Domain
{
    public class Player : IEquatable<Player>
    {
        
        private string _name;
        private int _score;

        public Player(string name, int score = 0)
        {
            _name = name;
            _score = score;
        }

        public string Name
        {
            get { return _name; }
        }

        public int Score
        {
            get { return _score; }
        }

        public void Scoring()
        {
            _score++;
        }

        public bool Equals(Player other)
        {
            return string.Compare(_name, other.Name, true) == 0;
        }

    }
}
