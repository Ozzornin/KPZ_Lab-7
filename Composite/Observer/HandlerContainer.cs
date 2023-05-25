using Composite.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Observer
{
    public enum NodeEvents
    {
        mouseIn,
        mouseOut,
        click
    }
    public class HandlerContainer
    {
        //maybe it would be better to add callback functions instead of adding observers to dictionary
        private Dictionary<ILightNode, Dictionary<NodeEvents, List<IObserver>>> _listeners = 
                        new Dictionary<ILightNode, Dictionary<NodeEvents, List<IObserver>>>();

        public void AddEventHandler(ILightNode sender, NodeEvents nodeEvent, IObserver handler)
        {
            addNode(sender);
            addHandler(sender, nodeEvent, handler);
        }
        //check if node is in list
        private void addNode(ILightNode node)
        {            
            if(!_listeners.ContainsKey(node))
                _listeners[node] = new Dictionary<NodeEvents, List<IObserver>>();
        }
        //add handler
        private void addHandler(ILightNode node,NodeEvents nodeEvent, IObserver handler)
        {
            //check if node has event otherwise create it and add handler
            if (!_listeners[node].ContainsKey(nodeEvent))
            {
                _listeners[node][nodeEvent] = new List<IObserver>() {handler};
            }
            else
            {
                if (_listeners[node][nodeEvent].IndexOf(handler) == -1)
                {
                    _listeners[node][nodeEvent].Add(handler);
                }
            }

        }

        public void NotifyHandlers(ILightNode node, NodeEvents nodeEvent)
        {
            //idk how to make it readable
            var observers = _listeners.ContainsKey(node)?
                            _listeners[node].ContainsKey(nodeEvent)? _listeners[node][nodeEvent] : null 
                            : null;
            if (observers == null)
                return;
            foreach(var obj in observers)
            {
                obj.Notify(node);
            }
        }
    }
}
