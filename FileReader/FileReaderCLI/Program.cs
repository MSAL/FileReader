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
            FileContainer textFile = new FileContainer();
            //file path for test
            textFile.Path = @"c:\temp\MyTest.txt";

            Console.WriteLine("Please enter your role");
            string role = Console.ReadLine();

            string response = ""; 


            if (role.ToUpper().Equals("ADMIN"))
            {
                Console.WriteLine("The given file is it encrypted");
                response = Console.ReadLine();
                if (response.ToUpper().Equals("YES"))
                {
                    textFile.IsEncrypted = true;
                }

                //Text File Sample reading 
                TextFileReader textFileReader = new TextFileReader();
                textFileReader.ReadContent(textFile);
                //Show file content if exist 
                Console.WriteLine(textFile.Content);
            }

            Console.WriteLine("Please enter your role");
            role = Console.ReadLine();

            if (role.ToUpper().Equals("ADMIN"))
            {
                

                //XML File Sample reading
                FileContainer xmlFile = new FileContainer();
                //file path for test
                xmlFile.Path = @"c:\temp\temp.xml";

                Console.WriteLine("The given file is it encrypted ? ");
                response = Console.ReadLine();
                if (response.ToUpper().Equals("YES"))
                {
                    xmlFile.IsEncrypted = true;
                }

                XmlFileReader xmlFileReader = new XmlFileReader();
                xmlFileReader.ReadContent(xmlFile);
                Console.WriteLine(xmlFile.Content);


                
            }

            Console.WriteLine("Please enter your role");
            role = Console.ReadLine();

            if (role.ToUpper().Equals("ADMIN"))
            {

                FileContainer jsonFile = new FileContainer();
                //file path for test
                jsonFile.Path = @"c:\temp\test.json";

                Console.WriteLine("The given file is it encrypted ? ");
                response = Console.ReadLine();
                if (response.ToUpper().Equals("YES"))
                {
                    jsonFile.IsEncrypted = true;
                }

                JsonFileReader jsonFileReader = new JsonFileReader();
                jsonFileReader.ReadContent(jsonFile);
                Console.WriteLine(jsonFile.Content);

                Console.ReadLine();
            }
        }

       

    }
}
