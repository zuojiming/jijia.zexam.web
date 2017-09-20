using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.VO
{
    public class VLoginModel
    {
        public string username { get; set; }
        public string pwd { get; set; }
        public int categary { get; set; } = 0;
    }
}
