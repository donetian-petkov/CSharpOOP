using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Telephony
{
    public class Smartphone : ISmartphonable
    {
        public Smartphone(){}
        
        public void Call(string number)
        {
            bool isIntString = number.All(char.IsDigit);
            
            if (isIntString)
            {
                Console.WriteLine($"Calling... {number}");
            }
            else
            {
                Console.WriteLine("Invalid number!");
            }
        }

        public void Browse(string website)
        {
            bool containsInt = website.Any(char.IsDigit);

            if (containsInt)
            {
                Console.WriteLine("Invalid URL!");
            }
            else
            {
                Console.WriteLine($"Browsing: {website}!");
            }
        }
    }
}