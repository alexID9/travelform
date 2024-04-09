using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace personalform
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public string hashPassword(string text)
        {

            SHA256 hashAlgorithm = SHA256.Create();
            var bytes = Encoding.Default.GetBytes(text);
            var hash = hashAlgorithm.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }
        private void register(object sender, EventArgs e)
        {
            string salt = DateTime.Now.ToString();
            string passcode = password.Text;
            // hashPassword($"{passcode}{salt}");
        }
    }
}
