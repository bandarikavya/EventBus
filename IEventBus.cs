using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    public interface IEventBus
    {
        Token Subscribe<TEvent>();
        Task Publish<TEvent>(TEvent tevent, EventArgs args);
        void UnSubscribe<TEvent>(string tokenId);
    }
}
