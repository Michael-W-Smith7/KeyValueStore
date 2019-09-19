using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Key_Value_Store
{
    public class MyDictionary
    {
        
        private KeyValue<object>[] DictionArray = new KeyValue[]
        {
            new KeyValue("NotDog", 1),
            new KeyValue("Cats", 2),
            new KeyValue("Penguin", 4)
        };
        private int counter;

        public MyDictionary()
        {
            counter = DictionArray.Length;
        }
         public object this [string _Key]
        {
            get
            {
                foreach (var Z in DictionArray)
                {
                    if (Z.Key.Equals(_Key))
                    {
                        return Z.Value;
                    }
                }
                throw new KeyNotFoundException ($"Key not found with the value {_Key}");
            }
            set
            {
                bool exists = false;
                int i = 0, temp = 0;
                foreach (var Z in DictionArray)
                {
                    if (Z.Key.Equals(_Key))
                    {
                        exists = true;
                        temp = i;
                    }
                    i++;
                }
                if (exists == true)
                {
                    DictionArray[temp] = new KeyValue(_Key, value);
                }
                else
                {
                    Array.Resize(ref DictionArray, (DictionArray.Length + 1));
                    DictionArray[DictionArray.Length-1] = new KeyValue(_Key, value);
                }
            }
        }

    }
}
