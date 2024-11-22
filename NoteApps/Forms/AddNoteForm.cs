using NoteApps.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NoteApps.Controllers;
using NoteApps.DAO;
using NoteApps.Data;
using NoteApps.Services;

namespace NoteApps.Forms
{
    public partial class AddNoteForm : Form
    {
        private readonly NoteController _noteController;
        public event Action NoteAdded;
        public AddNoteForm()
        {
            InitializeComponent();
            var context = new ApplicationDbContext();
            var taskRepository = new NoteRepository(context);
            var taskService = new NoteService(taskRepository);
            _noteController = new NoteController(taskService);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveTask_Click(object sender, EventArgs e)
        {

            string taskName = txtTaskName.Text;
            string description = rtxtDescription.Text;
            string status = cboStatus.Text;

            _noteController.AddNote(taskName, description, status);
            MessageBox.Show("Added Successfully", "Information");

            //Raise the event to notify the Main Form
            NoteAdded?.Invoke();
            this.Close();


        }
    }
}
