namespace personalform
{
    partial class Form3
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
            registerlbl = new Label();
            firstnamelbl = new Label();
            lastnamelbl = new Label();
            firstnametxt = new TextBox();
            lastnametxt = new TextBox();
            usernamelbl = new Label();
            username = new TextBox();
            passwordlbl = new Label();
            password = new MaskedTextBox();
            send = new Button();
            SuspendLayout();
            // 
            // registerlbl
            // 
            registerlbl.AutoSize = true;
            registerlbl.Location = new Point(324, 52);
            registerlbl.Name = "registerlbl";
            registerlbl.Size = new Size(71, 25);
            registerlbl.TabIndex = 0;
            registerlbl.Text = "register";
            // 
            // firstnamelbl
            // 
            firstnamelbl.AutoSize = true;
            firstnamelbl.Location = new Point(115, 118);
            firstnamelbl.Name = "firstnamelbl";
            firstnamelbl.Size = new Size(91, 25);
            firstnamelbl.TabIndex = 1;
            firstnamelbl.Text = "first name";
            // 
            // lastnamelbl
            // 
            lastnamelbl.AutoSize = true;
            lastnamelbl.Location = new Point(118, 161);
            lastnamelbl.Name = "lastnamelbl";
            lastnamelbl.Size = new Size(88, 25);
            lastnamelbl.TabIndex = 2;
            lastnamelbl.Text = "last name";
            // 
            // firstnametxt
            // 
            firstnametxt.Location = new Point(212, 118);
            firstnametxt.Name = "firstnametxt";
            firstnametxt.Size = new Size(150, 31);
            firstnametxt.TabIndex = 3;
            // 
            // lastnametxt
            // 
            lastnametxt.Location = new Point(212, 161);
            lastnametxt.Name = "lastnametxt";
            lastnametxt.Size = new Size(150, 31);
            lastnametxt.TabIndex = 4;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(117, 203);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(89, 25);
            usernamelbl.TabIndex = 5;
            usernamelbl.Text = "username";
            // 
            // username
            // 
            username.Location = new Point(212, 203);
            username.Name = "username";
            username.Size = new Size(150, 31);
            username.TabIndex = 6;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(118, 250);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(89, 25);
            passwordlbl.TabIndex = 7;
            passwordlbl.Text = "password";
            // 
            // password
            // 
            password.Location = new Point(212, 250);
            password.Name = "password";
            password.Size = new Size(150, 31);
            password.TabIndex = 8;
            // 
            // send
            // 
            send.Location = new Point(300, 317);
            send.Name = "send";
            send.Size = new Size(112, 34);
            send.TabIndex = 9;
            send.Text = "send";
            send.UseVisualStyleBackColor = true;
            send.Click += register;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(send);
            Controls.Add(password);
            Controls.Add(passwordlbl);
            Controls.Add(username);
            Controls.Add(usernamelbl);
            Controls.Add(lastnametxt);
            Controls.Add(firstnametxt);
            Controls.Add(lastnamelbl);
            Controls.Add(firstnamelbl);
            Controls.Add(registerlbl);
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label registerlbl;
        private Label firstnamelbl;
        private Label lastnamelbl;
        private TextBox firstnametxt;
        private TextBox lastnametxt;
        private Label usernamelbl;
        private TextBox username;
        private Label passwordlbl;
        private MaskedTextBox password;
        private Button send;
    }
}