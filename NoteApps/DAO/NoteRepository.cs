using NoteApps.Data;
using NoteApps.Models;


namespace NoteApps.DAO
{
    public class NoteRepository
    {
        private readonly ApplicationDbContext _context;

        public NoteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public List<NoteItem> GetAllNote()
        {
            return _context.NoteItems.ToList();
        }

        public NoteItem GetNoteById(int id)
        {
            return _context.NoteItems.Find(id);
        }

        public void AddNote(NoteItem noteItem)
        {
            _context.NoteItems.Add(noteItem);
            _context.SaveChanges();
        }
        public void UpdateNote(NoteItem noteItem)
        {
            _context.NoteItems.Update(noteItem);
            _context.SaveChanges();
        }
        public void DeleteNote(int id)
        {
            var note = _context.NoteItems.Find(id);
            if (note != null)
            {
                _context.NoteItems.Remove(note);
                _context.SaveChanges();
            }
        }
    }
}
