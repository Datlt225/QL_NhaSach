using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_NHANVIEN : XL_BANG
    {
        public XL_NHANVIEN() : base("NHANVIEN") { }
        public XL_NHANVIEN(string pQuery) : base("NHANVIEN", pQuery) { }
    }
}
