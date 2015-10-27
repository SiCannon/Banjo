using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Banjo.Website.Controllers.Api
{
    [RoutePrefix("api/note")]
    public class NoteController : ApiController
    {
        [Route("")]
        public List<string> GetNotes()
        {
            return new List<string>
            {
                "One",
                "Two",
                "Three"

            };
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
