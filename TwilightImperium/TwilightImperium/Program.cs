using System;
using System.Collections.Generic;

namespace TwilightImperium
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello Test!");
            LoadFile unitsFile = new LoadFile("units");
            List<string[]> Lo = unitsFile.LoadedLines();
            Lo.ForEach(Console.WriteLine);
        }
    }
}
