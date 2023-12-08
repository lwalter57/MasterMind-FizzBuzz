using Mastermind.Abstractions;
using Mastermind.Enums;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mastermind
{
    public class Boardgame
    {
        public Player Player {  get; set; }
        //public IPlayable Player {  get; set; }
        private List<Color> WinningMixture {  get; set; }
        public Boardgame()
        {
            Player = new Player("Dolu");
            WinningMixture = new List<Color>();
        }

        public void DisplayColorsChoice()
        {
            Console.WriteLine("Choose a color :");
            foreach (int i in Enum.GetValues(typeof(Color)))
            {
                Console.Write($"{Enum.GetName(typeof(Color), i)}");
                Console.WriteLine($" {i}");
            }
        }

        public List<Color> DefineWinningMixture()
        {
            if (WinningMixture.Count() == 0)
            {
                for (int i = 0; i < 4; i++)
                {
                    Random random = new Random();
                    var randomColor = random.Next(6);
                    WinningMixture.Add((Color)randomColor);
                }
            }
            return WinningMixture;
        }

        public int CountColorWellPlaced()
        {
            var winCounter = 0;
            for (int i = 0; i < WinningMixture.Count; i++)
            {
                if (WinningMixture[i] == Player.ColorsMixture[i])
                {
                    Console.WriteLine($"Case {i+1} bonne réponse");
                    winCounter++;
                }
            }
            return winCounter;
        }
        public void DisplayColorPresent()
        {
            foreach (var color in Player.ColorsMixture)
            {
                if (WinningMixture.Contains(color))
                    Console.WriteLine($"{color} PRESENT");
                else
                    Console.WriteLine($"{color} NON PRESENT");
            }
        }
        public void DisplayWinMixture()
        {
            foreach (var color in WinningMixture)
            {
                Console.WriteLine(color);
            }
        }
        public bool IsWin()
        {
            return CountColorWellPlaced() == 4;
        }
    }
}
