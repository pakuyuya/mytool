using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7trans.Encoder
{
    class CsvValueEncoder
    {
        public string encode(string q)
        {
            return q.Replace("\\", "\\\\").Replace("\"", "\\\"");
        }
        public string decode(string q)
        {
            StringBuilder sb = new StringBuilder();

            bool lastIsEscape = false;
            foreach (char c in q)
            {
                bool prevIsEscape = lastIsEscape;
                lastIsEscape = false;

                if (!prevIsEscape && c == '\\')
                {
                    lastIsEscape = true;
                    continue;
                }
                sb.Append(c);
            }

            return sb.ToString();
        }
    }
}
