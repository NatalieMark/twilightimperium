using System;
using System.Collections.Generic;

namespace TwilightImperium
{
    public class System
    {
        bool _isOnOuterRim;
        int _iD;
        int _planetsQTY; //quantity of planets
        Planet[] _planet;
        Location[] _locations;
        List<Neighbour> _neighbours;
        List<Unit> _unit;

        public System(int iD, int planetsQTY)
        {
            ID = iD;
            PlanetsQTY = planetsQTY;
        }

        public bool IsOnOuterRim
        {
            get { return _isOnOuterRim; }
            set { _isOnOuterRim = value; }
        }

        public int ID
        {
            get { return _iD; }
            set
            {
                if (value >= 0)
                {
                    _iD = value;
                }
            }
        }

        public int PlanetsQTY
        {
            get { return _planetsQTY; }
            set
            {
                if (QTYIsValid(value))
                {
                    _planetsQTY = value;
                }
            }
        }

        public Planet[] PlanetGet
        {
            get { return _planet; }
        }

        public Location[] Locations
        {
            get { return _locations; }    
        }

        public List<Neighbour> Neighbours
        {
            get { return _neighbours; }
        }

        public List<Unit> Units
        {
            get { return _unit; }
        }

        bool QTYIsValid(int qty)
        {
            return (qty >= 0 /*&& qty < playersplaying*/);
        }

        public void AddNeighbour(int locationOnCurrSystem, System newNeighbour)
        {
            Neighbour n = new Neighbour(locationOnCurrSystem, newNeighbour);
            Neighbours.Add(n);
        }

        public void AddPlanet(Planet newPlanet, int index)
        {
            _planet[index] = newPlanet;
        }

        public void AddUnit(Unit newUnit)
        {
            _unit.Add(newUnit);
        }

        public void RemoveUnit(Unit removeUnit)
        {
            _unit.Remove(removeUnit);
        }

        public void CurrTotalUnits()
        {
            
        }

        public void CurrTotal()
        {
            
        }
    }
}
