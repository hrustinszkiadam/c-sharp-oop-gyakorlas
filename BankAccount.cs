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
         if(this.isAccountActive)
         {
            this.isAccountActive = false;
            Console.WriteLine($"Successfully closed {this.ownerName}'s account.\n");
         } else
         {
            Console.WriteLine($"Account is already closed. Cannot close {this.ownerName}'s account.\n");
         }
      }

      public void TransferFundsTo(BankAccount destinationAccount, decimal amount)
      {
         if(this.isAccountActive)
         {
            if(destinationAccount.isAccountActive)
            {
               if(this.balance >= amount)
               {
                  this.balance -= amount;
                  destinationAccount.balance += amount;
                  Console.WriteLine($"Successfully transferred {amount} from {this.ownerName}'s to {destinationAccount.ownerName}'s account.\n");
               } else
               {
                  Console.WriteLine($"Insufficient funds in {this.ownerName}'s account. Cannot transfer {amount} to {destinationAccount.ownerName}'s account.\n");
               }
            } else
            {
               Console.WriteLine($"Destination account is inactive. Cannot transfer funds from {this.ownerName}'s to {destinationAccount.ownerName}'s account.\n");
            }
         } else if(!destinationAccount.isAccountActive)
         {
            Console.WriteLine($"Both accounts are inactive. Cannot transfer funds from {this.ownerName}'s to {destinationAccount.ownerName}'s account.\n");
         } else
         {
            Console.WriteLine($"Account is inactive. Cannot transfer funds from {this.ownerName}'s to {destinationAccount.ownerName}'s account.\n");
         }
      }

      public void UpdateAccountType(string newAccountType)
      {
         this.accountType = newAccountType;
      }
   }
}