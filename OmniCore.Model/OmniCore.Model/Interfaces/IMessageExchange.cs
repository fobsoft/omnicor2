﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OmniCore.Model.Interfaces
{
    public interface IMessageExchange
    {
        Task InitializeExchange(IMessageExchangeProgress messageProgress);
        Task<IMessage> GetResponse(IMessage request, IMessageExchangeProgress messageProgress);
        bool ParseResponse(IMessage response, IPod pod, IMessageExchangeProgress messageProgress);
    }
}
