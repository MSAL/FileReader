using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileReader.Core
{
    public static class EncryptionUtility
    {

        public static string DecryptData(string encrypted)
        {
            char[] charArray = encrypted.ToCharArray();
            Array.Reverse(charArray);

            return new string(charArray);
        }
    }
}
