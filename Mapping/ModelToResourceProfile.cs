using AutoMapper;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Resources;

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