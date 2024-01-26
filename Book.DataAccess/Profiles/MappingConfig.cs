using AutoMapper;
using Book.Models;
using System.Security.Principal;

namespace Book.DataAccess.Profiles
{
    public class MappingConfig : Profile
    {
        public MappingConfig()
        {
            CreateMap<Company, GetCompany>();
            CreateMap<GetCompany, Company>();
        }
    }
}
