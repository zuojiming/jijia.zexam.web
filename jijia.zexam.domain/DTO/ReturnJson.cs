using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.DTO
{
    public class ReturnModel
    {
        public string m { get; set; } = string.Empty;
        public bool s { get; set; } = false;
        public object d { get; set; } = null;
    }
}
