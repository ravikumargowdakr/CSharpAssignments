using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class InvalidPINNumberException : System.ApplicationException
    {
        public InvalidPINNumberException(String message) : base(message) { }
    }
    internal class FNFBank
    {
        static void ValidPIN()
        {
            int sum = 0;
            int pin = Int32.Parse(Console.ReadLine());
            var str = pin.ToString();
            foreach (int i in str)
            {
                sum += Convert.ToInt32(i);
            }
            if (str.Length > 4)
            {
                InvalidPINNumberException invalidOperationException = new InvalidPINNumberException("InvalidPINNumberException");
                throw invalidOperationException;
                //Console.WriteLine("Enter 4 digit PIN");
            }
            else if (sum % 2 == 0)
            {
                int[] PinArray = new int[] { 1234, 2000, 5641, 0000, 2468, 5555 };
                if (PinArray.Contains(pin))
                {
                    Console.WriteLine("PIN SUCCESS");
                }
                else
                {
                    Console.WriteLine("PIN DOES NOT MATCH");
                    //If we want we can throw our custom Exception here also.
                }
            }
            else
            {
                InvalidPINNumberException invalidOperationException = new InvalidPINNumberException("InvalidPINNumberException");
                throw invalidOperationException;
            }
        }
        static void HandleExecption()
        {
            try
            {
                ValidPIN();
            }
            catch (InvalidPINNumberException exRef)
            {
                Console.WriteLine($"{exRef.Message}");
            }
            catch (System.FormatException ex)
            {
                Console.WriteLine("InvalidPINNumberException");
            }
        }
        static void Display()
        {
            Console.WriteLine("**************************************************************\r\n\r\n\tWelcome to FNF India Investment Banking\r\n\r\n\tEnter the pin to continue the operation:\r\n\r\n\t****\r\n\r\n**************************************************************");
            
        }
        static void Main(string[] args)
        {
            Display();
            HandleExecption();   
        }
    }
}
