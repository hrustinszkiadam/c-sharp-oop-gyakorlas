using System;
using System.Collections.Generic;
using System.Configuration.Assemblies;
using System.Linq;
using System.Threading.Tasks;

namespace oop
{
   class BankAccount
   {
      public string ownerName;
      public decimal balance;
      public string accountNumber;
      public string accountType;
      public DateTime accountOpeningDate;
      public bool isAccountActive;

      public BankAccount(string name, decimal balance, string accountNumber, string accountType, string accountOpeningDate)
      {
         this.ownerName = name;
         this.balance = balance;
         this.accountNumber = accountNumber;
         this.accountType = accountType;
         string[] date = accountOpeningDate.Split(accountOpeningDate[4]);
         this.accountOpeningDate = new DateTime(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));
         this.isAccountActive = true;
      }


      public void PrintAccountInfo()
      {
         Console.WriteLine("Account Owner Name: " + this.ownerName);
         Console.WriteLine("Account Balance: " + this.balance);
         Console.WriteLine("Account Number: " + this.accountNumber);
         Console.WriteLine("Account Type: " + this.accountType);
         Console.WriteLine("Account Opening Date: " + this.accountOpeningDate.ToShortDateString());
         Console.WriteLine("Account Active: " + (this.isAccountActive ? "Active" : "Inactive"));
         Console.WriteLine();
      }

      public void CloseAccount()
      {
         this.isAccountActive = false;
      }

      public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
      {
         if (this.balance >= amount)
         {
            this.balance -= amount;
            destinationAccount.balance += amount;
            Console.WriteLine($"Transfer for {amount} successful from {this.ownerName}'s to {destinationAccount.ownerName}'s account.\n");
         }
         else
         {
            Console.WriteLine($"Insufficient funds to transfer {amount} from {this.ownerName}'s to {destinationAccount.ownerName}'s account.\n");
         }
      }

      public void UpdateAccountType(string newAccountType)
      {
         this.accountType = newAccountType;
      }
   }
}