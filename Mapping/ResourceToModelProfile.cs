using AutoMapper;
using Kanban.API.Domain.Models;
using Kanban.API.Domain.Resources;

namespace Kanban.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<CardCreate, Card>();
        }
    }
}