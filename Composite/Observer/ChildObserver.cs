using Composite.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Observer
{
    public class ChildObserver : IObserver
    {
        public void Notify(object sender)
        {
            sender = (ILightNode)sender;
            Console.WriteLine($"Child nodes of {sender} would be displayed here.");
        }
    }
}
