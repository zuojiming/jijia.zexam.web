using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.VO
{
    public class VTestPagerQusCategary
    {
        public int type { get; set; }
        public int count { get; set; }
        public int itemscore { get; set; }
        public List<VTestPagerQus> qus { get; set; }
    }
}
