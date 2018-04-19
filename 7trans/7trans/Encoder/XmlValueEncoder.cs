using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security;

namespace _7trans.Encoder
{
    class XmlValueEncoder
    {
        public string encode(string q)
        {
            return SecurityElement.Escape(q);
        }
        public string decode(string q)
        {
            return q.Replace("&lt;", "<")
                    .Replace("&gt;", ">")
                    .Replace("&quot;", "\"")
                    .Replace("&apos;", "'")
                    .Replace("&amp;", "&");
        }
    }
}
