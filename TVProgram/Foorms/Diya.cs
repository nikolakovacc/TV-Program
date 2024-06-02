using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVProgram.Foorms;
using TVProgram.Models;
using TVProgram.Properties;
using TVProgram.Metods;

namespace TVProgram.Foorms
{
    public partial class Diya : Form
    {
        public string Password { get; private set; }

        public Diya()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string savedPassword = File.ReadAllText(".\\userPassword.txt");
            if (passwordTextBox.Text == savedPassword)
            {
                Password = passwordTextBox.Text;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ви ввели не вірний пароль перевірте написання або зайдіть в дитячий режим!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
