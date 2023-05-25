using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Class
{
    public interface ILightNode
    {
        public string InnerHTML(int level = 0);
        public string OuterHTML(int level =0);
        public void AppendChild(ILightNode node);
        public void ReplaceChild(ILightNode oldNode, ILightNode newNode);
        public void RemoveChild(ILightNode node);
        public void InsertBefore(ILightNode node, ILightNode refNode);
        public ILightNode Clone();
    }
}
