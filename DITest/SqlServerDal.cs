using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    public class SqlServerDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("Sql实现");
        }
    }
}
