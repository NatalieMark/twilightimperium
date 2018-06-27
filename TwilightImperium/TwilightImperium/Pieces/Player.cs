using System;
namespace TwilightImperium
{
    public class Player
    {
        string _name;
        int _color,
            _race,
            _iD = 0;

        public Player(string name, int color, int race)
        {
            ID = _iD++;
            Name = name;
            Color = color;
            Race = race;
        }

        public int ID { get; }

        public string Name
        {
            get { return _name; }
            set 
            {
                if (NameIsValid(value))
                {
                    _name = value;
                }
            }
        }

        public int Color
        {
            get { return _color; }
            set
            {
                if (ColorOrRaceIsValid(value))
                {
                    _color = value;
                }
            }
        }

        public int Race
        {
            get { return _race; }
            set
            {
                if (ColorOrRaceIsValid(value))
                {
                    _race = value;
                }
            }
        }

        public bool NameIsValid(string givenName)
        {   //name contains between 3 and 15 characters
            return (givenName.Length >= 3 && givenName.Length <= 15);
        }

        public bool ColorOrRaceIsValid(int givenValue)
        {   //red=0, green=1, blue=2, yellow=3, white=4, black=5, and race is also from 0-5
            return (givenValue >= 0 && givenValue <= 5);
        }
    }
}
