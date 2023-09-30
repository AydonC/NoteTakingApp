namespace NoteTakingApp
{
    partial class NoteApp
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
            this.textEntry = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.textForEntry = new System.Windows.Forms.GroupBox();
            this.createNote = new System.Windows.Forms.Button();
            this.sideNote = new System.Windows.Forms.Label();
            this.listOfNotes = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textEntry
            // 
            this.textEntry.BackColor = System.Drawing.SystemColors.Info;
            this.textEntry.Location = new System.Drawing.Point(40, 113);
            this.textEntry.Multiline = true;
            this.textEntry.Name = "textEntry";
            this.textEntry.Size = new System.Drawing.Size(351, 115);
            this.textEntry.TabIndex = 0;
            this.textEntry.TextChanged += new System.EventHandler(this.textEntry_TextChanged);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Transparent;
            this.title.Font = new System.Drawing.Font("MV Boli", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.title.Location = new System.Drawing.Point(12, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(307, 39);
            this.title.TabIndex = 1;
            this.title.Text = "NOTE-TAKING APP";
            // 
            // textForEntry
            // 
            this.textForEntry.BackColor = System.Drawing.Color.Transparent;
            this.textForEntry.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textForEntry.Location = new System.Drawing.Point(27, 94);
            this.textForEntry.Name = "textForEntry";
            this.textForEntry.Size = new System.Drawing.Size(383, 147);
            this.textForEntry.TabIndex = 2;
            this.textForEntry.TabStop = false;
            this.textForEntry.Text = "Enter your note";
            // 
            // createNote
            // 
            this.createNote.BackColor = System.Drawing.Color.Sienna;
            this.createNote.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.createNote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createNote.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNote.Location = new System.Drawing.Point(295, 247);
            this.createNote.Name = "createNote";
            this.createNote.Size = new System.Drawing.Size(115, 44);
            this.createNote.TabIndex = 3;
            this.createNote.Text = "Create Note!";
            this.createNote.UseVisualStyleBackColor = false;
            this.createNote.Click += new System.EventHandler(this.createNote_Click);
            // 
            // sideNote
            // 
            this.sideNote.AutoSize = true;
            this.sideNote.BackColor = System.Drawing.Color.Transparent;
            this.sideNote.Font = new System.Drawing.Font("MV Boli", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sideNote.Location = new System.Drawing.Point(16, 48);
            this.sideNote.Name = "sideNote";
            this.sideNote.Size = new System.Drawing.Size(199, 17);
            this.sideNote.TabIndex = 4;
            this.sideNote.Text = "Create and save your notes";
            // 
            // listOfNotes
            // 
            this.listOfNotes.BackColor = System.Drawing.SystemColors.Info;
            this.listOfNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listOfNotes.Font = new System.Drawing.Font("MV Boli", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfNotes.FormattingEnabled = true;
            this.listOfNotes.HorizontalScrollbar = true;
            this.listOfNotes.ItemHeight = 16;
            this.listOfNotes.Location = new System.Drawing.Point(13, 27);
            this.listOfNotes.Name = "listOfNotes";
            this.listOfNotes.Size = new System.Drawing.Size(351, 338);
            this.listOfNotes.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.listOfNotes);
            this.groupBox1.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 313);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 385);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Notes";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Sienna;
            this.deleteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.deleteButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteButton.Font = new System.Drawing.Font("MV Boli", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.Location = new System.Drawing.Point(295, 701);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(115, 44);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("MV Boli", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ExitButton.Location = new System.Drawing.Point(373, 9);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(61, 39);
            this.ExitButton.TabIndex = 6;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // NoteApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::NoteTakingApp.Properties.Resources._4e6879cc00805497a2765d2ee1694a70;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(446, 757);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.sideNote);
            this.Controls.Add(this.createNote);
            this.Controls.Add(this.textEntry);
            this.Controls.Add(this.textForEntry);
            this.Controls.Add(this.title);
            this.Controls.Add(this.groupBox1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NoteApp";
            this.Text = "NoteTakingApp";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textEntry;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.GroupBox textForEntry;
        private System.Windows.Forms.Button createNote;
        private System.Windows.Forms.Label sideNote;
        private System.Windows.Forms.ListBox listOfNotes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

