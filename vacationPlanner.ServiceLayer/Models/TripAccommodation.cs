using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class TripAccommodation
    {
        public Guid TripAccommodationGuid { get; set; }
        public Guid TripGuid { get; set; }
        public string Name { get; set; }
        public string Link { get; set; }
        public string Description { get; set; }
        public bool IsFinal { get; set; }
    }
}
