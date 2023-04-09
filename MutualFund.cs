using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
   
    class MarketInsights
    {
        public int GetRate()
        {
            Random random = new Random();
            int rate = random.Next(0, 1000);
            return rate;
        }
    }
    class Mutualfund
    {
        MarketInsights marketValue = new MarketInsights();
        Dashboard dashboard = new Dashboard();
        List<int> rateStore = new List<int>();
        public void CheckRate()
        {
            int CurrentRate = marketValue.GetRate();
            //rateStore.Add(CurrentRate);
            if (CurrentRate < 40)
            {
                dashboard.RedDisplay(CurrentRate);
            }
            else
            {
                dashboard.GreenDisplay(CurrentRate);
            }
        }
        public void ShowOnDashboard() //Only if we want to shore all data of rates.
        {
            
            foreach (int item in rateStore)
            {
                if (item < 40)
                {
                    dashboard.RedDisplay(item);
                }
                else
                {
                    dashboard.GreenDisplay(item);
                }
            }
        }
    }
    
    class Dashboard 
    {
        public void RedDisplay(int newRate)
        {
            Console.ForegroundColor=ConsoleColor.Red;
            Console.Write(newRate);
            //Console.WriteLine($"The Current Rate : {newRate}");
            string result = "";
            for (var i = 0; i < newRate/10 ; i++)
            {
                result += "*";
            }
            Console.Write(result);
            Console.ForegroundColor = ConsoleColor.White;
        }
        public void GreenDisplay(int newRate)
        {

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write(newRate);
            string result = "";
            for (var i = 0; i < newRate/10; i++)
            {
                result += "*";
            }
            Console.Write(result);
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
    internal class MutualFund
    {
        static void Main(string[] args)
        {
            Mutualfund mutualfund = new Mutualfund();
            Console.WriteLine("******************************************************\r\n\r\n\t\t      MUTUAL FUND\r\n\t   \r\n\t        INITIAL RATE :40 / UNIT\r\n\r\n\t  ENTER EXIT TO GO OUT OF DASHBOARD\t\r\n\r\n\t PRESS ENTER TO KNOW THE CURRENT RATE \r\n\r\n******************************************************");

            while (true)
            {
                //mutualfund.ShowOnDashboard();
                string Exit = Console.ReadLine();
                if (Exit == "EXIT") { break; }
                mutualfund.CheckRate();
            }
        }
    }
}
