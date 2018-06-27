using System;
namespace TwilightImperium
{
    public class Planet
    {
        int _name, 
            _resourceProduction;

        public Planet(int name, int resourceProduction)
        {
        }

        public int Name
        {
            get { return _name; }
            set
            {
                if (value >= 0)
                {
                    _name = value;
                }
            }
        }

        public int ResourceProduction
        {
            get { return _resourceProduction; }
            set
            {
                if (ResourceIsValid(value))
                {
                    _resourceProduction = value;
                }
            }
        }

        public bool ResourceIsValid(int resources)
        {   //Resources can be from 0-6
            return (resources >= 0 && resources <= 6);
        }
    }
}

//int name, int resourceProduction
//name is represented as numbers