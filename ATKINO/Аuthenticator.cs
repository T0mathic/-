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
    public partial class Аuthenticator : Form
    {  
        private bool _isAuthenticated = false;
        public Аuthenticator()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void Аuthenticator_Load(object sender, EventArgs e)
        {

        }
        private void Аuthenticator_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_isAuthenticated == false) 
            Application.Exit();
        }
        private void AuthLogin_TextChanged(object sender, EventArgs e)
        {

        }
        private void AuthPassword_TextChanged(object sender, EventArgs e)
        {

        }
        private void AuthLogigPassword_Click(object sender, EventArgs e)
        {
            DBManager dBManager = new DBManager("C:\\Users\\Tomath\\Desktop\\Учёба\\ОП\\Users.db");
            if (dBManager.CheckUser(AuthLogin.Text, AuthPassword.Text))
            {
                _isAuthenticated = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль!");
            }
        }
        private void AuthGoReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Registration registration_form = new Registration();
            registration_form.ShowDialog();
        }
    }
}
