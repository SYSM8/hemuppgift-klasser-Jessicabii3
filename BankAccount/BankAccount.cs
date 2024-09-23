using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    internal class PersonalBankAccount
    {
        public string AccountNumber { get; private set; }
        public string AccountHolder { get; private set; }
        public decimal Balance { get; private set; }

        public PersonalBankAccount(string accountNumber, string accountHolder, decimal initialBalance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = initialBalance;
        }
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                Balance = amount + Balance;
                Console.WriteLine($"Insättningsbeloppet är: {amount} kr. Nuvarande saldo: {Balance} kr");
            }
            else
            {
                Console.WriteLine("Insättnigsbeloppet måste vara större än noll");
            }
        }
        public decimal Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance = Balance - amount;
                Console.WriteLine($"Uttag på {amount} kr genomfört. Nuvarande {Balance} kr");
                return Balance;
            }
            else
            {
                Console.WriteLine("Otillräckligt saldo");
                return Balance;
            }
        }
        public void DisplayBalance()
        {
            Console.WriteLine($"Nuvarande saldo {Balance} kr.");
        }
    }
}
