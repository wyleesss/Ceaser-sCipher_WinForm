using static Ceaser_sCipher_WinForm.CipherSource;

namespace Ceaser_sCipher_WinForm
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(keyInput.Text, "[^0-9]") // перевірка чи є введений символ числом
               || keyInput.Text.Length > 9)                                           // або значення числа завелике
            {
                keyInput.Text = keyInput.Text.Remove(keyInput.Text.Length - 1);
                keyInput.SelectionStart = keyInput.Text.Length;
                keyInput.SelectionLength = 0;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultBox.Text = string.Empty;

            if (string.IsNullOrEmpty(inputBox.Text) || string.IsNullOrWhiteSpace(inputBox.Text)
                || string.IsNullOrEmpty(keyInput.Text))
                return;

            resultBox.Text = Cipher(inputBox.Text, int.Parse(keyInput.Text), isDecoding.Checked);
        }
    }
}