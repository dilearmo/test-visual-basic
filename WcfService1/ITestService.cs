﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfService1
{
    [ServiceContract]
    interface ITestService : IService1
    {
        [OperationContract]
        void test(int value);
    }
}
