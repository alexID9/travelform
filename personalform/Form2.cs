using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace personalform
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void insertCountry(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC09\SQLEXPRESS;Initial Catalog=FORM;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Countries VALUES (@country)", con);
            cmd.Parameters.AddWithValue("@country", countrytxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted");

        }

        private void updateCountry(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC09\SQLEXPRESS;Initial Catalog=FORM;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Countries SET CountryName = @city WHERE CountryID = @id", con);
            cmd.Parameters.AddWithValue("@country", countrytxt.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(id2txt.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated");
        }

        private void deleteCountry(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC09\SQLEXPRESS;Initial Catalog=FORM;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Countries WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(id2txt.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted");
        }

        private void insertCity(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC09\SQLEXPRESS;Initial Catalog=FORM;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Towns VALUES (@city)", con);
            cmd.Parameters.AddWithValue("@city", citytxt.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was inserted");
        }

        private void updateCity(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC09\SQLEXPRESS;Initial Catalog=FORM;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE Towns SET TownName = @city WHERE TownID = @id", con);
            cmd.Parameters.AddWithValue("@city", citytxt.Text);
            cmd.Parameters.AddWithValue("@id", int.Parse(idtxt.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was updated");
        }

        private void deleteCity(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=LAB108PC09\SQLEXPRESS;Initial Catalog=FORM;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE from Towns WHERE id = @id", con);
            cmd.Parameters.AddWithValue("@id", int.Parse(idtxt.Text));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record was deleted");
        }
    }
}
