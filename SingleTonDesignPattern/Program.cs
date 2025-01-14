namespace SingleTonDesignPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DatabaseConnection db1 = new DatabaseConnection();
            DatabaseConnection db1 =  DatabaseConnection.GetInstance;
            int counter = db1.GetNumber();
            Console.WriteLine($"value={counter}");


            counter = db1.GetNumber();
            Console.WriteLine($"value={counter}");

            //DatabaseConnection db2 = new DatabaseConnection();
            DatabaseConnection db2 = DatabaseConnection.GetInstance;
            counter = db2.GetNumber();
            Console.WriteLine($"value={counter}");

            DatabaseConnection db3 = DatabaseConnection.GetInstance;
            counter = db3.GetNumber();
            Console.WriteLine($"value={counter}");



                     /*
                        Customer obj = Customer.getObj();
                        int count = obj.FindCount();
                        Console.WriteLine($"Count is : {count}");

                        count = obj.FindCount();
                        Console.WriteLine($"Count is : {count}");

                        count = obj.FindCount();
                        Console.WriteLine($"Count is : {count}");

                        Customer obj1 = Customer.getObj();
                         count = obj1.FindCount();
                        Console.WriteLine($"Count is : {count}");
                     */


            Console.ReadLine();
        }
    }
}
