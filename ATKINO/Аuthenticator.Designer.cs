namespace ATKINO
{
    partial class Аuthenticator
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
            AuthLogin = new TextBox();
            AuthPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            MakeAuth = new Button();
            label4 = new Label();
            AuthGoReg = new LinkLabel();
            SuspendLayout();
            // 
            // AuthLogin
            // 
            AuthLogin.Location = new Point(80, 38);
            AuthLogin.Name = "AuthLogin";
            AuthLogin.Size = new Size(316, 23);
            AuthLogin.TabIndex = 0;
            AuthLogin.TextChanged += AuthLogin_TextChanged;
            // 
            // AuthPassword
            // 
            AuthPassword.Location = new Point(80, 87);
            AuthPassword.Name = "AuthPassword";
            AuthPassword.PasswordChar = '*';
            AuthPassword.Size = new Size(316, 23);
            AuthPassword.TabIndex = 1;
            AuthPassword.TextChanged += AuthPassword_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 41);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(44, 15);
            label1.TabIndex = 4;
            label1.Text = "Логин:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 5;
            label2.Text = "Пароль:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(164, 9);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(115, 15);
            label3.TabIndex = 6;
            label3.Text = "Добро пожаловать!";
            label3.Click += label3_Click;
            // 
            // MakeAuth
            // 
            MakeAuth.Location = new Point(25, 140);
            MakeAuth.Margin = new Padding(2);
            MakeAuth.Name = "MakeAuth";
            MakeAuth.Size = new Size(78, 20);
            MakeAuth.TabIndex = 7;
            MakeAuth.Text = "Войти";
            MakeAuth.UseVisualStyleBackColor = true;
            MakeAuth.Click += AuthLogigPassword_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(180, 143);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(121, 15);
            label4.TabIndex = 8;
            label4.Text = "Нет учетной записи?";
            label4.Click += label4_Click;
            // 
            // AuthGoReg
            // 
            AuthGoReg.AutoSize = true;
            AuthGoReg.Location = new Point(321, 143);
            AuthGoReg.Margin = new Padding(2, 0, 2, 0);
            AuthGoReg.Name = "AuthGoReg";
            AuthGoReg.Size = new Size(119, 15);
            AuthGoReg.TabIndex = 9;
            AuthGoReg.TabStop = true;
            AuthGoReg.Text = "Зарегистрироваться";
            AuthGoReg.LinkClicked += AuthGoReg_LinkClicked;
            // 
            // Аuthenticator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(468, 180);
            Controls.Add(AuthGoReg);
            Controls.Add(label4);
            Controls.Add(MakeAuth);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(AuthPassword);
            Controls.Add(AuthLogin);
            Name = "Аuthenticator";
            Text = "Аутентификация";
            FormClosed += Аuthenticator_FormClosed;
            Load += Аuthenticator_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox AuthLogin;
        private TextBox AuthPassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button MakeAuth;
        private Label label4;
        private LinkLabel AuthGoReg;
    }
}