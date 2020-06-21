using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_CHAMCONG : XL_BANG
    {
        public XL_CHAMCONG() : base("CHAMCONG") { }
        public XL_CHAMCONG(string pQuery) : base("CHAMCONG",pQuery) { } 
    }
}
