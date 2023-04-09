using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp1
{
    public class BankAccount
    {
        public string Name { get; set; }
        public long AadharNumber { get; set; }
        public string PanNumber { get; set; }
        public byte[] PhotoId { get; set; }
        public long PhoneNumber { get; set; }
        public string Email { get; set; }

        private BankAccount() { }

        public class Builder
        {
            private BankAccount account = new BankAccount();

            public Builder(string name, long aadharNumber, string panNumber, byte[] photoId)
            {
                account.Name = name;
                account.AadharNumber = aadharNumber;
                account.PanNumber = panNumber;
                account.PhotoId = photoId;
            }

            public Builder HoldsPhoneNumber(long phoneNumber)
            {
                account.PhoneNumber = phoneNumber;
                return this;
            }

            public Builder HoldsEmail(string email)
            {
                account.Email = email;
                return this;
            }

            public BankAccount Build()
            {
                if (string.IsNullOrEmpty(account.Name) || account.AadharNumber == 0 || string.IsNullOrEmpty(account.PanNumber) || account.PhotoId == null)
                {
                    throw new InvalidOperationException("Name, Aadhar Number, Pan Number, and Photo ID are mandatory fields.");
                }

                return account;
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Aadhar Number: " + AadharNumber);
            Console.WriteLine("Pan Number: " + PanNumber);
            Console.WriteLine("Photo ID: " + PhotoId);
            Console.WriteLine("Phone Number: " + PhoneNumber);
            Console.WriteLine("Email: " + Email);
        }
    }

    internal class H02builder
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount.Builder("Ravi Kumar", 456912357489, "GYHB1236P", new byte[] { 0xAB, 0xCD, 0x12, 0x34 })
     .HoldsPhoneNumber(9874562544)
     .HoldsEmail("ravikumar@gmail.com")
     .Build();

            account.PrintDetails();
        }
    }
}
