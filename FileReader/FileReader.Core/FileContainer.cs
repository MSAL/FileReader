using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Core
{
    public class FileContainer
    {
        public string Path { get; set; }
        public string Content { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public bool IsEncrypted { get; set; }
        public string Role { get; set; }
    }
}
