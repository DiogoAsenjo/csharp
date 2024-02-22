using System;

namespace PrimeiroProjeto.Entities
{
    class Account
    {
        public int Id { get; set; }
        public User User1 { get; set; }
        public User User2 { get; set; }
        public List<Transaction> Transactions { get; set;}
        public double BalanceUser1 { get; private set; }
        public double BalanceUser2 { get; private set; }
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
                BalanceUser1 += transaction.Value;
            }
            else if (transaction.UserWhoPaid.Name == User2.Name)
            {
                BalanceUser2 += transaction.Value;
            }




        }

        public string seeingWhoOwnsWho()
        {
            if (BalanceUser1 > BalanceUser2)
            {
                double difference = BalanceUser1 - BalanceUser2;
                double debt = difference / 2.00;
                return $"{User2.Name} deve {debt} para {User1.Name}";
            }
            else if (BalanceUser2 > BalanceUser1)
            {
                double difference = BalanceUser2 - BalanceUser1;
                double debt = difference / 2.00;
                return $"{User1.Name} deve {debt} para {User2.Name}";
            }
            else
            {
                return $"Ninguém deve para ninguém";
            }
        }

        public override string ToString()
        {
            return $"Conta: {Id}, Pessoas: {User1.Name}, {User2.Name}, Balanço: {Balance}";
        }
    }
}