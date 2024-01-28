using System.Data.SQLite;

namespace ATKINO
{
    public partial class Form1 : Form
    {
        private readonly Sieve atkinSieve;
        public Form1()
        {
            InitializeComponent();
            atkinSieve = new Sieve();
            Аuthenticator aut_form = new Аuthenticator();
            aut_form.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MakeSort_Click(object sender, EventArgs e)
        {
            if (int.TryParse(Input.Text, out int limit))
            {
                if (limit < 2)
                {
                    MessageBox.Show("Пожалуйста, введите число, большее или равное 2.");
                    return;
                }
                List<int> primes = atkinSieve.FindPrimes(limit);
                if (primes.Count == 0)
                {
                    MessageBox.Show($"Простых чисел до {limit} не найдено.");
                }
                else
                {
                    Primenumbers(primes, limit);
                }
            }
            else
            {
                MessageBox.Show("Неверно введено число. Пожалуйста, введите допустимое целое число.");
            }
        }

        private void Primenumbers(List<int> primes, int limit)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = $"Простые числа до {limit}:\n{string.Join(", ", primes)}";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new System.Drawing.Size(550, 350);
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Form primesForm = new Form();
            primesForm.Text = "Простые числа";
            primesForm.Size = new System.Drawing.Size(600, 400);
            primesForm.Controls.Add(richTextBox);

            primesForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Input_TextChanged(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch))
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult answer = MessageBox.Show("Вы уверены, что хотите закрыть программу?", "Внимание!", MessageBoxButtons.YesNo);
            if (answer != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
