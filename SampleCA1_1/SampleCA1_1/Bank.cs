using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleCA1_1
{
    public abstract class BankAccount: Object
    {
        private string accountNumber;
        private double balance;

        public BankAccount(string accountNumber)
        {
            this.accountNumber = accountNumber;
            this.balance = 0;
        }

        public string AccountNumber
        {
            get
            {
                return this.accountNumber;
            }
        }

        public double Balance
        {
            get
            {
                return balance;
            }
            set
            {
                this.balance = value;
            }
        }

        public abstract void MakeDeposit(double amount);

        public abstract void MakeWithdrawal(double amount);

    }

    public class CurrentAccount : BankAccount
    {
        private double overdraftLimit;

        private AccountTransaction[] transactions;

        private int transactionCount;

        public CurrentAccount(string accountNumber, double overdraftLimit): base(accountNumber)
        {
            this.overdraftLimit = overdraftLimit;
            transactions = new AccountTransaction[100];
            transactionCount = 0;
        }

        public double OverdraftLimit
        {
            get
            {
                return this.overdraftLimit;
            }
        }

        public override void MakeDeposit(double amount)
        {
            this.Balance += amount;
            transactions[transactionCount] = new AccountTransaction(TransactionType.Deposit, amount);
            transactionCount++;
        }

        public override void MakeWithdrawal(double amount)
        {
            try
            {
                if (amount > this.Balance)
                {
                    throw new ArgumentException();
                }
                else
                {
                    this.Balance -= amount;
                    transactions[transactionCount] = new AccountTransaction(TransactionType.Withdrawal, amount);
                    transactionCount++;
                }
            }
            catch (ArgumentException){
                Console.WriteLine("Insufficient funds");
            }
        }

        public override string ToString()
        {
            StringBuilder transSB = new StringBuilder();
            transSB.Append(string.Format("Account Number: {0}\nBalance: {1}\nOverdraft Limit: {2}\n",
                this.AccountNumber, this.Balance, this.OverdraftLimit));
            //transSB.Append(string.Join("\n", transactions.Select(x => x.ToString())));
            for (int i = 0; i < transactionCount; i++)
            {
                transSB.Append(transactions[i].ToString() + "\n");
            }
                return transSB.ToString();
        }
    }

    public enum TransactionType
    {
        Deposit, Withdrawal
    }

    // an account transaction
    public class AccountTransaction
    {
        private TransactionType type;		// deposit/withdrawal
        private double amount;			// amount concerned

        // constructor
        public AccountTransaction(TransactionType type, double amount)
        {
            this.type = type;
            this.amount = amount;
        }

        // return human readable String
        public override String ToString()
        {
            return "type: " + type + " amount: " + amount;
        }
    }
}
