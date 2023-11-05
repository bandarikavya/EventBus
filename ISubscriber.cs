using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    interface ISubscriber
    {
        Token Token { get; }
        Task Publish(BaseEvent evnt, EventArgs args);
    }
}
