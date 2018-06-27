using System;
namespace TwilightImperium
{
    public class Location
    {
        int _iD;
        bool _hasNeighbour;
        bool _isOnRim;

        public Location(int iD, bool hasNeighbour, bool isOnRim)
        {
            ID = iD;
            HasNeighbour = hasNeighbour;

        }

        public int ID
        {
            get { return _iD; }
            set 
            { 
                if(IDIsValid(value))
                {
                    _iD = value; 
                }
            }
        }

        public bool HasNeighbour
        {
            get { return _hasNeighbour; }
            set { _hasNeighbour = value; }
        }

        public bool IsOnRim
        {
            get { return _isOnRim; }
            set { _isOnRim = value; }
        }

        bool IDIsValid(int iD)
        {
            return (iD >= 0 && iD < 7);
        }
    }
}
