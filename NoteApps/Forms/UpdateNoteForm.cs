using NoteApps.Controllers;
using NoteApps.DAO;
using NoteApps.Data;
using NoteApps.Models;
using NoteApps.Services;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoteApps.Forms
{
    public partial class UpdateNoteForm : Form
    {
        private NoteItem _task;
        private NoteItem? note;
        internal Action<object> NoteUpdated;

        public UpdateNoteForm(NoteItem noteItem)
        {
            InitializeComponent();
            _task = note;
            PopulateFormFields();
        }
        private void PopulateFormFields()
        {
            if (_task != null)
            {
                // Assuming the form has TextBox controls named `txtSubject` and `txtDescription`
                txtTaskName.Text = _task.TaskName;
                rtxtDescription.Text = _task.TaskDescription;
                cboStatus.Text = _task.Status;
                // Add more fields as needed
            }
        }


        private void btnSaveTask_Click(object sender, EventArgs e)
        {

        }

        private void cboStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
