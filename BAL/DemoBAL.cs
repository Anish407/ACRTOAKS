using DAL;
using System;
using System.Collections.Generic;
using System.Text;

namespace BAL
{
    public class DemoBAL : IDemoBAL
    {
        public DemoBAL(IDemoDal demoDal)
        {
            DemoDal = demoDal;
        }

        public IDemoDal DemoDal { get; }

        public string GetDemoData() => DemoDal.GetDummyValue();

    }
}
