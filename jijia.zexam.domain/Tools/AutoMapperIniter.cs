using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.Mappers;
using jijia.zexam.domain.models;
using jijia.zexam.domain.VO;

namespace jijia.zexam.domain.Tools
{
    public class AutoMapperIniter
    {
        public static void Init() {
            Mapper.Initialize(c => {
                c.AddProfile(new TestPagerProfile());
                c.AddProfile(new TestPagerQusPrfile());
                c.AddProfile(new InUserPrfile());
                c.AddProfile(new OutUserPrfile());
            });
        }
    }

    public class TestPagerProfile : Profile {
        public TestPagerProfile()
        {
            this.CreateMap<T_TestPaper,VTestPaper>()
                .ForMember<string>(f => f.desc, t => t.MapFrom<string>(m=>m.Desc))
                .ForMember<int>(f => f.id, t=>t.MapFrom<int>(m => m.Id))
                .ForMember<string>(f=>f.name,t=>t.MapFrom<string>(m => m.Name))
                .ForMember<string>(f => f.title,t=>t.MapFrom<string>(m => m.Title))
                .ForMember<float>(f => f.totalscore, t=> t.MapFrom<double>(m => m.TotalScore.HasValue ? m.TotalScore.Value : 0));
        }
    }

    public class TestPagerQusPrfile : Profile {
        public TestPagerQusPrfile()
        {
            this.CreateMap<T_CharpterQuestion,VTestPagerQusAnwser>();
        }
    }

    public class InUserPrfile : Profile
    {
        public InUserPrfile()
        {
            this.CreateMap<S_User, VInUser>();
        }
    }

    public class OutUserPrfile : Profile
    {
        public OutUserPrfile()
        {
            this.CreateMap<S_User, VOutUser>();
        }
    }
}
