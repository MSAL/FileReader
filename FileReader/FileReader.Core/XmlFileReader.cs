using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace FileReader.Core
{
    public class XmlFileReader : ITextFileReader
    {
        public void ReadContent(FileContainer file)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(file.Path);
            string fileContent = ""; 
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                 fileContent = fileContent + node.InnerText + "\n"; 
            }

            file.Content = fileContent; 
        }
    }
}
