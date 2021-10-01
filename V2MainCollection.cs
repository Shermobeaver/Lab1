using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    // V2MainCollection
    class V2MainCollection
    {
        // List of lists and Arrays
        private System.Collections.Generic.List<V2Data> Collection;

        // Constructor
        public V2MainCollection()
        {
            Collection = new();
        }

        // Properties
        public int Count
        {
            get
            {
                return Collection.Count;
            }
        }

        // Indexer
        public V2Data this[int index]
        {
            get
            {
                return Collection[index];
            }
        }

        // Methods
        public bool Contains(string ID)
        {
            foreach (V2Data item in Collection)
            {
                if (item.Str == ID)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Add(V2Data NewItem)
        {
            foreach (V2Data item in Collection)
            {
                if (item.Str == NewItem.Str)
                {
                    return false;
                }
            }
            Collection.Add(NewItem);
            return true;
        }

        // Output
        public string ToLongString(string format)
        {
            string output = string.Format("Type: V2MainCollection\n");
            foreach (V2Data item in Collection)
            {
                output += item.ToLongString(format);
            }
            return output;
        }

        override public string ToString()
        {
            string output = string.Format("Type: V2MainCollection\n");
            foreach (V2Data item in Collection)
            {
                output += item.ToString();
            }
            return output;
        }
    }
}
