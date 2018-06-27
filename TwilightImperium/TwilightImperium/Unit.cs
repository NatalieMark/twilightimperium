using System;
namespace TwilightImperium
{
    public class Unit
    {
        int _type, 
            _resourceCost, 
            _compatValue, 
            _ovementSpeed, 
            _capacity;
        Player _player;

        public Unit(int type, int resourceCost, int compatValue, int ovementSpeed, int capacity, Player player)
        {
        }

        public int Type
        {
            get { return _type; }
            set
            {
                if (TypeIsValid(value))
                {
                    _type = value;
                }
            }
        }

        public bool TypeIsValid(int givenType)
        {   //unit can be 4 different types
            return (givenType >= 0 && givenType <= 3);
        }
    }
}
