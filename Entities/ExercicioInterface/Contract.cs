namespace PrimeiroProjeto.Entities.ExercicioInterface
{
    public class Contract
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments{ get; set; }

        public Contract(int id, DateTime startDate, double totalValue)
        {
            Id = id;
            StartDate = startDate;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void addInstallments(Installment installment)
        {
            Installments.Add(installment);
        }
        
        public override string ToString()
        {
            return $"Id: {Id}, Date: {StartDate.ToString("dd/MM/yyyy")}, Total Value: {TotalValue}";
        }
    }
}