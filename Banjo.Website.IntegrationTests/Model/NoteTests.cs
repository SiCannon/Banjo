using System;
using Banjo.Website.Database;
using Banjo.Website.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Banjo.Website.IntegrationTests.Model
{
    [TestClass]
    public class NoteTests
    {
        [TestMethod]
        public void Can_Save_Note()
        {
            var note = new Note { Text = "Test Note " + DateTime.Now.ToString() };
            var db = new BanjoContext();
            db.Notes.Add(note);
            db.SaveChanges();
            Assert.IsNotNull(note.NoteId);
            Assert.AreNotEqual(0, note.NoteId);
        }
    }
}
