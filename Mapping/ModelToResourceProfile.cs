using AutoMapper;
using Kanban.API.Domain.Models;

namespace Kanban.API.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Card, CardResponse>();
        }
    }
}