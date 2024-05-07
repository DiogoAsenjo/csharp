namespace PrimeiroProjeto.Entities
{
    public class CarRental
    {
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public Vehicle Vehicle { get; set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime end, Vehicle vehicle)
        {
            Start = start;
            End = end;
            Vehicle = vehicle;
        }

        public override string ToString()
        {
            return $"Vehicle: {Vehicle}, Rent starts in {Start.ToString("dd/MM/yyyy")} and finish on {End.ToString("dd/MM/yyyy")}";
        }
    
    }
}