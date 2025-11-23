using System;

namespace check.Models
{
    public class SearchWeatherData
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public string Periodicity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set;}
    }
}
