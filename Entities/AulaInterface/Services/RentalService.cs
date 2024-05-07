using PrimeiroProjeto.Entities.AulaInterface;
using PrimeiroProjeto.Entities.AulaInterface.Services;

namespace PrimeiroProjeto.Entities
{
    public class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }
        private ITaxService _taxService;

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService)
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }
        
        

        public void ProcessInvoice(CarRental carRental)
        {
            TimeSpan duration = carRental.End.Subtract(carRental.Start);
            double basicPayment = 0.00;

            if (duration.TotalHours <= 12.00)
            {
                basicPayment =  Math.Ceiling(duration.TotalHours) * PricePerHour;
            } else
            {
                basicPayment = Math.Ceiling(duration.TotalDays) * PricePerDay;
            }

            double tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);
        }
    }
}