using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop
{
   class Customer
   {
      public string customerName;
      public int customerAge;
      public string customerAddress;
      public string customerEmail;
      public string customerPhoneNumber;

      public Dictionary<string, int> customerOrderHistory;
      public List<string> customerSupportTickets;
      public List<string> customerFeedback;


      public Customer(string name, int age, string address, string email, string phone)
      {
         this.customerName = name;
         this.customerAge = age;
         this.customerAddress = address;
         this.customerEmail = email;
         this.customerPhoneNumber = phone;
         this.customerOrderHistory = new Dictionary<string, int>();
         this.customerSupportTickets = new List<string>();
         this.customerFeedback = new List<string>();
      }

      public void PrintCustomerInfo()
      {
         Console.WriteLine("Customer Name: " + this.customerName);
         Console.WriteLine("Customer Age: " + this.customerAge);
         Console.WriteLine("Customer Address: " + this.customerAddress);
         Console.WriteLine("Customer Email: " + this.customerEmail);
         Console.WriteLine("Customer Phone Number: " + this.customerPhoneNumber);
         Console.WriteLine();
      }

      public void UpdateCustomerInfo(string newName, int newAge, string newAddress, string newEmail, string newPhone)
      {
         this.customerName = newName;
         this.customerAge = newAge;
         this.customerAddress = newAddress;
         this.customerEmail = newEmail;
         this.customerPhoneNumber = newPhone;
      }

      public void PlaceOrder(string product, int quantity)
      {
         if (this.customerOrderHistory.ContainsKey(product))
            this.customerOrderHistory[product] += quantity;
         else
            this.customerOrderHistory.Add(product, quantity);
         Console.WriteLine("Order placed for " + quantity + " " + product + "s");
      }

      public void RequestSupport(string supportRequest)
      {
         this.customerSupportTickets.Add(supportRequest);
         Console.WriteLine("Support request submitted: " + supportRequest);
         Console.WriteLine();
      }

      public void SendFeedback(string feedback)
      {
         this.customerFeedback.Add(feedback);
         Console.WriteLine("Feedback submitted: " + feedback);
         Console.WriteLine();
      }
   }
}