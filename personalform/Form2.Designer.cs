namespace personalform
{
    partial class Form2
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
            idlbl = new Label();
            idtxt = new TextBox();
            id2txt = new TextBox();
            id2lbl = new Label();
            countrytxt = new TextBox();
            countrylbl = new Label();
            citytxt = new TextBox();
            citylbl = new Label();
            insertcountry = new Button();
            deletecountry = new Button();
            updatecountry = new Button();
            updatecity = new Button();
            deletecity = new Button();
            insertcity = new Button();
            SuspendLayout();
            // 
            // idlbl
            // 
            idlbl.AutoSize = true;
            idlbl.Location = new Point(70, 53);
            idlbl.Name = "idlbl";
            idlbl.Size = new Size(27, 25);
            idlbl.TabIndex = 0;
            idlbl.Text = "id";
            // 
            // idtxt
            // 
            idtxt.Location = new Point(103, 47);
            idtxt.Name = "idtxt";
            idtxt.Size = new Size(150, 31);
            idtxt.TabIndex = 1;
            // 
            // id2txt
            // 
            id2txt.Location = new Point(371, 47);
            id2txt.Name = "id2txt";
            id2txt.Size = new Size(150, 31);
            id2txt.TabIndex = 3;
            // 
            // id2lbl
            // 
            id2lbl.AutoSize = true;
            id2lbl.Location = new Point(338, 50);
            id2lbl.Name = "id2lbl";
            id2lbl.Size = new Size(27, 25);
            id2lbl.TabIndex = 2;
            id2lbl.Text = "id";
            // 
            // countrytxt
            // 
            countrytxt.Location = new Point(103, 107);
            countrytxt.Name = "countrytxt";
            countrytxt.Size = new Size(150, 31);
            countrytxt.TabIndex = 5;
            // 
            // countrylbl
            // 
            countrylbl.AutoSize = true;
            countrylbl.Location = new Point(25, 113);
            countrylbl.Name = "countrylbl";
            countrylbl.Size = new Size(72, 25);
            countrylbl.TabIndex = 4;
            countrylbl.Text = "country";
            // 
            // citytxt
            // 
            citytxt.Location = new Point(371, 107);
            citytxt.Name = "citytxt";
            citytxt.Size = new Size(150, 31);
            citytxt.TabIndex = 7;
            // 
            // citylbl
            // 
            citylbl.AutoSize = true;
            citylbl.Location = new Point(326, 113);
            citylbl.Name = "citylbl";
            citylbl.Size = new Size(39, 25);
            citylbl.TabIndex = 6;
            citylbl.Text = "city";
            // 
            // insertcountry
            // 
            insertcountry.Location = new Point(114, 198);
            insertcountry.Name = "insertcountry";
            insertcountry.Size = new Size(112, 34);
            insertcountry.TabIndex = 8;
            insertcountry.Text = "insert";
            insertcountry.UseVisualStyleBackColor = true;
            insertcountry.Click += insertCountry;
            // 
            // deletecountry
            // 
            deletecountry.Location = new Point(114, 306);
            deletecountry.Name = "deletecountry";
            deletecountry.Size = new Size(112, 34);
            deletecountry.TabIndex = 9;
            deletecountry.Text = "delete";
            deletecountry.UseVisualStyleBackColor = true;
            deletecountry.Click += deleteCountry;
            // 
            // updatecountry
            // 
            updatecountry.Location = new Point(114, 253);
            updatecountry.Name = "updatecountry";
            updatecountry.Size = new Size(112, 34);
            updatecountry.TabIndex = 10;
            updatecountry.Text = "update";
            updatecountry.UseVisualStyleBackColor = true;
            updatecountry.Click += updateCountry;
            // 
            // updatecity
            // 
            updatecity.Location = new Point(391, 253);
            updatecity.Name = "updatecity";
            updatecity.Size = new Size(112, 34);
            updatecity.TabIndex = 13;
            updatecity.Text = "update";
            updatecity.UseVisualStyleBackColor = true;
            updatecity.Click += updateCity;
            // 
            // deletecity
            // 
            deletecity.Location = new Point(391, 306);
            deletecity.Name = "deletecity";
            deletecity.Size = new Size(112, 34);
            deletecity.TabIndex = 12;
            deletecity.Text = "delete";
            deletecity.UseVisualStyleBackColor = true;
            deletecity.Click += deleteCity;
            // 
            // insertcity
            // 
            insertcity.Location = new Point(391, 198);
            insertcity.Name = "insertcity";
            insertcity.Size = new Size(112, 34);
            insertcity.TabIndex = 11;
            insertcity.Text = "insert";
            insertcity.UseVisualStyleBackColor = true;
            insertcity.Click += insertCity;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.OliveDrab;
            ClientSize = new Size(800, 450);
            Controls.Add(updatecity);
            Controls.Add(deletecity);
            Controls.Add(insertcity);
            Controls.Add(updatecountry);
            Controls.Add(deletecountry);
            Controls.Add(insertcountry);
            Controls.Add(citytxt);
            Controls.Add(citylbl);
            Controls.Add(countrytxt);
            Controls.Add(countrylbl);
            Controls.Add(id2txt);
            Controls.Add(id2lbl);
            Controls.Add(idtxt);
            Controls.Add(idlbl);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idlbl;
        private TextBox idtxt;
        private TextBox id2txt;
        private Label id2lbl;
        private TextBox countrytxt;
        private Label countrylbl;
        private TextBox citytxt;
        private Label citylbl;
        private Button insertcountry;
        private Button deletecountry;
        private Button updatecountry;
        private Button updatecity;
        private Button deletecity;
        private Button insertcity;
    }
}