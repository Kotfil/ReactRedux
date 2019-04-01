using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankForms
{
    public partial class AddClient : Form
    {
        public int PIN_CODE;
        public string FullName;
        public int Date;
        public double InterestRate;
        public int Score;
        public string Account;


        public AddClient()
        {
            InitializeComponent();
        }

      

        private void button1_Click(object sender, EventArgs e)
        {
            PIN_CODE = int.Parse(textBox1.Text);
            FullName = textBox2.Text;
            Date = int.Parse(textBox3.Text);
            InterestRate = double.Parse(textBox4.Text) / 100;
            Score = int.Parse(textBox5.Text);
            Account = textBox6.Text;
            this.Close();
        }
    }
}
