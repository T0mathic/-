namespace ATKINO
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Input = new TextBox();
            MakeSort = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Input
            // 
            Input.Location = new Point(12, 52);
            Input.Name = "Input";
            Input.Size = new Size(413, 23);
            Input.TabIndex = 0;
            Input.TextChanged += Input_TextChanged;
            Input.KeyPress += Input_TextChanged;
            // 
            // MakeSort
            // 
            MakeSort.Location = new Point(155, 93);
            MakeSort.Name = "MakeSort";
            MakeSort.Size = new Size(116, 23);
            MakeSort.TabIndex = 2;
            MakeSort.Text = "Найти числа";
            MakeSort.UseVisualStyleBackColor = true;
            MakeSort.Click += MakeSort_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(413, 15);
            label1.TabIndex = 3;
            label1.Text = "Введите целое число, до которого необходимо найти все простые числа:";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 128);
            Controls.Add(label1);
            Controls.Add(MakeSort);
            Controls.Add(Input);
            Name = "Form1";
            Text = "Решето Аткина";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input;
        private Button MakeSort;
        private Label label1;
    }
}
