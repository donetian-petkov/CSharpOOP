using System;

namespace Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Smartphone nokia = new Smartphone();
            StationaryPhone phone = new StationaryPhone();
            
            string[] input = Console.ReadLine().Split(" ");

            for (int i = 0; i < input.Length; i++)
            {
                string number = input[i];

                if (number.Length == 7)
                {
                    phone.Call(number);
                }
                else if (number.Length == 10)
                {
                 nokia.Call(number);   
                }
            }

            string[] secondInput = Console.ReadLine().Split(" ");

            for (int i = 0; i < secondInput.Length; i++)
            {
                nokia.Browse(secondInput[i]);
            }

        }
    }
}