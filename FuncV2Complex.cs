using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1
{
    // Methods delegate
    public delegate System.Numerics.Complex Fv2Complex(System.Numerics.Vector2 v2);

    // Static class full of Methods
    static class FuncV2Complex
    {
        public static System.Numerics.Complex FuncV2Complex_1(System.Numerics.Vector2 v2)
        {
            Random randObj = new Random();
            return v2.X * v2.Y * 0.00001 * (double)randObj.Next();
        }
    }
}
