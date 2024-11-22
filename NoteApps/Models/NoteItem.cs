using System.ComponentModel.DataAnnotations;
namespace NoteApps.Models
{
    public class NoteItem
    {
        internal readonly string TaskName;
        internal readonly string TaskDescription;

        [Key]
        public int Id { get; set; }
        public string NoteName { get; set; }
        public string NoteDescription { get; set; }
        public string Status { get; set; }
    }
}
