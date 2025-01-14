namespace SOLID
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Program starts here");
            #region old code
            /* Customer customer = new Customer();
             customer.Insert();*//*

            Console.WriteLine("Enter Customer Type");
            string customerType=Console.ReadLine().ToUpper();

            Customer customer= null;
            if (customerType == "SILVER")
            {
                customer = new SilverCustomer();
                
                *//*customer.PrintTicket();
                customer.GetTicketAmount();*/

            /* customer.GetTicketAmount();
             customer.PrintTicket();*//*

         }
         else if (customerType == "GOLD")
         {
             customer = new GoldCustomer();
             *//*customer.GetTicketAmount();
             customer.PrintTicket();*//*
         }
         else if (customerType == "PLATINUM")
         {
            customer = new PlatinumCustomer();
            *//* customer.GetTicketAmount();
             customer.PrintTicket();*//*
         }
         else if(customerType == "VIP")
         {
             customer= new VIPCustomer();
         }

         if (customer != null)
         {
             customer.ShowsTiming();
            //customer.PrintTicket();
         }
         else {
             Console.WriteLine("INVALID CUSTOMER");
                 }
         //ICustomer1 customer1 = new Enquiry(); //Error*/
            #endregion old code

            Customer c=new Customer(new FileLogger());
            c.Insert();

            Customer c2= new Customer(new DatabaseLogger());
            c2.Insert();

            Console.WriteLine("Program ends here");
            Console.ReadLine();
        }
    }
}
