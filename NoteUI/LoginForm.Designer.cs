namespace NoteUI
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            nameTxtBox = new TextBox();
            emailTxtBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loginBtn = new Button();
            leaveBtn = new Button();
            createAccountLabel = new LinkLabel();
            forgetPwdLabel = new LinkLabel();
            SuspendLayout();
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(168, 86);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(315, 43);
            nameTxtBox.TabIndex = 0;
            // 
            // emailTxtBox
            // 
            emailTxtBox.Location = new Point(168, 233);
            emailTxtBox.Name = "emailTxtBox";
            emailTxtBox.Size = new Size(315, 43);
            emailTxtBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 86);
            label1.Name = "label1";
            label1.Size = new Size(105, 38);
            label1.TabIndex = 2;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 233);
            label2.Name = "label2";
            label2.Size = new Size(97, 38);
            label2.TabIndex = 3;
            label2.Text = "Email :";
            // 
            // loginBtn
            // 
            loginBtn.Location = new Point(27, 334);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(133, 51);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Log in";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += loginBtn_Click;
            // 
            // leaveBtn
            // 
            leaveBtn.Location = new Point(350, 334);
            leaveBtn.Name = "leaveBtn";
            leaveBtn.Size = new Size(133, 51);
            leaveBtn.TabIndex = 5;
            leaveBtn.Text = "Leave";
            leaveBtn.UseVisualStyleBackColor = true;
            leaveBtn.Click += leaveBtn_Click;
            // 
            // createAccountLabel
            // 
            createAccountLabel.AutoSize = true;
            createAccountLabel.Location = new Point(27, 421);
            createAccountLabel.Name = "createAccountLabel";
            createAccountLabel.Size = new Size(206, 38);
            createAccountLabel.TabIndex = 6;
            createAccountLabel.TabStop = true;
            createAccountLabel.Text = "Create Account";
            // 
            // forgetPwdLabel
            // 
            forgetPwdLabel.AutoSize = true;
            forgetPwdLabel.Location = new Point(277, 421);
            forgetPwdLabel.Name = "forgetPwdLabel";
            forgetPwdLabel.Size = new Size(233, 38);
            forgetPwdLabel.TabIndex = 7;
            forgetPwdLabel.TabStop = true;
            forgetPwdLabel.Text = "Forget Password?";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 468);
            Controls.Add(forgetPwdLabel);
            Controls.Add(createAccountLabel);
            Controls.Add(leaveBtn);
            Controls.Add(loginBtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(emailTxtBox);
            Controls.Add(nameTxtBox);
            Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(6);
            Name = "LoginForm";
            Text = "Login ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTxtBox;
        private TextBox emailTxtBox;
        private Label label1;
        private Label label2;
        private Button loginBtn;
        private Button leaveBtn;
        private LinkLabel createAccountLabel;
        private LinkLabel forgetPwdLabel;
    }
}