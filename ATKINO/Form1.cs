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
            �uthenticator aut_form = new �uthenticator();
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
                    MessageBox.Show("����������, ������� �����, ������� ��� ������ 2.");
                    return;
                }
                List<int> primes = atkinSieve.FindPrimes(limit);
                if (primes.Count == 0)
                {
                    MessageBox.Show($"������� ����� �� {limit} �� �������.");
                }
                else
                {
                    Primenumbers(primes, limit);
                }
            }
            else
            {
                MessageBox.Show("������� ������� �����. ����������, ������� ���������� ����� �����.");
            }
        }

        private void Primenumbers(List<int> primes, int limit)
        {
            RichTextBox richTextBox = new RichTextBox();
            richTextBox.Text = $"������� ����� �� {limit}:\n{string.Join(", ", primes)}";
            richTextBox.ReadOnly = true;
            richTextBox.Size = new System.Drawing.Size(550, 350);
            richTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            Form primesForm = new Form();
            primesForm.Text = "������� �����";
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
            DialogResult answer = MessageBox.Show("�� �������, ��� ������ ������� ���������?", "��������!", MessageBoxButtons.YesNo);
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
