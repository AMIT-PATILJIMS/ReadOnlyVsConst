using System.Security.Cryptography.X509Certificates;

namespace ReadOnlyVsConst
{
    public class Program
    {
        /*
         * We are not allowed to use static keyword with const.
         * The below statement is giving error.
         */
        static const int x = 5;

        /*
         * We are allowed to use static keyword with readonly.
         */
        static readonly int y = 10;

        static void Main(string[] args)
        {

            Console.WriteLine(y);
        }
    }
}