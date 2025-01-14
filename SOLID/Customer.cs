using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    public class Customer
    {
        ILogger _log;
        public Customer(ILogger log)
        {
            _log = log;

        }
        public Customer()
        {

        }
        /* public string CustomerType { get; set; }*/
        /* public void Insert()
         {
             *//*string message = null;
             try
             {
                 int a = 10, b = 0;

                 int c = a / b;
             }
             catch (Exception ex)
             {
                 message = ex.Message;
                 File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}");
             }
             FileLogger fl = new FileLogger();
             fl.log(message);

         }*/
        public void ShowsTiming()
        {
            Console.WriteLine("****All shows timings****");
        }
        public void Insert()
        {
            string message = null;
            try
            {
                int a = 10, b = 0;

                int c = a / b;
            }
            catch (Exception ex)
            {
                //message = ex.Message;
                // File.AppendAllText(@"Logs/errors.txt", $"{ex.Message}");
                //FileLogger fl = new FileLogger();
                _log.Log(ex.Message);
            }

        }





        public interface ICustomer1
        {
            int GetTicketAmount();
            void PrintTicket();
        }

        public interface ICustomerV1 : ICustomer1
        {
            void FreeFood();

        }



        public class SilverCustomer : Customer, ICustomer1
        {
            /* public override int GetTicketAmount()
             {
                 return 100;
             }

             public override void PrintTicket()
             {
                  Console.WriteLine("Silver ticket Printed");
             }*/
            public int GetTicketAmount()
            {
                return 100;
            }

            public void PrintTicket()
            {
                Console.WriteLine("Silver ticket Printed");
            }
        }

        public class GoldCustomer : Customer, ICustomer1
        {
            /*  public override int GetTicketAmount()
              {
                  return 290;
              }

              public override void PrintTicket()
              {
                  Console.WriteLine("Gold Ticket Printed");
              }*/
            public int GetTicketAmount() // while using interface no need to override
            {
                return 290;
            }

            public void PrintTicket()
            {
                Console.WriteLine("Gold Ticket Printed");
            }
        }

        public class PlatinumCustomer : Customer, ICustomer1

        {
            /*public override int GetTicketAmount()
            {
                return 310;
            }

            public override void PrintTicket()
            {
                Console.WriteLine("Platinum ticket printed");
            }*/

            public int GetTicketAmount()
            {
                return 310;
            }

            public void PrintTicket()
            {
                Console.WriteLine("Platinum ticket printed");
            }

        }

        public class Enquiry : Customer
        {
            //no need of GetTicketAmount()  method here
            // no need of PrintTicket()  method here 
            //that's the reason this class will not be a perfect child class it does not follows the lsp principle
        }

        public class VIPCustomer : Customer, ICustomerV1
        {
            public void FreeFood()
            {
                Console.WriteLine(" Free Food will be delevered at seat");
            }

            public int GetTicketAmount()
            {
                return 1500;
            }

            public void PrintTicket()
            {
                Console.WriteLine("VIP ticket printed");
            }
        }

    }
}
