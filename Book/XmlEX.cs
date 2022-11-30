using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

public class Tmp
{
    public string Name { get; set; }

    public List<CTmp> Items { get; set; }
    public Tmp()
    {
        Items = new List<CTmp>();
    }
}

public class CTmp
{
    public string Name { get; set; }
    public string DESC { get; set; }
}









public static class XmlEX
{
    public static string Serialize<T>(this T value)
    {
        if (value == null) return string.Empty;

        var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));

        using (var stringWriter = new System.IO.StringWriter())
        {
            using (var xmlWriter = XmlWriter.Create(stringWriter, new XmlWriterSettings { Indent = true }))
            {
                xmlSerializer.Serialize(xmlWriter, value);
                return stringWriter.ToString();
            }
        }
    }

    public static T DeSerialize<T>(this string xml) where T : class, new()
    {
        T obj = default(T);
        var xmlSerializer = new System.Xml.Serialization.XmlSerializer(typeof(T));
        using (var stringReader = new System.IO.StringReader(xml))
        {
            using (var reader = XmlReader.Create(stringReader, new XmlReaderSettings()))
            {
                obj = xmlSerializer.Deserialize(reader) as T;
            }
        }
        return obj;
    }
}