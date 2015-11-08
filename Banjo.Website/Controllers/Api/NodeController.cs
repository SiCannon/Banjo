using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Banjo.Website.Dto;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Controllers.Api
{
    [RoutePrefix("api/node")]
    public class NodeController : ApiController
    {
        IMappingEngine mapper;
        INodeService nodeService;

        public NodeController(IMappingEngine mapper, INodeService noteService)
        {
            this.mapper = mapper;
            this.nodeService = noteService;
        }

        [Route("all")]
        public IEnumerable<NodeDto> GetAllNodes()
        {
            var nodes = nodeService.GetAll().ToList();
            var dto = mapper.Map<IEnumerable<NodeDto>>(nodes);
            return dto;
        }

        [Route("root")]
        public IEnumerable<NodeDto> GetRootNodes()
        {
            var nodes = nodeService.GetRootNodes().ToList();
            var dto = mapper.Map<IEnumerable<NodeDto>>(nodes);
            return dto;
        }

        [Route("{id:int}/children")]
        public IEnumerable<NodeDto> GetChildNodes(int id)
        {
            var nodes = nodeService.GetChildNodes(id).ToList();
            var dto = mapper.Map<IEnumerable<NodeDto>>(nodes);
            return dto;
        }
    }
}
