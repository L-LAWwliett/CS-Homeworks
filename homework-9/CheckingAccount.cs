using System;

public class CheckingAccount : BankAccount
{
    public CheckingAccount(string accountNumber, decimal initialBalance)
        : base(accountNumber, initialBalance) { }

    public override void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");

        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");

        Balance -= amount;
    }
}
