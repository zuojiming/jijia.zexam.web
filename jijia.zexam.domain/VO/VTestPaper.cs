using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.VO
{
    public class VTestPaper
    {
        public string name { get; set; }
        public string title { get; set; }
        public float totalscore { get; set; }
        public string desc { get; set; }
        public int id { get; set; }
        public List<VTestPagerQusCategary> qustypes { get; set; }
    }
}
