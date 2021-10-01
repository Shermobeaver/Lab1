using System;
using System.Collections.Generic;

namespace Lab_1
{
    // Program
    class Program
    {
        static void Main()
        {
            //System.Numerics.Vector2 vector_1 = new(1, 1);
            //V2DataArray array = new ("Array", DateTime.Now, 4, 10, vector_1, FuncV2Complex.FuncV2Complex_1);
            System.Numerics.Vector2 vector_1 = new(0.5f, 0.01f);
            V2DataArray array = new("Array", DateTime.Now, 3, 2, vector_1, FuncV2Complex.FuncV2Complex_1);
          
            Console.WriteLine("--- Array ---\n\n");
            Console.WriteLine(array.ToLongString("F4"));
            Console.WriteLine("------------------------\n\n");
            V2DataList list_copy = array;
            Console.WriteLine("--- Array copy as a list ---\n\n");
            Console.WriteLine(list_copy.ToLongString("F4"));
            Console.WriteLine("------------------------\n\n");
            Console.WriteLine("--- Array Count() & MinDistance() ---\n\n");
            Console.WriteLine($"{array.Count}, {array.MinDistance}\n");
            Console.WriteLine("------------------------\n\n");
            Console.WriteLine("--- Array copy as a list Count() & MinDistance() ---\n\n");
            Console.WriteLine($"{list_copy.Count}, {list_copy.MinDistance}\n");
            Console.WriteLine("------------------------\n\n");
            
            V2MainCollection Collection = new();
            V2DataArray array_2 = new("Array_1", DateTime.Now, 2, 1, vector_1, FuncV2Complex.FuncV2Complex_1);
            //V2DataArray array_2 = new("Array_1", DateTime.Now, 4, 10, vector_1, FuncV2Complex.FuncV2Complex_1);
            V2DataList list_1 = new("List 1", DateTime.Now);
            
            //list_1.AddDefaults(10, FuncV2Complex.FuncV2Complex_1);
            list_1.AddDefaults(4, FuncV2Complex.FuncV2Complex_1);
            Collection.Add(array);
           // Collection.Add(list_copy);
            Collection.Add(new V2DataList("Empty V2DataList", new DateTime()));
            Collection.Add(array_2);
            Collection.Add(list_1);
            Collection.Add(new V2DataArray("Empty V2DataArray", new DateTime()));
            Console.WriteLine("--- Collection ---\n\n");
            Console.WriteLine(Collection.ToLongString("F4"));
            Console.WriteLine("------------------------\n\n");
            Console.WriteLine("--- Pairs Count() & MinDistance() for each Collection Element ---\n\n");
           // for (int i = 0; i < 4; i++)
           for (int i = 0; i < Collection.Count; i++)
           {
                Console.WriteLine($"{Collection[i].Count}, {Collection[i].MinDistance}\n");
            }
            Console.WriteLine("------------------------\n\n");
        }
    }
}
