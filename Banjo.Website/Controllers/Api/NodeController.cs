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
        INodeService noteService;

        public NodeController(IMappingEngine mapper, INodeService noteService)
        {
            this.mapper = mapper;
            this.noteService = noteService;
        }

        [Route("")]
        public IEnumerable<NodeDto> GetNotes()
        {
            var notes = noteService.GetNodes().ToList();
            var dto = mapper.Map<IEnumerable<NodeDto>>(notes);
            return dto;
        }
    }
}
