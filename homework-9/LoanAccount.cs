using System;

public class LoanAccount : BankAccount
{
    public LoanAccount(string accountNumber, decimal initialLoan)
        : base(accountNumber, initialLoan) { }

    public override void Withdraw(decimal amount)
    {
        throw new InvalidOperationException("Withdrawals are not allowed from a loan account.");
    }

    public override void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Payment amount must be positive.");

        Balance -= amount; 
        Console.WriteLine($"Payment of {amount:C} applied to loan account {AccountNumber}.");
    }
}
