namespace PrimeiroProjeto.Entities.ExercicioInterface.Services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }
        public void processContract(Contract contract, int months)
        {
            double quota = contract.TotalValue / months;

            for (int i = 0; i < months; i++)
            {
                DateTime nextPaymentDate = contract.StartDate.AddMonths(i);
                double updatedQuota = quota + _onlinePaymentService.Interest(quota, i);
                double fullQuota =  updatedQuota + _onlinePaymentService.Fee(updatedQuota);
                Installment newInstallment = new Installment(nextPaymentDate, fullQuota);
                contract.addInstallments(newInstallment);
            }
        }
    }
}