using System.Security.Cryptography.X509Certificates;

namespace ReadOnlyVsConst
{
    public class Program
    {
        /*
         * Const has the same value throuout the lifetime of the application.
         * We are not allowed to change the value of x.
         */
        const int x = 5;

        /*
         * readonly is also a constant.
         * But we can change the value of readonly with constructor.
         */

        readonly int y = 10;
        static void Main(string[] args)
        {
            Program obj = new Program();
            Console.WriteLine(x);
            Console.WriteLine(obj.y);
        }
    }
}