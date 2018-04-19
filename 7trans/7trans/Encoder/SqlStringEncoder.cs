using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace _7trans.Encoder
{
    class SqlStringEncoder
    {
        public string encode(string q)
        {
            return q.Replace("'", "''")
                    .Replace("\\", "\\\\");
        }
        public string decode(string q)
        {
            return q.Replace("\\\\", "\\")
                    .Replace("''", "'");
        }
    }
}
