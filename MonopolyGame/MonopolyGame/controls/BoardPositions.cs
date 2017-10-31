using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonopolyGame.controls {

    public class KeyValueList<TKey, TValue> : List<Tuple<TKey, TValue>> {
        public void Add(TKey key, TValue value) {
            Add(new Tuple<TKey, TValue>(key, value));
        }
    }
    class BoardPositions {
        KeyValueList<String, Tuple<int, int>> positions = new KeyValueList<String, Tuple<int, int>>() {
            {"GO", new Tuple<int, int>(11,11) }
        };
    }
}
