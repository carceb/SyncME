using System;
using System.Collections.Generic;
using System.Xml;

namespace DM
{
    public static class XMLmethods
    {

        public static List<DmHolder> readDMlist()
        {
            List<DmHolder> list = new List<DmHolder>();
            if (System.IO.File.Exists("mirrors.xml"))
            {
                XmlTextReader reader = new XmlTextReader("mirrors.xml");
                reader.Read();
                //int i = 0;
                while (reader.Read())
                {
                    XmlNodeType type = reader.NodeType;
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        if (reader.Name == "directorymirror")
                        {
                            DmHolder dme = new DmHolder();
                            dme.Name = reader.GetAttribute("name");
                            dme.SourcePath = reader.GetAttribute("source");
                            dme.MirrorPath = reader.GetAttribute("mirror");
                            dme.Buffer = Convert.ToInt32(reader.GetAttribute("buffer"));
                            dme.Timer = Convert.ToDouble(reader.GetAttribute("timer"));
                            dme.Identifier = Convert.ToInt64(reader.GetAttribute("identifier"));
                            list.Add(dme);
                        }
                    }
                }
                reader.Close();
            }
            return list;
        }

        public static void writeDMlist(List<DmHolder> list)
        {
            list.Sort((x, y) => y.Identifier.CompareTo(x.Identifier));
            XmlTextWriter writer = new XmlTextWriter("mirrors.xml", null);
            // Use automatic indentation for readability.
            writer.Formatting = Formatting.Indented;
            writer.WriteStartDocument();
            // Write first element
            writer.WriteStartElement("directorymirrors");
            foreach (DmHolder dme in list)
            {
                writer.WriteStartElement("directorymirror");
                writer.WriteAttributeString("name", dme.Name);
                writer.WriteAttributeString("timer", dme.Timer.ToString());
                writer.WriteAttributeString("buffer", dme.Buffer.ToString());
                writer.WriteAttributeString("source", dme.SourcePath);
                writer.WriteAttributeString("mirror", dme.MirrorPath);
                writer.WriteAttributeString("identifier", dme.Identifier.ToString());
                writer.WriteEndElement();
            }
            // Rnd the root element
            writer.WriteEndElement();
            // Write the XML to file and close the writer
            writer.WriteEndDocument();
            writer.Flush();
            writer.Close();
        }

    }
}
