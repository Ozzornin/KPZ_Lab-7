using Composite.Class;
using Composite.Observer;

var container = new HandlerContainer();

ILightNode parent = new LightElementNode("div", "block", false);

container.AddEventHandler(parent, NodeEvents.click, new ChildObserver());
container.AddEventHandler(parent, NodeEvents.mouseIn, new RandomObserver());

container.NotifyHandlers(parent, NodeEvents.click);
container.NotifyHandlers(parent, NodeEvents.mouseIn);

Console.ReadLine();

return;

ILightNode table = new LightElementNode("table", "block", false);
ILightNode tr = new LightElementNode("tr", "inline", false);
ILightNode td = new LightElementNode("td", "inline", false);
td.AppendChild(new LightTextNode("p", "p1"));
tr.AppendChild(td);

tr.AppendChild(td.Clone());
table.AppendChild(tr);
parent.AppendChild(table);
Console.WriteLine(parent.InnerHTML());

Console.WriteLine();


tr.RemoveChild(td);
Console.WriteLine(parent.OuterHTML());

