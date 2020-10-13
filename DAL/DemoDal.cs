using System;
using System.Collections.Generic;
using System.Text;

namespace DAL
{
    public class DemoDal : IDemoDal
    {
        public string GetDummyValue() => "dummy values from DAL";
    }
}
