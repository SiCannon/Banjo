using System.Collections.Generic;
using Banjo.Website.Model;
using Banjo.Website.ServiceInterface;

namespace Banjo.Website.Service
{
    public class NoteService : INoteService
    {
        public IEnumerable<Note> GetNotes()
        {
            return new List<Note>
            {
                new Note { NoteId = 1, Text = "One" },
                new Note { NoteId = 2, Text = "Two" },
                new Note { NoteId = 3, Text = "Three" }
            };
        }
    }
}