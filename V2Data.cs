using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    // V2Data - abstract
    abstract class V2Data
    {
        // LogData
        public string Str { get; }
        public DateTime DateAndTime { get; }

        // Constructor
        public V2Data(string instr, DateTime intime)
        {
            Str = instr;
            DateAndTime = intime;
        }

        // Properties
        abstract public int Count
        {
            get;
        }

        abstract public float MinDistance
        {
            get;
        }

        // Output
        abstract public string ToLongString(string format);

        abstract override public string ToString();
    }
}
