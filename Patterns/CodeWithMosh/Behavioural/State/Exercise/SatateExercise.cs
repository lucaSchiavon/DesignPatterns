using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.State.Exercise
{
    public enum TravelMode
    {
        DRIVING,
        BICYCLING,
        TRANSIT,
        WALKING
    }

    public class DirectionService :ITravel
    {
        //private TravelMode travelMode;

        private ITravel _directionService { get; }

        public DirectionService(ITravel directionService)
        {
            _directionService = directionService;
        }

        public Object getEta()
        {
          return  _directionService.getEta();
        }

        public Object getDirection()
        {
            return _directionService.getDirection();
        }

        //public TravelMode getTravelMode()
        //{
        //    return travelMode;
        //}

        //public void setTravelMode(TravelMode travelMode)
        //{
        //    this.travelMode = travelMode;
        //}
    }


}
