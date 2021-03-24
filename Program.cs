using System;
using System.Collections.Generic;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Collections.Generic.Dictionary<int, string> MyDictionary = new System.Collections.Generic.Dictionary<int, string>();
            MyDictionary.Add(01, "C#");
            MyDictionary.Add(02, "Java");
            MyDictionary.Add(03, "Python");
            MyDictionary.Add(04, "Angular");
            Console.WriteLine(MyDictionary.Count);
        }
    }
}
