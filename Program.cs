using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop
{
   internal class Program
   {
      static void Main(string[] args)
      {
         #region Customer
         Customer pete = new Customer("Pete", 25, "123 Main St", "petergriffin@gmail.com", "555-555-5555");
         pete.PrintCustomerInfo();
         pete.UpdateCustomerInfo("Peter", 26, "123 Main St", "petergriffin@gmail.com", "555-555-5555");
         pete.PrintCustomerInfo();
         pete.PlaceOrder("iPhone", 5);
         pete.PlaceOrder("Mac Book M2 Pro", 5);
         pete.RequestSupport("My iPhone is broken");
         pete.RequestSupport("My Mac Book M2 Pro is broken");
         pete.SendFeedback("I love your products");
         pete.SendFeedback("Fast Delivery");
         #endregion

         #region BankAccount
         BankAccount peteAccount = new BankAccount("Pete", 1500, "123456789", "Golden", "2021-01-01");
         BankAccount georgeAccount = new BankAccount("George", 500, "123456788", "Golden", "2020-12-31");
         peteAccount.PrintAccountInfo();
         georgeAccount.PrintAccountInfo();
         peteAccount.TransferFundsTo(georgeAccount, 1000);
         georgeAccount.TransferFundsTo(peteAccount, georgeAccount.balance + 500);
         peteAccount.PrintAccountInfo();
         georgeAccount.PrintAccountInfo();
         peteAccount.CloseAccount();
         peteAccount.PrintAccountInfo();
         georgeAccount.CloseAccount();
         peteAccount.TransferFundsTo(georgeAccount, peteAccount.balance);
         #endregion

         Console.ReadKey();
      }
   }
}