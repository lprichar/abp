﻿using AutoMapper;
using Volo.Abp.AutoMapper;
using Volo.Docs.Documents;

namespace Volo.Docs
{
    public class DocsWebAutoMapperProfile : Profile
    {
        public DocsWebAutoMapperProfile()
        {
            CreateMap<DocumentWithDetailsDto, NavigationWithDetailsDto>()
                .Ignore(x => x.RootNode);
        }
    }
}
