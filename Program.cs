using PrimeiroProjeto.Entities;
using PrimeiroProjeto.Entities.AulaInterface.Services;

namespace PrimeiroProjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vehicle first = new Vehicle("UNO");
            Console.WriteLine(first);
            DateTime start = new DateTime(2024, 05, 07, 10, 00, 00);
            DateTime end = new DateTime(2024, 05, 08, 11, 00, 00);

            CarRental carRental = new CarRental(start, end, first);
            Console.WriteLine(carRental);

            RentalService rentalService= new RentalService(1.00, 10.00, new BrazilTaxService());
            rentalService.ProcessInvoice(carRental);

            Console.WriteLine(carRental.Invoice);
        }
    }
}