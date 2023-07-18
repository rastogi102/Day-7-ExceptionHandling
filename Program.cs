using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppExceptions
{
    public class Calculation
    {
        public static byte Add(byte num1, byte num2)
        {
            var result = num1 + num2;
            return (byte)result;
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {

            byte fNum, sNum;
            try
            {
                Console.WriteLine("Enter First Number:");
                fNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Enter Second Number:");
                sNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Result: \t"+Calculation.Add(fNum,sNum));
            }
            catch(FormatException fe)
            {
                Console.WriteLine("Format Error"+fe.Message);
            }
            catch(OverflowException fe)
            {
                Console.WriteLine("Over Flow Error" + fe.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error"+ex.Message);
            }
            finally
            {
                Console.WriteLine("End of Program");
                Console.ReadKey();
            }
            //int num1, num2, result;
            //try 
            //{
            //    Console.WriteLine("Enter first Number:");
            //    num1 = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Enter second Number");
            //    num2 = int.Parse(Console.ReadLine());
            //    result = num1 + num2;
            //    Console.WriteLine("Result after Adding {0} and {1}=\t {2}", num1, num2, result);
                
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Error!!!"+ ex.Message);
            //}
            //finally 
            //{
            //    Console.WriteLine("End of Program!!!");
            //}
            //Console.ReadKey();
        }
    }
}
