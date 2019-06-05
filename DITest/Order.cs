using System;
using System.Collections.Generic;
using System.Text;

namespace DITest
{
    public class Order //: IDependent
    {
        private IDataAccess _ida;

        //public IDataAccess Ida { get => _ida; set => _ida = value; }

        public Order(IDataAccess _ida)
        {
            this._ida = _ida;
        }

        public void Add()
        {
            _ida.Add();
        }

        //public void SetDependence(IDataAccess ida)
        //{
        //    _ida = ida;
        //}
    }
}
