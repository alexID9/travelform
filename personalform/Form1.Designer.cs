namespace personalform
{
    partial class Form1
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
            cmbcountry = new ComboBox();
            lblcountry = new Label();
            cmbcity = new ComboBox();
            lblcity = new Label();
            check1 = new CheckBox();
            lblhobbies = new Label();
            check2 = new CheckBox();
            check3 = new CheckBox();
            check4 = new CheckBox();
            check5 = new CheckBox();
            lbltime = new Label();
            btn1 = new RadioButton();
            btn2 = new RadioButton();
            btn3 = new RadioButton();
            btn4 = new RadioButton();
            btn5 = new RadioButton();
            listdraft = new ListBox();
            listfinal = new ListBox();
            lbllist = new Label();
            lblselection = new Label();
            btnsubmit = new Button();
            btnforward = new Button();
            btnbackward = new Button();
            SuspendLayout();
            // 
            // cmbcountry
            // 
            cmbcountry.BackColor = Color.Silver;
            cmbcountry.FormattingEnabled = true;
            cmbcountry.Items.AddRange(new object[] { "Bulgaria", "Japan", "Netherlands" });
            cmbcountry.Location = new Point(10, 43);
            cmbcountry.Name = "cmbcountry";
            cmbcountry.Size = new Size(182, 33);
            cmbcountry.TabIndex = 0;
            cmbcountry.SelectedIndexChanged += Selection;
            // 
            // lblcountry
            // 
            lblcountry.AutoSize = true;
            lblcountry.ForeColor = SystemColors.ControlLightLight;
            lblcountry.Location = new Point(10, 15);
            lblcountry.Name = "lblcountry";
            lblcountry.Size = new Size(72, 25);
            lblcountry.TabIndex = 1;
            lblcountry.Text = "country";
            // 
            // cmbcity
            // 
            cmbcity.BackColor = Color.Silver;
            cmbcity.FormattingEnabled = true;
            cmbcity.Location = new Point(10, 198);
            cmbcity.Name = "cmbcity";
            cmbcity.Size = new Size(182, 33);
            cmbcity.TabIndex = 2;
            // 
            // lblcity
            // 
            lblcity.AutoSize = true;
            lblcity.ForeColor = SystemColors.ControlLightLight;
            lblcity.Location = new Point(10, 170);
            lblcity.Name = "lblcity";
            lblcity.Size = new Size(39, 25);
            lblcity.TabIndex = 3;
            lblcity.Text = "city";
            // 
            // check1
            // 
            check1.AutoSize = true;
            check1.ForeColor = SystemColors.ControlLightLight;
            check1.Location = new Point(223, 47);
            check1.Name = "check1";
            check1.Size = new Size(103, 29);
            check1.TabIndex = 4;
            check1.Text = "painting";
            check1.UseVisualStyleBackColor = true;
            check1.CheckedChanged += Check1;
            // 
            // lblhobbies
            // 
            lblhobbies.AutoSize = true;
            lblhobbies.ForeColor = SystemColors.ControlLightLight;
            lblhobbies.Location = new Point(223, 15);
            lblhobbies.Name = "lblhobbies";
            lblhobbies.Size = new Size(76, 25);
            lblhobbies.TabIndex = 5;
            lblhobbies.Text = "hobbies";
            // 
            // check2
            // 
            check2.AutoSize = true;
            check2.ForeColor = SystemColors.ControlLightLight;
            check2.Location = new Point(223, 82);
            check2.Name = "check2";
            check2.Size = new Size(143, 29);
            check2.TabIndex = 6;
            check2.Text = "photography";
            check2.UseVisualStyleBackColor = true;
            check2.CheckedChanged += Check2;
            // 
            // check3
            // 
            check3.AutoSize = true;
            check3.ForeColor = SystemColors.ControlLightLight;
            check3.Location = new Point(223, 117);
            check3.Name = "check3";
            check3.Size = new Size(107, 29);
            check3.TabIndex = 7;
            check3.Text = "clubbing";
            check3.UseVisualStyleBackColor = true;
            check3.CheckedChanged += Check3;
            // 
            // check4
            // 
            check4.AutoSize = true;
            check4.ForeColor = SystemColors.ControlLightLight;
            check4.Location = new Point(223, 152);
            check4.Name = "check4";
            check4.Size = new Size(101, 29);
            check4.TabIndex = 8;
            check4.Text = "dancing";
            check4.UseVisualStyleBackColor = true;
            check4.CheckedChanged += Check4;
            // 
            // check5
            // 
            check5.AutoSize = true;
            check5.ForeColor = SystemColors.ControlLightLight;
            check5.Location = new Point(223, 187);
            check5.Name = "check5";
            check5.Size = new Size(86, 29);
            check5.TabIndex = 9;
            check5.Text = "hiking";
            check5.UseVisualStyleBackColor = true;
            check5.CheckedChanged += Check5;
            // 
            // lbltime
            // 
            lbltime.AutoSize = true;
            lbltime.ForeColor = SystemColors.ControlLightLight;
            lbltime.Location = new Point(223, 231);
            lbltime.Name = "lbltime";
            lbltime.Size = new Size(47, 25);
            lbltime.TabIndex = 10;
            lbltime.Text = "time";
            // 
            // btn1
            // 
            btn1.AutoSize = true;
            btn1.ForeColor = SystemColors.ControlLightLight;
            btn1.Location = new Point(223, 259);
            btn1.Name = "btn1";
            btn1.Size = new Size(105, 29);
            btn1.TabIndex = 11;
            btn1.TabStop = true;
            btn1.Text = "morning";
            btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            btn2.AutoSize = true;
            btn2.ForeColor = SystemColors.ControlLightLight;
            btn2.Location = new Point(223, 294);
            btn2.Name = "btn2";
            btn2.Size = new Size(79, 29);
            btn2.TabIndex = 12;
            btn2.TabStop = true;
            btn2.Text = "noon";
            btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            btn3.AutoSize = true;
            btn3.ForeColor = SystemColors.ControlLightLight;
            btn3.Location = new Point(223, 329);
            btn3.Name = "btn3";
            btn3.Size = new Size(115, 29);
            btn3.TabIndex = 13;
            btn3.TabStop = true;
            btn3.Text = "afternoon";
            btn3.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            btn4.AutoSize = true;
            btn4.ForeColor = SystemColors.ControlLightLight;
            btn4.Location = new Point(223, 364);
            btn4.Name = "btn4";
            btn4.Size = new Size(99, 29);
            btn4.TabIndex = 14;
            btn4.TabStop = true;
            btn4.Text = "evening";
            btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            btn5.AutoSize = true;
            btn5.ForeColor = SystemColors.ControlLightLight;
            btn5.Location = new Point(223, 399);
            btn5.Name = "btn5";
            btn5.Size = new Size(78, 29);
            btn5.TabIndex = 15;
            btn5.TabStop = true;
            btn5.Text = "night";
            btn5.UseVisualStyleBackColor = true;
            // 
            // listdraft
            // 
            listdraft.BackColor = Color.Silver;
            listdraft.FormattingEnabled = true;
            listdraft.ItemHeight = 25;
            listdraft.Location = new Point(387, 43);
            listdraft.Name = "listdraft";
            listdraft.Size = new Size(180, 129);
            listdraft.TabIndex = 16;
            // 
            // listfinal
            // 
            listfinal.BackColor = Color.Silver;
            listfinal.FormattingEnabled = true;
            listfinal.ItemHeight = 25;
            listfinal.Location = new Point(610, 43);
            listfinal.Name = "listfinal";
            listfinal.Size = new Size(180, 129);
            listfinal.TabIndex = 17;
            // 
            // lbllist
            // 
            lbllist.AutoSize = true;
            lbllist.ForeColor = SystemColors.ControlLightLight;
            lbllist.Location = new Point(387, 15);
            lbllist.Name = "lbllist";
            lbllist.Size = new Size(137, 25);
            lbllist.TabIndex = 18;
            lbllist.Text = "hobbies chosen";
            // 
            // lblselection
            // 
            lblselection.AutoSize = true;
            lblselection.ForeColor = SystemColors.ControlLightLight;
            lblselection.Location = new Point(610, 15);
            lblselection.Name = "lblselection";
            lblselection.Size = new Size(119, 25);
            lblselection.TabIndex = 19;
            lblselection.Text = "final selection";
            // 
            // btnsubmit
            // 
            btnsubmit.Location = new Point(517, 226);
            btnsubmit.Name = "btnsubmit";
            btnsubmit.Size = new Size(112, 34);
            btnsubmit.TabIndex = 20;
            btnsubmit.Text = "submit";
            btnsubmit.UseVisualStyleBackColor = true;
            btnsubmit.Click += SubmitForm;
            // 
            // btnforward
            // 
            btnforward.Location = new Point(572, 70);
            btnforward.Name = "btnforward";
            btnforward.Size = new Size(34, 34);
            btnforward.TabIndex = 21;
            btnforward.Text = ">";
            btnforward.UseVisualStyleBackColor = true;
            btnforward.Click += Forward;
            // 
            // btnbackward
            // 
            btnbackward.Location = new Point(573, 110);
            btnbackward.Name = "btnbackward";
            btnbackward.Size = new Size(34, 34);
            btnbackward.TabIndex = 22;
            btnbackward.Text = "<";
            btnbackward.UseVisualStyleBackColor = true;
            btnbackward.Click += Backward;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 0, 0);
            ClientSize = new Size(800, 450);
            Controls.Add(btnbackward);
            Controls.Add(btnforward);
            Controls.Add(btnsubmit);
            Controls.Add(lblselection);
            Controls.Add(lbllist);
            Controls.Add(listfinal);
            Controls.Add(listdraft);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(lbltime);
            Controls.Add(check5);
            Controls.Add(check4);
            Controls.Add(check3);
            Controls.Add(check2);
            Controls.Add(lblhobbies);
            Controls.Add(check1);
            Controls.Add(lblcity);
            Controls.Add(cmbcity);
            Controls.Add(lblcountry);
            Controls.Add(cmbcountry);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbcountry;
        private Label lblcountry;
        private ComboBox cmbcity;
        private Label lblcity;
        private CheckBox check1;
        private Label lblhobbies;
        private CheckBox check2;
        private CheckBox check3;
        private CheckBox check4;
        private CheckBox check5;
        private Label lbltime;
        private RadioButton btn1;
        private RadioButton btn2;
        private RadioButton btn3;
        private RadioButton btn4;
        private RadioButton btn5;
        private ListBox listdraft;
        private ListBox listfinal;
        private Label lbllist;
        private Label lblselection;
        private Button btnsubmit;
        private Button btnforward;
        private Button btnbackward;
    }
}