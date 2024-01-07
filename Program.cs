using System.Security.Cryptography.X509Certificates;

namespace ReadOnlyVsConst
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
             * We can declare/initialize const variable in methods.
             */
            const int x = 5;

            /*
             * We are not allowed t use readonly inside method. The below statement is giving error.
             */
            readonly int y = 10;

            Console.WriteLine(x);
        }
    }
}