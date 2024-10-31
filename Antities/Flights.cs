namespace AIRPORTS.Antities
{
    public class Flights
    {
        public int flightId { get; set; }
        public int airplanId { get; set; }
        public bool status { get; set; }
        public TimeOnly takingTime { get; set; }
        public TimeOnly landTime { get; set; }

    }
}
