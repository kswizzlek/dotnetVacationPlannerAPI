using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class TripAccommodationActivityVote
    {
        public Guid PersonGuid { get; set; }
        public Guid TripAccommidationActivityGuid { get; set; }
        public bool Likes { get; set; }
    }
}
