using Mastermind.Abstractions;
using Mastermind.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Player : IPlayable
    {
        public string Nickname { get; set; }
        public List<Color> ColorsMixture { get; set; }
        public Color Choice { get; set; }

        public Player(string nickname)
        {
            Nickname = nickname;
            ColorsMixture = new List<Color>();
        }

        public List<Color> ChooseAColorsMixture()
        {
            Console.WriteLine("Type enter");
            ColorsMixture = new List<Color>();
            int fullMixture = 4;
            for (var i = 0; i < fullMixture; i++)
            {
                var playerChoiceChat = Console.ReadLine();
                var playerChoice = Convert.ToInt32(playerChoiceChat);
                Color color = (Color)playerChoice;
                ColorsMixture.Add(color);
            }
            return ColorsMixture;
        }
    }
}
