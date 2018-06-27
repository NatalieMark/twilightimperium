using System;
namespace TwilightImperium
{
    public class Neighbour
    {
        int _location;
        System _newNeighbour;

        public Neighbour(int location, System newNeighbour)
        {
            
        }

        public int Location
        {
            get { return _location; }
            set
            {
                if (LocationIsValid(value)) //type#2 = Carrier, the only unit to have capacity
                {
                    _location = value;
                }
            }
        }

        public System NewNeighbor
        {
            get { return _newNeighbour; }
            set
            {
                if (value != null)
                {
                    _newNeighbour = value;
                }
            }
        }

        bool LocationIsValid(int locationID)
        {
            return (locationID >= 0 && locationID < 6);
        }

        bool NeighborIsValid(System newNeighbour)
        {
            ///Checking if newneighbor does not have a neighbor at x + newneigbor = 5
            foreach(Neighbour n in newNeighbour.Neighbours)
            {
                if (!(Location + n.Location == 5))
                    return true;
            }
            return false;
        }
    }
}
