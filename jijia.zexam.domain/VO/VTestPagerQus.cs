using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.VO
{
    public class VTestPagerQus
    {
        public int categary { get; set; }
        public int year { get; set; }
        public string subject { get; set; }
        public int id { get; set; }
        public string title { get; set; }
        public string type { get; set; }
        public List<VTestPagerQusAnwser> anwser { get; set; }
    }
}
