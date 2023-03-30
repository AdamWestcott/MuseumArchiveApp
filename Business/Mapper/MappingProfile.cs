using AutoMapper;
using DataAccess.Data;
using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Mapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {

            CreateMap<ArchivalItemDTO, ArchivalItem>();
            CreateMap<ArchivalItem, ArchivalItemDTO>();

            CreateMap<ProvidenceDTO, Providences>();
            CreateMap<Providences, ProvidenceDTO>();
        }
    }
}
