using NoteApps.Models;
using NoteApps.Services;


namespace NoteApps.Controllers
{
    public class NoteController
    {
        private readonly NoteService _noteService;

        public NoteController(NoteService noteService)
        {
            _noteService = noteService;
        }

        public List<NoteItem> GetAllNote()
        {
            return _noteService.GetAllNote();
        }

        public NoteItem GetNoteById(int id)
        {
            return _noteService.GetNoteById(id);
        }

        public void AddNote(string noteName, string noteDescription, string status)
        {
            var noteItem = new NoteItem
            {
                NoteName = noteName,
                NoteDescription = noteDescription,
                Status = status
            };
            _noteService.AddNote(noteItem);
        }

        public void UpdateNote(int id, string noteName, string noteDescription, string status)
        {
            var noteItem = _noteService.GetNoteById(id);
            if (noteItem != null)
            {
                noteItem.NoteName = noteName;
                noteItem.NoteDescription = noteDescription;
                noteItem.Status = status;
                _noteService.UpdateNote(noteItem);
            }
        }

        public void DeleteNote(int id)
        {
            _noteService.DeleteNote(id);
        }
    }
}
