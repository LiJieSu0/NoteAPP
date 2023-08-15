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
            textBox1 = new TextBox();
            NoteName = new Label();
            coeditCheckBox = new CheckBox();
            createBtn = new Button();
            noteTypeComboBox = new ComboBox();
            NoteTypeLabel = new Label();
            textBox2 = new TextBox();
            EmailLbel = new Label();
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
            noteTxtBox.Location = new Point(12, 153);
            noteTxtBox.Multiline = true;
            noteTxtBox.Name = "noteTxtBox";
            noteTxtBox.Size = new Size(815, 435);
            noteTxtBox.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 89);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(725, 43);
            textBox1.TabIndex = 6;
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
            // 
            // noteTypeComboBox
            // 
            noteTypeComboBox.FormattingEnabled = true;
            noteTypeComboBox.Location = new Point(168, 617);
            noteTypeComboBox.Name = "noteTypeComboBox";
            noteTypeComboBox.Size = new Size(288, 45);
            noteTypeComboBox.TabIndex = 9;
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
            // textBox2
            // 
            textBox2.Location = new Point(462, 22);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(365, 43);
            textBox2.TabIndex = 12;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // EmailLbel
            // 
            EmailLbel.AutoSize = true;
            EmailLbel.Location = new Point(359, 22);
            EmailLbel.Name = "EmailLbel";
            EmailLbel.Size = new Size(97, 38);
            EmailLbel.TabIndex = 11;
            EmailLbel.Text = "Email :";
            EmailLbel.Click += label1_Click;
            // 
            // NoteCreateForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(839, 687);
            Controls.Add(textBox2);
            Controls.Add(EmailLbel);
            Controls.Add(NoteTypeLabel);
            Controls.Add(noteTypeComboBox);
            Controls.Add(coeditCheckBox);
            Controls.Add(createBtn);
            Controls.Add(textBox1);
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
        private TextBox textBox1;
        private Label NoteName;
        private CheckBox coeditCheckBox;
        private Button createBtn;
        private ComboBox noteTypeComboBox;
        private Label NoteTypeLabel;
        private TextBox textBox2;
        private Label EmailLbel;
    }
}