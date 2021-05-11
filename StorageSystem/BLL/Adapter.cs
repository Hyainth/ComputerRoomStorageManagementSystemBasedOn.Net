using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class Adapter : MD5adapter
    {
        public string Md5(string str)
        {
            return MD5adapter.Encrypt(str);
        }
    }
}
