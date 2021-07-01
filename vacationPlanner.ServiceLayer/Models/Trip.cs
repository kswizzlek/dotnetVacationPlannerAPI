using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class Trip
    {
        public Guid TripGuid { get; set; }
        public string TripName { get; set; }
        public Guid AdminPersonGuid { get; set; }
    }
}
