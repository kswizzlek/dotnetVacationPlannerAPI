using System;
namespace vacationPlanner.ServiceLayer.Models
{
    public class TripDate
    {
        public Guid PersonGuid { get; set; }
        public Guid TripGuid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public TrioDateMode TrioDateMode { get; set; }
    }

    public enum TrioDateMode
    {
        Available,
        Flexible,
        Unavailable
    }
}
