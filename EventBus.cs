using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    class EventBus : IEventBus
    {

        private readonly IDictionary<Type, List<Subscribers>> subscription;
        private ITokenUtils tokenUtils; 
        public Task Publish<TEvent>(TEvent tevent, EventArgs args)
        {
            throw new NotImplementedException();
        }

        public Token Subscribe<TEvent>()
        {
            throw new NotImplementedException();
        }

        public void UnSubscribe<TEvent>(string tokenId)
        {
            throw new NotImplementedException();
        }
    }
}
