using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_LOAISP : XL_BANG
    {
        public XL_LOAISP() : base("LOAISP") { }
        public XL_LOAISP(string pQuery) : base("LOAISP", pQuery) { }
    }
}
