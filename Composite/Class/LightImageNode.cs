using Composite.Strategy;
using Composite.Strategy.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Class
{
    public class LightImageNode : ILightNode
    {        
        public string LightName = "img";
        public string LightType = "unpaired";
        private string _href;
        private IStrategy? _strategy;


        public object Value
        {
            get
            {
                return _strategy.Invoke(_href);
            }
            set { }
        }


        public LightImageNode(string href)
        {
            if (HrefChecker.IsUrl(href))
            {
                _strategy = new InternetStrategy();
            }
            else if (HrefChecker.IsFilePath(href))
            {
                _strategy = new LocalStrategy();
            }
            else
            {
                _strategy = null;
                Console.WriteLine("Cannot check href type");
            }
        }      

        public void AppendChild(ILightNode node)
        {
            throw new NotImplementedException();
        }

        public ILightNode Clone()
        {
            throw new NotImplementedException();
        }

        public string InnerHTML(int level = 0)
        {
            throw new NotImplementedException();
        }

        public void InsertBefore(ILightNode node, ILightNode refNode)
        {
            throw new NotImplementedException();
        }

        public string OuterHTML(int level = 0)
        {
            throw new NotImplementedException();
        }

        public void RemoveChild(ILightNode node)
        {
            throw new NotImplementedException();
        }

        public void ReplaceChild(ILightNode oldNode, ILightNode newNode)
        {
            throw new NotImplementedException();
        }
    }
}
