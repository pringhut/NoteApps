﻿using NoteApps.DAO;
using NoteApps.Models;

namespace NoteApps.Services
{
    public class NoteService
    {
        private readonly NoteRepository _noteRepository;
        public NoteService(NoteRepository noteRepository)
        {
            _noteRepository = noteRepository;
        }

        public List<NoteItem> GetAllNote()
        {
            return _noteRepository.GetAllNote();
        }
        public NoteItem GetNoteById(int id)
        {
            return _noteRepository.GetNoteById(id);
        }
        public void AddNote(NoteItem noteItem)
        {
            _noteRepository.AddNote(noteItem);
        }
        public void DeleteNote(int id)
        {
            _noteRepository.DeleteNote(id);
        }
        public void UpdateNote(NoteItem noteItem)
        {
            _noteRepository.UpdateNote(noteItem);
        }

    }
}
