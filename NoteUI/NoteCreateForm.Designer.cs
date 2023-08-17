namespace NoteUI
{
    partial class NoteCreateForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NoteCreateForm));
            creatorLabel = new Label();
            creatorTxtBox = new TextBox();
            noteTxtBox = new TextBox();
            noteTitleTxtBox = new TextBox();
            NoteName = new Label();
            coeditCheckBox = new CheckBox();
            createBtn = new Button();
            noteTypeComboBox = new ComboBox();
            NoteTypeLabel = new Label();
            emailTxtBox = new TextBox();
            EmailLbel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // creatorLabel
            // 
            creatorLabel.AutoSize = true;
            creatorLabel.Location = new Point(12, 22);
            creatorLabel.Name = "creatorLabel";
            creatorLabel.Size = new Size(122, 38);
            creatorLabel.TabIndex = 0;
            creatorLabel.Text = "Creator :";
            // 
            // creatorTxtBox
            // 
            creatorTxtBox.Location = new Point(128, 22);
            creatorTxtBox.Name = "creatorTxtBox";
            creatorTxtBox.Size = new Size(205, 43);
            creatorTxtBox.TabIndex = 1;
            creatorTxtBox.TextChanged += textBox1_TextChanged;
            // 
            // noteTxtBox
            // 
            noteTxtBox.Location = new Point(12, 194);
            noteTxtBox.Multiline = true;
            noteTxtBox.Name = "noteTxtBox";
            noteTxtBox.Size = new Size(815, 401);
            noteTxtBox.TabIndex = 2;
            // 
            // noteTitleTxtBox
            // 
            noteTitleTxtBox.Location = new Point(102, 89);
            noteTitleTxtBox.Name = "noteTitleTxtBox";
            noteTitleTxtBox.Size = new Size(725, 43);
            noteTitleTxtBox.TabIndex = 6;
            // 
            // NoteName
            // 
            NoteName.AutoSize = true;
            NoteName.Location = new Point(12, 89);
            NoteName.Name = "NoteName";
            NoteName.Size = new Size(84, 38);
            NoteName.TabIndex = 5;
            NoteName.Text = "Title :";
            // 
            // coeditCheckBox
            // 
            coeditCheckBox.AutoSize = true;
            coeditCheckBox.Location = new Point(462, 620);
            coeditCheckBox.Name = "coeditCheckBox";
            coeditCheckBox.Size = new Size(236, 42);
            coeditCheckBox.TabIndex = 8;
            coeditCheckBox.Text = "Allowed Co-Edit";
            coeditCheckBox.UseVisualStyleBackColor = true;
            // 
            // createBtn
            // 
            createBtn.Location = new Point(704, 619);
            createBtn.Name = "createBtn";
            createBtn.Size = new Size(123, 43);
            createBtn.TabIndex = 7;
            createBtn.Text = "Create";
            createBtn.UseVisualStyleBackColor = true;
            createBtn.Click += createBtn_Click;
            // 
            // noteTypeComboBox
            // 
            noteTypeComboBox.FormattingEnabled = true;
            noteTypeComboBox.Location = new Point(168, 617);
            noteTypeComboBox.Name = "noteTypeComboBox";
            noteTypeComboBox.Size = new Size(288, 45);
            noteTypeComboBox.TabIndex = 9;
            noteTypeComboBox.SelectedIndexChanged += noteTypeComboBox_SelectedIndexChanged;
            // 
            // NoteTypeLabel
            // 
            NoteTypeLabel.AutoSize = true;
            NoteTypeLabel.Location = new Point(12, 617);
            NoteTypeLabel.Name = "NoteTypeLabel";
            NoteTypeLabel.Size = new Size(150, 38);
            NoteTypeLabel.TabIndex = 10;
            NoteTypeLabel.Text = "NoteType :";
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(462, 22);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(365, 43);
            emailTxtBox.TabIndex = 12;
            emailTxtBox.TextChanged += textBox2_TextChanged;
            // 
            // EmailLbel
            // 
            EmailLbel.AutoSize = true;
            EmailLbel.Location = new Point(359, 22);
            EmailLbel.Name = "EmailLbel";
            EmailLbel.Size = new Size(97, 38);
            EmailLbel.TabIndex = 11;
            EmailLbel.Text = "Email :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 140);
            label1.Name = "label1";
            label1.Size = new Size(121, 38);
            label1.TabIndex = 13;
            label1.Text = "Content:";
            // 
            // NoteCreateForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 687);
            Controls.Add(label1);
            Controls.Add(emailTxtBox);
            Controls.Add(EmailLbel);
            Controls.Add(NoteTypeLabel);
            Controls.Add(noteTypeComboBox);
            Controls.Add(coeditCheckBox);
            Controls.Add(createBtn);
            Controls.Add(noteTitleTxtBox);
            Controls.Add(NoteName);
            Controls.Add(noteTxtBox);
            Controls.Add(creatorTxtBox);
            Controls.Add(creatorLabel);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "NoteCreateForm";
            Text = "Create A Note";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label creatorLabel;
        private TextBox creatorTxtBox;
        private TextBox noteTxtBox;
        private TextBox noteTitleTxtBox;
        private Label NoteName;
        private CheckBox coeditCheckBox;
        private Button createBtn;
        private ComboBox noteTypeComboBox;
        private Label NoteTypeLabel;
        private TextBox emailTxtBox;
        private Label EmailLbel;
        private Label label1;
    }
}