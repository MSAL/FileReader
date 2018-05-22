using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Core
{
    public interface ITextFileReader
    {
        void ReadText(FileContainer file);
    }
}
