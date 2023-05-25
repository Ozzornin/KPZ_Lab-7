using Composite.Class;

ILightNode parent = new LightElementNode("div", "block", false);
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

