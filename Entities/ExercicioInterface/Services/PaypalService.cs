namespace PrimeiroProjeto.Entities.ExercicioInterface.Services
{
    public class PaypalService : IOnlinePaymentService
    {
        private const double FeePercentage = 0.02;
        private const double MonthlyInterest = 0.01;

        public double Fee(double amount)
        {
            return amount * FeePercentage;
        }

        public double Interest(double amount, int months)
        {
            return amount * MonthlyInterest * months;
        }
    }
}