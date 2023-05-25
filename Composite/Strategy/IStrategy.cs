using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Strategy
{
    public interface IStrategy
    {
        public object Invoke(object data);
    }
}
