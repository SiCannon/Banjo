using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Banjo.Website.Dto;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Controllers.Api
{
    [RoutePrefix("api/note")]
    public class NoteController : ApiController
    {
        IMappingEngine mapper;
        INoteService noteService;

        public NoteController(IMappingEngine mapper, INoteService noteService)
        {
            this.mapper = mapper;
            this.noteService = noteService;
        }

        [Route("")]
        public IEnumerable<NoteDto> GetNotes()
        {
            var notes = noteService.GetNotes().ToList();
            var dto = mapper.Map<IEnumerable<NoteDto>>(notes);
            return dto;
        }

        public List<string> Get(int id)
        {
            return new List<string>
            {
                "one"
            };
        }

        [HttpGet]
        public string Farts()
        {
            return "custard";
        }
    }
}
