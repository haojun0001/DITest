using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    public class OracleDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("Oracle实现");
        }
    }
}
