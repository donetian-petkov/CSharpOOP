using System;
using System.Linq;
using System.Text.RegularExpressions;


namespace Telephony
{
    public class StationaryPhone : IPhonable
    {
        public StationaryPhone(){}
            
        public void Call(string number)
        {
            bool isIntString = number.All(char.IsDigit);
            
            if (isIntString)
            {
                Console.WriteLine($"Dialing... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }
    }
}