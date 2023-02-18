using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace RgexPatternForPIN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Regex Pattern Matching Application!");
            Console.WriteLine("Enter PIN Code ");
            string PINCode=Console.ReadLine();
            Regex regexPINChecker=new Regex(PatternChecker.PinCodePattern);
            bool Check=regexPINChecker.IsMatch(PINCode);
            if (Check == true)
                Console.WriteLine("Entered PIN Code is Valid ");
            else
            Console.WriteLine("Entered PIN Code Is Not Valid ");

        }
    }
}
