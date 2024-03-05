using System.Drawing.Text;

namespace personalform
{
    public partial class Form1 : Form
    {
        private string[] countries = new string[] { "Bulgaria", "Japan", "Netherlands" };
        private string[,] cities = new string[3, 3] { { "Sofia", "Varna", "Tarnovo" }, { "Tokyo", "Osaka", "Kyoto" }, { "Amsterdam", "Grioningen", "Eindhoven" } };
        public Form1()
        {
            InitializeComponent();
        }

        private void Selection(object sender, EventArgs e)
        {
            int countryID = cmbcountry.SelectedIndex;
            cmbcity.Items.Clear();
            for (int i = 0; i < cities.GetLength(1); i++)
            {
                cmbcity.Items.Add(cities[countryID, i]);
            }
        }

        private void Check1(object sender, EventArgs e)
        {
            if (check1.Checked == true) { listdraft.Items.Add(check1.Text); }
            else { listdraft.Items.Remove(check1.Text); listfinal.Items.Remove(check1.Text); }
        }

        private void Check2(object sender, EventArgs e)
        {
            if (check2.Checked == true) { listdraft.Items.Add(check2.Text); }
            else { listdraft.Items.Remove(check2.Text); listfinal.Items.Remove(check2.Text); }
        }

        private void Check3(object sender, EventArgs e)
        {
            if (check3.Checked == true) { listdraft.Items.Add(check3.Text); }
            else { listdraft.Items.Remove(check3.Text); listfinal.Items.Remove(check3.Text); }
        }

        private void Check4(object sender, EventArgs e)
        {
            if (check4.Checked == true) { listdraft.Items.Add(check4.Text); }
            else { listdraft.Items.Remove(check4.Text); listfinal.Items.Remove(check4.Text); }
        }

        private void Check5(object sender, EventArgs e)
        {
            if (check5.Checked == true) { listdraft.Items.Add(check5.Text); }
            else { listdraft.Items.Remove(check5.Text); listfinal.Items.Remove(check5.Text); }
        }
        private void Forward(object sender, EventArgs e)
        {
            for (int i = 0; i < listdraft.SelectedItems.Count; i++)
            {
                listfinal.Items.Add(listdraft.SelectedItems[i]);
                listdraft.Items.Remove(listdraft.SelectedItems[i]);
            }
        }
        private void Backward(object sender, EventArgs e)
        {
            for (int i = 0; i < listfinal.SelectedItems.Count; i++)
            {
                listdraft.Items.Add(listfinal.SelectedItems[i]);
                listfinal.Items.Remove(listfinal.SelectedItems[i]);
            }
        }
        private void SubmitForm(object sender, EventArgs e)
        {
            string country = cmbcountry.Text;
            string city = cmbcity.Text;
            string hobbies = "";
            string timeofday = "";
            if (btn1.Checked == true)
            {
                timeofday = btn1.Text;
            }
            else if (btn2.Checked == true)
            {
                timeofday = btn2.Text;
            }
            else if (btn3.Checked == true)
            {
                timeofday = btn3.Text;
            }
            else if (btn4.Checked == true)
            {
                timeofday = btn4.Text;
            }
            else if (btn5.Checked == true)
            {
                timeofday = btn5.Text;
            }
            else { return; }
            for (int i = 0; i < listfinal.Items.Count; i++)
            {
                hobbies += listfinal.Items[i];
                if (i != listfinal.Items.Count - 1) { hobbies += ", "; }
            }
            MessageBox.Show("Your country is " + country + ". Your city is " + city + ". The hobbies you have selected are " + hobbies + ". You prefer doing them in the " + timeofday + ".");
        }

    }
}