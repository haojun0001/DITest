using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    interface IDependent
    {
        void SetDependence(IDataAccess ida);//设置依赖项
    }
}
