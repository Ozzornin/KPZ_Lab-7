using Composite.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Observer
{
    public class RandomObserver : IObserver
    {
        public void Notify(object sender)
        {
            sender = sender as ILightNode;
            Console.WriteLine($"Random {sender} handler");            
        }
    }
}
