using AutoMapper;
using Banjo.Website.Dto;
using Banjo.Website.Model;

namespace Banjo.Website
{
    public class MappingConfig
    {
        public static void Initialize()
        {
            Mapper.CreateMap<Node, NodeDto>();
        }
    }
}