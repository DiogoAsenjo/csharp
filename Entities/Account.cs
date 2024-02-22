using System;

namespace PrimeiroProjeto.Entities
{
    class Account
    {
        public int Id { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
        public List<Transaction> Transactions { get; set;}
        public double ExpensesUser1 { get; private set; }
        public double ExpensesUser2 { get; private set; }
        public string Balance { get; private set;}

        public Account(int id, User user1, User user2)
        {
            Id = id;
            User1 = user1;
            User2 = user2;
            Transactions = new List<Transaction>();
        }

        public void newTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
            if (transaction.UserWhoPaid.Name == User1.Name)
            {
                ExpensesUser1 += transaction.Value;
            }
            else if (transaction.UserWhoPaid.Name == User2.Name)
            {
                ExpensesUser2 += transaction.Value;
            }

            if (ExpensesUser1 > ExpensesUser2)
            {
                double difference = ExpensesUser1 - ExpensesUser2;
                double debt = difference / 2.00;
                Balance =  $"{User2.Name} deve {debt} para {User1.Name}";
            }
            else if (ExpensesUser2 > ExpensesUser1)
            {
                double difference = ExpensesUser2 - ExpensesUser1;
                double debt = difference / 2.00;
                Balance = $"{User1.Name} deve {debt} para {User2.Name}";
            }
            else
            {
                Balance = $"Ninguém deve para ninguém";
            }
        }


        public override string ToString()
        {
            return $"Conta: {Id}, Pessoas: {User1.Name}, {User2.Name}, Balanço: {Balance}";
        }
    }
}