using System.Collections.Generic;
using System.Web.Http;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Controllers.Api
{
    [RoutePrefix("api/note")]
    public class NoteController : ApiController
    {
        INoteService noteService;

        public NoteController(INoteService noteService)
        {
            this.noteService = noteService;
        }

        [Route("")]
        public IEnumerable<Banjo.Website.Model.Note> GetNotes()
        {
            return noteService.GetNotes();
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
