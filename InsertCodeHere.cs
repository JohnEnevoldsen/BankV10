﻿using System;

namespace BankV10
{
    public class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            BankAccount account = new BankAccount();
            Console.WriteLine($"Balance is {account.Balance}");

            account.Deposit(1000);
            Console.WriteLine($"Balance is {account.Balance}");
            account.Withdraw(-1100);
            Console.WriteLine($"Balance is {account.Balance}");
            account.Deposit(-69);
            Console.WriteLine($"Balance is {account.Balance}");
            account.Withdraw(200);
            Console.WriteLine($"Balance is {account.Balance}");
            account.Withdraw(1100);
            Console.WriteLine($"Balance is {account.Balance}");

            // The LAST line of code should be ABOVE this line
        }
    }
}