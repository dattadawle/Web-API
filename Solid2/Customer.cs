using SOLID;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRP
{

    // It will deal with all Customer related Operations
    public class Customer
    {
        public void Insert()
        {
            try
            {
                // ado .net code/ ef

                int a = 10, b = 0;

                int c = a / b;
            }
            catch (Exception ex)
            {
                /*File.AppendAllText(@"Logs/errors.txt",$"{ex.Message}\n");*/
                /*                File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}\n");
                */
                Demo obj = new Demo();
                obj.getName(ex.Message);

                Console.WriteLine("End Program");
            
            }
        }
       
   }
}

        
 

