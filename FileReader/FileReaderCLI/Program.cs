using FileReader.Core;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReaderCLI
{
    public class Program
    {
        static void Main(string[] args)
        {
            FileContainer file = new FileContainer();
            //file path for test
            file.Path = @"c:\temp\MyTest.txt";

            TextFileReader fileReader = new TextFileReader();
            fileReader.ReadText(file);
            //Show file content if exist 
            Console.WriteLine(file.Content);


            Console.ReadLine();
        }
    }
}
