using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_SANPHAM : XL_BANG
    {
        public XL_SANPHAM() : base("SANPHAM") { }
        public XL_SANPHAM(string pQuery) : base("SANPHAM", pQuery) { }
    }
}
