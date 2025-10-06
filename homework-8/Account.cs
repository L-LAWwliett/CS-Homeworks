using System;

public class Account
{
    private string accountNumber;
    private string currency;
    private decimal balance;

    public string AccountNumber
    {
        get => accountNumber;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 22)
                throw new ArgumentException("Account number must be exactly 22 digits.");
            accountNumber = value;
        }
    }

    public string Currency
    {
        get => currency;
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length != 3)
                throw new ArgumentException("Currency must be a 3-letter code.");
            currency = value.ToUpper();
        }
    }

    public decimal Balance
    {
        get => balance;
        private set
        {
            if (value < 0)
                throw new ArgumentException("Balance cannot be negative.");
            balance = value;
        }
    }

    public Account(string accountNumber, string currency, decimal balance)
    {
        AccountNumber = accountNumber;
        Currency = currency;
        Balance = balance;
    }

    public void Deposit(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Deposit amount must be positive.");
        Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Withdrawal amount must be positive.");
        if (amount > Balance)
            throw new InvalidOperationException("Insufficient funds.");
        Balance -= amount;
    }

    public void Transfer(Account target, decimal amount)
    {
        if (target == null)
            throw new ArgumentNullException("Target account cannot be null.");
        Withdraw(amount);
        target.Deposit(amount);
    }

    public void DisplayAccount()
    {
        Console.WriteLine($"Account: {AccountNumber}, Balance: {Balance} {Currency}");
    }
}
