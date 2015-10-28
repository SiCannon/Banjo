using System.Collections.Generic;
using Banjo.Website.Model;

namespace Banjo.Website.ServiceInterface
{
    public interface INoteService
    {
        IEnumerable<Note> GetNotes();
    }
}
