﻿namespace ATKINO
{
    partial class Registration
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
            label1 = new Label();
            label3 = new Label();
            label2 = new Label();
            RegLogin = new TextBox();
            RegPassword = new TextBox();
            MakeReg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 49);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 5;
            label1.Text = "Придумайте логин:";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(159, 18);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(185, 15);
            label3.TabIndex = 7;
            label3.Text = "Создание новой учетной записи";
            label3.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 97);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(121, 15);
            label2.TabIndex = 8;
            label2.Text = "Придумайте пароль:";
            label2.Click += label2_Click;
            // 
            // RegLogin
            // 
            RegLogin.Location = new Point(150, 46);
            RegLogin.Name = "RegLogin";
            RegLogin.Size = new Size(316, 23);
            RegLogin.TabIndex = 10;
            RegLogin.TextChanged += RegLogin_TextChanged;
            // 
            // RegPassword
            // 
            RegPassword.Location = new Point(150, 89);
            RegPassword.Name = "RegPassword";
            RegPassword.PasswordChar = '*';
            RegPassword.Size = new Size(316, 23);
            RegPassword.TabIndex = 11;
            RegPassword.TextChanged += RegPassword_TextChanged;
            // 
            // MakeReg
            // 
            MakeReg.Location = new Point(175, 128);
            MakeReg.Name = "MakeReg";
            MakeReg.Size = new Size(154, 23);
            MakeReg.TabIndex = 13;
            MakeReg.Text = "Зарегистрироваться ";
            MakeReg.UseVisualStyleBackColor = true;
            MakeReg.Click += MakeReg_Click;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(499, 162);
            Controls.Add(MakeReg);
            Controls.Add(RegPassword);
            Controls.Add(RegLogin);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Registration";
            Text = "Регистрация";
            Load += Registration_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label2;
        private Label label4;
        private TextBox RegLogin;
        private TextBox RegPassword;
        private TextBox RegPassword2;
        private Button MakeReg;
    }
}