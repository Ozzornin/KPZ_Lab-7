using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Strategy
{
    public class InternetStrategy : IStrategy
    {
        public object Invoke(object data)
        {
            string path = (string)data;
            return "Url image";
        }
    }
}
