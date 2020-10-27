using AutoMapper;
using kanban.API.Resources;
using kanban.Domain.Security.Tokens;
using Kanban.API.Domain.Models;

namespace Kanban.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Card, CardResponse>();

            CreateMap<AccessToken, AccessTokenResource>()
               .ForMember(a => a.AccessToken, opt => opt.MapFrom(a => a.Token))
               .ForMember(a => a.RefreshToken, opt => opt.MapFrom(a => a.RefreshToken.Token))
               .ForMember(a => a.Expiration, opt => opt.MapFrom(a => a.Expiration));
        }
    }
}