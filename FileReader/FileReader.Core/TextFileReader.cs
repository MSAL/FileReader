﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Core
{
    public class TextFileReader : ITextFileReader
    {
        public void ReadContent(FileContainer file)
        {
            string path = file.Path;
            string readText = ""; 

            if (File.Exists(path))
            {
                // Read text content from the given file .
                 readText = File.ReadAllText(path);
            }
            else
            {
                readText = "FileNotFound"; 
            }
                   
            if (file.IsEncrypted)
            {
                
                readText = EncryptionUtility.DecryptData(readText); 
            }
            file.Content = readText;
        }



        
    }
}
