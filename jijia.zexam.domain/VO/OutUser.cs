using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.VO
{
    public class OutUser
    {
        public int id { get; set; }
        public string username { get; set; }
        public string pwd { get; set; }
        public int sex { get; set; }
        public string studydate { get; set; }
        public int classid { get; set; }
        public string phone { get; set; }
        public int isenabled { get; set; }
    }
}
