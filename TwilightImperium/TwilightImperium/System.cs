using System;
using System.Collections.Generic;

namespace TwilightImperium
{
    public class System
    {
        bool _isOnOuterRim;
        int _iD;
        int _planetsQTY; //quantity of planets
        List<Neighbour> _neighbours;
        Planet _planet;

        public System()
        {
            
        }

        public List<Neighbour> Neighbours
        {
            get { return _neighbours; }
        }

        public void AddNeighbour(int locationOnCurrSystem, System newNeighbour)
        {
            Neighbour n = new Neighbour(locationOnCurrSystem, newNeighbour);
            Neighbours.Add(n);
        }
    }
}
