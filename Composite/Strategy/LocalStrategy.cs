using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Strategy
{
    public class LocalStrategy : IStrategy
    {
        public object Invoke(object data)
        {
            string path = (string)data;
            return "Local path image";
        }
    }
}
