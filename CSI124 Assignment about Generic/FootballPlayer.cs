using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSI124_Assignment_about_Generic
{
    internal class FootballPlayer : Player
    {
        int _yardsthrown;

        public FootballPlayer(string name, string number, double salary, int yardsthrown) : base(name, number, salary)
        {
            _yardsthrown = yardsthrown;
        }
        public FootballPlayer()
        {

        }
        public int Yardsthrown { get => _yardsthrown; set => _yardsthrown = value; }
    }
}
