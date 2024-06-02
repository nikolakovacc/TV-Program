using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using TVProgram.Models;

namespace TVProgram.Foorms
{
    public partial class changePasswordForm : Form
    {
        public string newPassword { get; set; }
        private const string passwordFilePath = "userPassword.txt";
        public changePasswordForm()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox2.Text)
            {
                MessageBox.Show("Пароль змінено!");
                newPassword = textBox1.Text;
                SavePasswordToFile(newPassword);
                //this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Ваші паролі не співпадають, будь ласка перевірте написання!");
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void SavePasswordToFile(string password)
        {
            File.WriteAllText(passwordFilePath, password);
        }
    }
}
