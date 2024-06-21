using System;

public class Program
{
    public static void Main(string[] args)
    {
        BankAccount account = new BankAccount("12345", 1000); 

        account.Deposit(500);
        account.Withdraw(200);

        Console.WriteLine($"Current balance: {account.GetBalance():C}");

    }
}
