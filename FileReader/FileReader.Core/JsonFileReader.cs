using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Core
{
    public class JsonFileReader : ITextFileReader
    {
        public void ReadContent(FileContainer file)
        {
            string readText = ""; 
            if (File.Exists(file.Path))
            {
                // Read text content from the given file .
                readText = File.ReadAllText(file.Path);
            }
            JsonTextReader reader = new JsonTextReader(new StringReader(readText));
            while (reader.Read())
            {
                if (reader.Value != null)
                {
                   file.Content = file.Content + "Token: " +EncryptionUtility.DecryptData( reader.TokenType.ToString())+", Value: "+ EncryptionUtility.DecryptData(reader.Value.ToString()) +"\n";
                }
                else
                {
                    file.Content = file.Content + "Token: " + EncryptionUtility.DecryptData(reader.TokenType.ToString()) + "\n"; 
                }
            }
        }
    }
}
