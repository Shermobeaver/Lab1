using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    // V2DataArray
    class V2DataArray : V2Data
    {
        // Array Data
        public System.Numerics.Complex[,] Contents { get; }
        public System.Numerics.Vector2 Step { get; }
        public int OxCount { get; }
        public int OyCount { get; }

        // Constructors
        public V2DataArray(string instr, DateTime intime) : base(instr, intime)
        {
            System.Numerics.Complex[,] dataItems = new System.Numerics.Complex[0, 0];
            Contents = dataItems;
        }

        public V2DataArray(string instr, DateTime intime, int inOxCount, int inOyCount, System.Numerics.Vector2 inStep, Fv2Complex F) : base(instr, intime)
        {
            OxCount = inOxCount;
            OyCount = inOyCount;
            System.Numerics.Complex[,] dataItems = new System.Numerics.Complex[inOxCount, inOyCount];
            Contents = dataItems;
            Step = inStep;
            for (int i = 0; i < OxCount; i++)
            {
                for (int j = 0; j < OyCount; j++)
                {
                    Contents[i, j] = F(Step);
                }
            }
        }

        // Properties
        public override int Count
        {
            get
            {
                return OxCount * OyCount;
            }
        }

        public override float MinDistance
        {
            get
            {
                if (Step.X > Step.Y)
                {
                    return Step.Y;
                }
                else
                {
                    return Step.X;
                }
            }
        }

        // Output
        override public string ToLongString(string format)
        {
            string output = string.Format($"Type: V2DataArray, Characteristics: {Str},  Date/Time: {DateAndTime}, Step: {Step.ToString((format))}, Ox: {OxCount}, Oy: {OyCount}\n");
            for (int i = 0; i < OxCount; i++)
            {
                for (int j = 0; j < OyCount; j++)
                {
                    output += string.Format($"DataItem Contents: Coords: {i * Step.X} {j * Step.Y},  Value: {Contents[i, j].ToString((format))}, Module: {(Contents[i, j].Magnitude).ToString((format))}\n");
                }
            }
            return output;
        }

        override public string ToString()
        {
            return string.Format($"Type: V2DataArray, Characteristics: {Str},  Date/Time: {DateAndTime}, Step: {Step}, Ox: {OxCount}, Oy: {OyCount}\n");
        }

        // Converter
        public static implicit operator V2DataList(V2DataArray Old)
        {
            V2DataList newlist = new("List From" + Old.Str, DateTime.Now);
            for (int i = 0; i < Old.OxCount; i++)
            {
                for (int j = 0; j < Old.OyCount; j++)
                {
                    System.Numerics.Vector2 vector_1 = new(i * Old.Step.X, j * Old.Step.Y);
                    DataItem item1 = new(vector_1, Old.Contents[i, j]);
                    newlist.Add(item1);
                }
            }
            return newlist;
        }
    }
}
