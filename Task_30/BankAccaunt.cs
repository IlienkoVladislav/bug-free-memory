using System;

public class BankAccount
{
    private string accountNumber;
    private decimal balance;

    public BankAccount(string accountNumber, decimal initialBalance)
    {
        this.accountNumber = accountNumber;
        this.balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        balance += amount;
        Logger.Instance.Log($"Deposited {amount:C}. New balance: {balance:C}");
    }

    public void Withdraw(decimal amount)
    {
        if (amount > balance)
        {
            throw new InvalidOperationException("Insufficient funds");
        }

        balance -= amount;
        Logger.Instance.Log($"Withdrawn {amount:C}. New balance: {balance:C}");
    }

    public decimal GetBalance()
    {
        return balance;
    }
}
