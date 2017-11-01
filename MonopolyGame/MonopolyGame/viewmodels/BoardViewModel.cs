using MonopolyGame.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.viewmodels {

    class KeyValueList<TKey, TValue> : List<Tuple<TKey, TValue>> {
        public void Add(TKey key, TValue value) {
            Add(new Tuple<TKey, TValue>(key, value));
        }
    }

    public class BoardViewModel : BindableBase {

        private Tuple<int, int> playerPos;
        public Tuple<int, int> PlayerPos
        {
            get { return this.playerPos; }
            set { SetProperty(ref playerPos, value); }
        }

        KeyValueList<String, Tuple<int, int>> positions = new KeyValueList<String, Tuple<int, int>>() {
            {"GO", new Tuple<int, int>(11,11) }
        };
    }
}
