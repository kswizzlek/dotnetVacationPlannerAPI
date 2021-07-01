using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class TripAccommodationActivity
    {
        public Guid TripAccommodationActivityGuid { get; set; }
        public Guid TripAccommodationGuid { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Link { get; set; }
    }
}
