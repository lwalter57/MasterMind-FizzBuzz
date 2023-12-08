using Mastermind.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks;

namespace Mastermind.Abstractions
{
    public interface IPlayable
    {
        public List<Color> ChooseAColorsMixture();
    }
}
