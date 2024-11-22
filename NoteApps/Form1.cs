using NoteApps.Controllers;
using NoteApps.DAO;
using NoteApps.Data;
using NoteApps.Models;
using NoteApps.Services;
using NoteApps.Forms;
using Microsoft.EntityFrameworkCore;
using System.Windows.Forms;

namespace NoteApps
{
    public partial class Form1 : Form
    {
        public readonly NoteController _noteController;
        public Form1()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var noteRepository = new NoteRepository(context);
            var noteService = new NoteService(noteRepository);
            _noteController = new NoteController(noteService);
        }

        private void btnAddNote_Click(object sender, EventArgs e)
        {
            var addNoteForm = new AddNoteForm();
            addNoteForm.NoteAdded += LoadNote;
            addNoteForm.ShowDialog();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNote();
        }
        private void LoadNote()
        {
            var notes = _noteController.GetAllNote();
            flowLayoutPanel1.Controls.Clear();
            foreach (var note in notes)
            {
                AddNoteCard(note);
            }
        }

        private void AddNoteCard( NoteItem noteItem)
        {
            var cardPanel = new Panel
            {
                Size = new Size(370, 160),
                BackColor = Color.CadetBlue,
                Margin = new Padding(30),
                Padding = new Padding(10)
            };

            // Delete Icon (Text-Based)
            var deleteIcon = new Label
            {
                Text = "✖", // Unicode character for 'X' symbol
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Red,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 30, 5),
                AutoSize = true
            };
            deleteIcon.Click += (sender, e) => DeleteNote(noteItem);
            cardPanel.Controls.Add(deleteIcon);

            var editIcon = new Label
            {
                Text = "✏", // Unicode character for pencil
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                ForeColor = Color.Gold,
                Cursor = Cursors.Hand,
                Location = new Point(cardPanel.Width - 60, 5),
                AutoSize = true
            };
            editIcon.Click += (sender, e) => UpdateNote(noteItem);
            cardPanel.Controls.Add(editIcon);

            var courseLabel = new Label
            {
                Text = $"{noteItem.NoteName}",
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.DarkSlateGray,
                Location = new Point(10, 10),
                AutoSize = true
            };
            cardPanel.Controls.Add(courseLabel);

            var nameLabel = new Label
            {
                Text = $"{noteItem.NoteDescription}",
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.DimGray,
                Location = new Point(10, 35),
                AutoSize = true
            };
            cardPanel.Controls.Add(nameLabel);


            var viewDetails = new LinkLabel
            {
                Text = "View Details",
                Font = new Font("Segoe UI", 9, FontStyle.Bold),
                ForeColor = Color.Blue,
                Location = new Point(20, 55),
                AutoSize = true
            };
            // Calculate the position for bottom right corner
            viewDetails.Location = new Point(cardPanel.Width - viewDetails.Width - 10, cardPanel.Height - viewDetails.Height - 10);
            viewDetails.LinkClicked += (sender, e) => ShowNoteDetails(noteItem);
            cardPanel.Controls.Add(viewDetails);

            flowLayoutPanel1.Controls.Add(cardPanel);
        }

        private void ShowNoteDetails(NoteItem noteItem)
        {
            MessageBox.Show(noteItem.NoteName);
        }

        private void UpdateNote(NoteItem noteItem)
        {
            // Logic to update the subject
            var updateNoteForm = new UpdateNoteForm(noteItem);
            //var task = _noteController.GetNoteById(noteItem.Id);
            updateNoteForm.NoteUpdated += (updatedNote) =>
            {
                LoadNote();
            };
            //addTaskForm.TaskAdded += LoadTasks;
            updateNoteForm.ShowDialog();
        }
                                                                                
        private void DeleteNote(NoteItem noteItem)
        {
            var confirmResult = MessageBox.Show($"Are you sure to delete {noteItem.NoteName}?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                _noteController.DeleteNote(noteItem.Id);
                LoadNote(); // Refresh the subjects list
            }

        }


    }
}
