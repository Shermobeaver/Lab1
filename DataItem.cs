using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    // DataItem
    struct DataItem
    {
        // Data
        public System.Numerics.Vector2 Coords { get; set; }
        public System.Numerics.Complex Value { get; set; }

        // Constructor
        public DataItem(System.Numerics.Vector2 inCoords, System.Numerics.Complex inValue)
        {
            Coords = inCoords;
            Value = inValue;
        }

        // Output
        public string ToLongString(string format)
        {
            return string.Format($"Coords: {Coords.ToString((format))},  Value: {Value.ToString((format))}, Module: {(Value.Magnitude).ToString((format))}\n");
        }

        override public string ToString()
        {
            return string.Format($"Coords: {Coords},  Value: {Value}, Module: {Value.Magnitude}\n");
        }
    }
}
