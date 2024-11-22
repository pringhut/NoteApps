namespace NoteApps.Forms
{
    partial class AddNoteForm
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
            txtTaskName = new TextBox();
            rtxtDescription = new RichTextBox();
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
            panel1.Controls.Add(txtTaskName);
            panel1.Controls.Add(rtxtDescription);
            panel1.Location = new Point(-2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 450);
            panel1.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(197, 64);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 7;
            label4.Text = "Add Note";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 207);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 6;
            label3.Text = "Description";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 294);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 108);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 4;
            label1.Text = "Note Name";
            // 
            // btnSaveTask
            // 
            btnSaveTask.Location = new Point(126, 342);
            btnSaveTask.Name = "btnSaveTask";
            btnSaveTask.Size = new Size(75, 23);
            btnSaveTask.TabIndex = 3;
            btnSaveTask.Text = "Save";
            btnSaveTask.UseVisualStyleBackColor = true;
            btnSaveTask.Click += btnSaveTask_Click;
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(126, 294);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(121, 23);
            cboStatus.TabIndex = 2;
            cboStatus.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // txtTaskName
            // 
            txtTaskName.Location = new Point(126, 100);
            txtTaskName.Name = "txtTaskName";
            txtTaskName.Size = new Size(224, 23);
            txtTaskName.TabIndex = 1;
            // 
            // rtxtDescription
            // 
            rtxtDescription.Location = new Point(126, 153);
            rtxtDescription.Name = "rtxtDescription";
            rtxtDescription.Size = new Size(224, 112);
            rtxtDescription.TabIndex = 0;
            rtxtDescription.Text = "";
            rtxtDescription.TextChanged += richTextBox1_TextChanged;
            // 
            // AddNoteForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "AddNoteForm";
            Text = "AddNoteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private ComboBox cboStatus;
        private TextBox txtTaskName;
        private RichTextBox rtxtDescription;
        private Button btnSaveTask;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
    }
}