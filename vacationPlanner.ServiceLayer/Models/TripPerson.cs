using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class TripPerson
    {
        public Guid TripGuid { get; set; }
        public Guid PersonGuid { get; set; }
    }
}
