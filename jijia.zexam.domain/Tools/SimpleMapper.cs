using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jijia.zexam.domain.Tools
{
    public class SimpleMapper:AutoMapper.Mapper
    {
        public SimpleMapper(IConfigurationProvider configurationProvider) : base(configurationProvider) { }
        public SimpleMapper(IConfigurationProvider configurationProvider, Func<Type, object> serviceCtor) : base(configurationProvider, serviceCtor) { }
    }
}
