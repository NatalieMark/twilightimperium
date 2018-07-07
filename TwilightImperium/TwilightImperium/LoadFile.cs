using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace TwilightImperium
{
    public class LoadFile
    {
        string _filename;

        public LoadFile(string fileName)
        {
            FileName = fileName;
        }

        public string FileName
        {
            get { return _filename; }
            set 
            {
                if (NameIsValid(value))
                {
                    _filename = value;
                }
            }
        }

        public List<string[]> LoadedLines() //filname can only be units, plantes or races
        {
            string fileName = _filename + ".txt";
            StreamReader file = new StreamReader(fileName);
            string Header = file.ReadLine();
      
            if (_filename == Header) //example, fileName = units, then Header will be the first line in the units.rtf file, which is units.
            {   
                List<string[]> listOfLines = new List<string[]>();
                string line;

                while ((line = file.ReadLine()) != null)
                    listOfLines.Add(line.Split(';'));
                
                return listOfLines;
            }
            else
                throw new Exception("The file Is not the correct one!!! Check mistakes");
        }

        bool NameIsValid(string givenName)
        {
            return (givenName == "units" || givenName == "planets" || givenName == "races");
        }
        
        /*
        public bool CheckWhichIfUnits(string fileName)
        {
            Console.WriteLine(fileName+".rtf");
            if (fileName + ".rtf" == "units.rtf")
                return true;
            else
                return false;
        }

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
