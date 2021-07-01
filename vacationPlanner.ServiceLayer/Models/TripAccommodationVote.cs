using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class TripAccomodationVote
    {
        public Guid PersonGuid { get; set; }
        public Guid TripAccommodationGuid { get; set; }
        public bool Likes { get; set; }
    }
}
