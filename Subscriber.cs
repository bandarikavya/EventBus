using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventBusDemo
{
    public class Subscriber<TEvent> : ISubscriber where TEvent : BaseEvent
    {
        private event Func<TEvent, EventArgs, Task> _eventHandler;
        public Token Token { get; }

        public Subscriber(Func<TEvent , EventArgs, Task> eventHandler, Token token)
        {
            _eventHandler = eventHandler;
            Token = token;
        }
        public async Task Publish(BaseEvent evnt, EventArgs args)
        {
            await _eventHandler((TEvent)evnt, args);
        }
    }
}
