using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TwilightImperium
{
    public class LoadFile
    {
        string _filename;

        public List<string[]> LoadedLines(string fileName) //filname can only be units, plantes or races
        {
            StreamReader file = new StreamReader(fileName + ".rtf");
            string Header = file.ReadLine();
            
            if (fileName == Header) //example, fileName = units, then Header will be the first line in the units.rtf file, which is units.
            {
                List<string[]> listOfLines = new List<string[]>();
                string line;

                while ((line = file.ReadLine()) != null)
                {
                    listOfLines.Add(line.Split(';'));
                }
                return listOfLines;
            }
            else
                throw new Exception("The file Is not the correct one!!! Check mistakes");
        }
        public bool CheckWhichIfUnits(string fileName)
        {
            if (fileName + ".rtf" == "units.rtf")
                return true;
            else
                return false;
        }

        /*
        bool CheckWhichIfPlanets(string fileName)
        {
            if (fileName == "planets.rtf")
                return true;
            else
                return false;
        }

        bool CheckWhichIfRaces(string fileName)
        {
            if (fileName == "Races.rtf")
                return true;
            else
                return false;
        }
        */
    }
}
