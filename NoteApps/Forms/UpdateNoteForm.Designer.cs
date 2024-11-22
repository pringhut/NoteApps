namespace NoteApps.Forms
{
    partial class UpdateNoteForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSaveTask = new Button();
            cboStatus = new ComboBox();
            rtxtDescription = new RichTextBox();
            txtTaskName = new TextBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnSaveTask);
            panel1.Controls.Add(cboStatus);
            panel1.Controls.Add(rtxtDescription);
            panel1.Controls.Add(txtTaskName);
            panel1.Location = new Point(-1, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 347);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(107, 141);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 7;
            label4.Text = "Description";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 233);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 6;
            label3.Text = "Status";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(262, 22);
            label2.Name = "label2";
            label2.Size = new Size(71, 15);
            label2.TabIndex = 5;
            label2.Text = "UpdateNote";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 59);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Note Name";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(210, 290);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(86, 43);
            btnSaveTask.TabIndex = 3;
            btnSaveTask.Text = "Update";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(212, 233);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(154, 23);
            cboStatus.TabIndex = 2;
            cboStatus.SelectedIndexChanged += cboStatus_SelectedIndexChanged;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(210, 94);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(196, 99);
            rtxtDescription.TabIndex = 1;
            rtxtDescription.Text = "";
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(210, 51);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(168, 23);
            txtTaskName.TabIndex = 0;
            // 
            // UpdateNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(759, 349);
            Controls.Add(panel1);
            Name = "UpdateNoteForm";
            Text = "UpdateNoteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button btnSaveTask;
        private ComboBox cboStatus;
        private RichTextBox rtxtDescription;
        private TextBox txtTaskName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}