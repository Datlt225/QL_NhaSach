using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_NhaSach.Class
{
    class XL_LOAITK : XL_BANG
    {
        public XL_LOAITK() : base("LOAITK") { }
        public XL_LOAITK(string pQuery) : base("LOAITK", pQuery) { }
    }
}
