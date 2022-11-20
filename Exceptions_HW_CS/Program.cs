using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace Exceptions_HW_CS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Variables a = Variables.Parse("33333,4,5");
                Variables b = Variables.Parse("4,522323,64234");
               (double x ,double y) = Variables.Solve(a, b);
                Console.WriteLine(x);
                Console.WriteLine(y);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Format exception");
            }
            catch(ArgumentOutOfRangeException AofR)
            {
                Console.WriteLine("Out of range");
            }
            catch(Exception all_ex)
            {
                Console.WriteLine("All_ex");
            }
           
        }
    }
}