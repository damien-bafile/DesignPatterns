using System.Collections.Generic;
using System.IO;

public class Product
{
    private List<object> _parts = new List<object>();

    public void Add(string part)
    {
        this._parts.Add(part);
    }

    public string ListParts()
    {
        var str = string.Empty;

        foreach (var part in _parts)
        {
            str += part + ", ";
        }

        str = str.Remove(str.Length - 2);

        return "Product parts: " + str + "\n";
    }
}