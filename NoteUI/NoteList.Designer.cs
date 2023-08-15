﻿namespace NoteUI
{
    partial class NoteListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteListForm));
            searchTxtBox = new TextBox();
            noteListBox = new ListBox();
            searchBtn = new Button();
            createBtn = new Button();
            editBtn = new Button();
            deleteBtn = new Button();
            SuspendLayout();
            // 
            // searchTxtBox
            // 
            searchTxtBox.Location = new Point(155, 24);
            searchTxtBox.Name = "searchTxtBox";
            searchTxtBox.Size = new Size(296, 43);
            searchTxtBox.TabIndex = 1;
            // 
            // noteListBox
            // 
            noteListBox.FormattingEnabled = true;
            noteListBox.ItemHeight = 37;
            noteListBox.Location = new Point(12, 90);
            noteListBox.Name = "noteListBox";
            noteListBox.Size = new Size(439, 448);
            noteListBox.TabIndex = 2;
            // 
            // searchBtn
            // 
            searchBtn.Location = new Point(12, 24);
            searchBtn.Name = "searchBtn";
            searchBtn.Size = new Size(137, 43);
            searchBtn.TabIndex = 3;
            searchBtn.Text = "Search";
            searchBtn.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(526, 90);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(137, 43);
            createBtn.TabIndex = 4;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            // 
            // editBtn
            // 
            editBtn.Location = new Point(526, 281);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(137, 43);
            editBtn.TabIndex = 5;
            editBtn.Text = "Edit";
            editBtn.UseVisualStyleBackColor = true;
            // 
            // deleteBtn
            // 
            deleteBtn.Location = new Point(526, 495);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(137, 43);
            deleteBtn.TabIndex = 6;
            deleteBtn.Text = "Delete";
            deleteBtn.UseVisualStyleBackColor = true;
            // 
            // NoteListForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(704, 560);
            Controls.Add(deleteBtn);
            Controls.Add(editBtn);
            Controls.Add(createBtn);
            Controls.Add(searchBtn);
            Controls.Add(noteListBox);
            Controls.Add(searchTxtBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6, 6, 6, 6);
            Name = "NoteListForm";
            Text = "Note List";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox searchTxtBox;
        private ListBox noteListBox;
        private Button searchBtn;
        private Button createBtn;
        private Button editBtn;
        private Button deleteBtn;
    }
}