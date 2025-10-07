using System;

public class TransactionService
{
    public void Transfer(BankAccount from, BankAccount to, decimal amount)
    {
        if (amount <= 0)
            throw new ArgumentException("Transfer amount must be positive.");

        try
        {
            from.Withdraw(amount);
            to.Deposit(amount);
            Console.WriteLine($"Transfer of {amount:C} from {from.AccountNumber} to {to.AccountNumber} successful.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Transfer failed: {ex.Message}"); 
            throw;
        }
    }
}
