using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite.Class
{
    public class LightElementNode : ILightNode
    {
        public string LightName { get; set; }
        public string LightType { get; set; }
        public bool IsSingle { get; set; }

        private List<string> _classList = new List<string>();
        
        private List<ILightNode> _children  = new List<ILightNode>();


        private LightElementNode() { }

        public LightElementNode(string lightName, string lightType, bool isSingle)
        {
            LightName = lightName;
            LightType = lightType;
            IsSingle = isSingle;            
        }

        public void AppendChild(ILightNode node)
        {
            _children.Add(node);
        }

        public ILightNode Clone()
        {
            var clone = new LightElementNode()
            {
                LightName = LightName,
                LightType = LightType,
                IsSingle = IsSingle,
                _classList = new List<string>(_classList),
                _children = new List<ILightNode>(_children.Select(child => child.Clone()))
            };
            return clone;
        }

        public void InsertBefore(ILightNode node, ILightNode refNode)
        {
            var index = _children.IndexOf(refNode);
            if (index >= 0)
            {
                _children.Insert(index, node);
            }
            else
            {
                Console.WriteLine("The reference node is not a child of this node.");
            }
        }

        public void RemoveChild(ILightNode node)
        {
            _children.RemoveAll(el => el.Equals(node));
            
        }

        public void ReplaceChild(ILightNode newNode, ILightNode oldNode)
        {
            var index = _children.IndexOf(oldNode);
            if (index >= 0)
            {
                _children[index] = newNode;
            }
            else
            {
                Console.WriteLine("The node to be replaced is not a child of this node.");
            }
        }

        public string InnerHTML(int level)
        {
            if (_children.Any())
            {
                return string.Join("\n", _children.Select(child => child.OuterHTML(level+1)));
            }
            else
            {
                return "";
            }                    
        }

        public string OuterHTML(int level)
        {
            string classAttr = _classList.Any() ? " class=\"" + string.Join(" ", _classList) + "\"" : "";
            string singleAttr = IsSingle ? " /" : "";
            string tagLevel = new string('\t', level);

            if (_children.Any())
            {
                string childrenHTML = string.Join("\n", _children.Select(child => child.OuterHTML(level + 1))) ;
                return $"<{LightName}{classAttr}>\n{tagLevel}{childrenHTML}\n</{LightName}>";
            }
            else
            {
                return $"<{LightName}{classAttr}{singleAttr}>";
            }
        }
    }
}
