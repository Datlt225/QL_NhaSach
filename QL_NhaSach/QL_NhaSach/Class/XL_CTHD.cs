using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_CTHD: XL_BANG
    {
        public XL_CTHD() : base("CTHD") { }
        public XL_CTHD(string pQuery) : base("CTHD", pQuery) { }
    }
}
