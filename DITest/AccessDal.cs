using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    public class AccessDal : IDataAccess
    {
        public void Add()
        {
            Console.WriteLine("Access实现");
        }
    }
}
