﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;

namespace WCFServerLib
{
    public interface IClientCallback
    {
        [OperationContract(IsOneWay = true)]
        void SendMessageToClient(string message);
    }
}
