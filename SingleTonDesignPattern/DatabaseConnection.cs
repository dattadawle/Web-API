using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleTonDesignPattern
{
    internal class DatabaseConnection
    {
        // to achive singleton design pattern 
        // 1. our class should contain private ctor
        //
        public int _counter;

        private static DatabaseConnection _connection=null;
        private static object _obj=new object();
        /*  public DatabaseConnection()

          {
              _counter = 0;
          }*/

        private DatabaseConnection() //private ctor=> can not make object
        {
            _counter = 0;
        }

        public static DatabaseConnection GetInstance
        {
            get
            {
               
                if (_connection == null) // to improve performance

                {
                    lock (_obj)     // used in multithreading applications
                    {
                        if (_connection == null)
                        {
                            _connection = new DatabaseConnection();
                        }
                    }
                }
                
                return _connection;
            
            }
        }

        public int GetNumber()
        {
            return _counter++;
        }
    }
}
