using System;
using System.Collections.Generic;

namespace TwilightImperium
{
    class MainClass
    {
        LoadFile load = new LoadFile();
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Test!");
        }

        public bool Heyhey(string s)
        {
            return load.CheckWhichIfUnits(s);
        }
        void Iest(string s)
        {
            List<string[]> l = load.LoadedLines(s);
            l.ForEach(Console.WriteLine);
        }
    }
}
