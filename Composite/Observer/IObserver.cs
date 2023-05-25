using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Observer
{
    public interface IObserver
    {
        public void Notify(object sender);
    }
}
