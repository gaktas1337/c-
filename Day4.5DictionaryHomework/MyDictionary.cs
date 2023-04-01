using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4._5DictionaryHomework
{
    class MyDictionary<Tkey,Tvalue>
    {
        Tkey[] keys;
        Tvalue[] values;

        public MyDictionary()
        {
            keys = new Tkey[0];
            values = new Tvalue[0];
        }
        public void Add(Tkey key, Tvalue value)
        {
            Tkey[] _tempKeys = keys;
            Tvalue[] _tempValue = values;

            keys = new Tkey[keys.Length + 1];
            values = new Tvalue[values.Length + 1];

            for (int i = 0; i < _tempKeys.Length; i++)
            {
                keys[i] = _tempKeys[i];
                values[i] = _tempValue[i];

            }
            keys[keys.Length - 1] = key;
            values[values.Length - 1] = value;
        }
        public Tkey[] Keys
        {
            get { return keys; }
        }

        public Tvalue[] Values
        {
            get { return values; }
        }


    }
}
