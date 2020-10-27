using AutoMapper;
using kanban.API.Resources;
using Kanban.API.Domain.Models;

namespace Kanban.API.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<CardCreate, Card>();
            CreateMap<LoginCreate, User>();

        }
    }
}