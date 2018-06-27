using System;
namespace TwilightImperium
{
    public class Unit
    {
        int _type, 
            _resourceCost, 
            _compatValue, 
            _movementSpeed, 
            _capacity;
        Player _player;

        public Unit(int type, int resourceCost, int compatValue, int movementSpeed, int capacity, Player player)
        {
            _type = type;
            _resourceCost = resourceCost;
            _compatValue = compatValue;
            _movementSpeed = movementSpeed;
            _compatValue = compatValue;
            _capacity = capacity;
            _player = player;
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

        public int ResourceCost
        {
            get { return _resourceCost; }
            set
            {
                if (ResourceIsValid(value))
                {
                    _resourceCost = value;
                }
            }
        }

        public int CompatValue
        {
            get { return _compatValue; }
            set
            {
                if (TypeIsValid(value))
                {
                    _compatValue = value;
                }
            }
        }

        public int MovementSpeed
        {
            get { return _movementSpeed; }
            set
            {
                if (MovementIsValid(value))
                {
                    _movementSpeed = value;
                }
            }
        }

        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (_type == 2 && value == 6) //type#2 = Carrier, the only unit to have capacity
                {
                    _capacity = value;
                }
                else
                    _capacity = 0;
            }
        }

        public Player Player
        {
            get { return _player; }
            set
            {
                if (value != null)
                {
                    _player = value;
                }
            }
        }

        public bool TypeIsValid(int givenType)
        {   //unit can be 4 different types
            return (givenType >= 0 && givenType < 4);
        }

        public bool ResourceIsValid(int givenValue)
        {
            return (givenValue > 0 && givenValue < 6);
        }

        public bool CompatIsValid(int givenValue)
        {
            return (givenValue > 4 && givenValue < 10);
        }

        public bool MovementIsValid(int givenValue)
        {
            return (givenValue > 0 && givenValue < 3);
        }
    }
}
