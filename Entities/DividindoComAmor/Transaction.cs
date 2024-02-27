using System;

namespace PrimeiroProjeto.Entities
{
    class Transaction
    {
        public int Id { get; set; }
        public double Value { get; set; }
        public User UserWhoPaid { get; set; }
        public Account AssociatedAccount { get; set; }

        public Transaction(int id, double value, User user, Account account)
        {
            Id = id;
            Value = value;
            UserWhoPaid = user;
            AssociatedAccount = account;

            account.newTransaction(this);
        }

        public override string ToString()
        {
            return $"{UserWhoPaid.Name}, pagou {Value}, referente a conta: {AssociatedAccount.Id}";
        }
    }
}