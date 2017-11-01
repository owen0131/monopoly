using MonopolyGame.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MonopolyGame.viewmodels {

    public class GameViewModel : BindableBase {

        private Tuple<int, int> playerPos;
        public Tuple<int, int> PlayerPos {
            get { return this.playerPos; }
            set { SetProperty(ref playerPos, value); }
        }

        private readonly List<string> GridMapping = new List<string>() {
            "Thimble",
            "WheelBarrow",
            "Shoe",
            "Dog",
            "Car",
            "Iron",
            "Hat",
            "Battleship",
        };

        private string playerstr;
        public string PlayerStr { 
            get { return this.playerstr; }
            set { SetProperty(ref playerstr, value); }
        }

        public ICommand TokenSelect { protected set; get; }

        public GameViewModel() {
            PlayerStr = "";
            this.TokenSelect = new DelegateCommand<int>((int pos) => {
                if (pos < GridMapping.Count)
                    PlayerStr = $"clicked {GridMapping[pos]}";
                else PlayerStr = "";
            });
        }
    }
}

