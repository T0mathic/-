using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATKINO
{
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }
        private void MakeReg_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("C:\\Users\\Tomath\\Desktop\\Учёба\\ОП\\Users.db");
            if (RegLogin.Text.Length < 3)
            {
                MessageBox.Show("Логин не может быть короче 3 символов");
            }
            else
            {
                if (RegPassword.Text.Length < 6)
                {
                    MessageBox.Show("Пароль не может быть короче 6 символов");
                }
                else
                {
                    if (dBManager.CheckLogin(RegLogin.Text) == false)
                    {
                        if (dBManager.AddUser(RegLogin.Text, RegPassword.Text) == true)
                        {
                            MessageBox.Show("Регистрация успешна!");
                        }
                        else
                        {
                            MessageBox.Show("Такой пользователь уже зарегистрирован!");
                        }
                    }
                }
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void RegLogin_TextChanged(object sender, EventArgs e)
        {
            string block = "*-;'";
            foreach (char c in RegLogin.Text)
            {
                foreach (char c2 in block)
                {
                    if (c == c2)
                    {
                        MessageBox.Show("Введен запрещенный символ");
                        RegLogin.Clear();
                    }
                }
            }
        }
        private void Registration_Load(object sender, EventArgs e)
        {

        }
        private void RegPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void RegPassword2_TextChanged(object sender, EventArgs e)
        {

        }      
    }
}
