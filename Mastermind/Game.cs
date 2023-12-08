using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Game
    {
        public Boardgame Boardgame { get; set; }
        public Game() 
        {
            Boardgame = new Boardgame();
        }

        public void Play()
        {
            while (!Boardgame.IsWin())
            {
                Boardgame.DisplayColorsChoice();
                Boardgame.DefineWinningMixture();
                Boardgame.Player.ChooseAColorsMixture();
                Boardgame.DisplayColorPresent();
                if (Boardgame.IsWin())
                    Console.WriteLine("Win");
                else
                    Console.WriteLine("Continue");
                Boardgame.DisplayWinMixture();
            }
        }
    }
}
