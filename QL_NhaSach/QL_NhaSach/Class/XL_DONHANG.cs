using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_DONHANG : XL_BANG
    {
        public XL_DONHANG() : base("DONHANG") { }
        public XL_DONHANG(string pQuery) : base("DONHANG", pQuery) { }
    }
}
