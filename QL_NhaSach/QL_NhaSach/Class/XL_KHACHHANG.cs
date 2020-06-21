using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_KHACHHANG : XL_BANG
    {
        public XL_KHACHHANG() : base("KHANHHANG") { }
        public XL_KHACHHANG(string pQuery) : base("KHACHHANG", pQuery) { }
    }
}
