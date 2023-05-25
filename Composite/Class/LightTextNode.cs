using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Class
{
    public class LightTextNode : ILightNode
    {
        public string LightName { get; set; }
        private string _text;

        public LightTextNode(string name, string text) {
            LightName = name;
            _text = text;
        }

        public string InnerHTML(int level)
        {
             return _text;            
        }

        public string OuterHTML(int level)
        {
            return $"<{LightName}>{_text}</{LightName}>";
        }

        public void AppendChild(ILightNode node)
        {
            
        }

        public ILightNode Clone()
        {
            return new LightTextNode(this.LightName, this._text);           
        }

        public void InsertBefore(ILightNode node, ILightNode refNode)
        {
            
        }

        public void RemoveChild(ILightNode node)
        {
            
        }

        public void ReplaceChild(ILightNode oldNode, ILightNode newNode)
        {
            
        }
        public override string ToString()
        {
            return LightName;
        }
    }
}
