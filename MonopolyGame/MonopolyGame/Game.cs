using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame
{
    public class Game
    {
        public static bool ValidateNumberOfPlayers(string a_NumberOfPlayers)
        {
            bool l_Success = false;
            int l_Number = -1;
            if(!string.IsNullOrEmpty(a_NumberOfPlayers) && int.TryParse(a_NumberOfPlayers,out l_Number))
            {
                if(l_Number>=2 && l_Number<=6)
                {
                    l_Success = true;
                }                
            }
            return l_Success;
        }
    }
}
