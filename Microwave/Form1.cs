using Microwave.Entities;
using System.ComponentModel;
using System.Globalization;

namespace Microwave {
    public partial class Form1 : Form {

        public TimeSpan SelectedItemTime { get; set; }
        public int SelectedItemPotencia { get; set; }
        public char SelectedItemCaractere { get; set; }

        private BindingList<ItemObj> itens = new BindingList<ItemObj>();
        private int segundos = 0;
        private int potencia = 0;
        private bool pausado = true;
        private bool primeiraVez = true;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            textBox1.Text = "00:00";
            textBox2.PlaceholderText = "(1-120)";
            textBox3.PlaceholderText = "(1-10)";
        }

        private void button1_Click(object sender, EventArgs e) {

            if (textBox2.ForeColor == Color.Black && textBox3.ForeColor == Color.Black) {
                if (int.TryParse(textBox2.Text, out int tempo) && tempo >= 1 && tempo <= 120) {
                    this.segundos = tempo;
                    textBox1.Text = TimeSpan.FromSeconds(this.segundos).ToString(@"mm\:ss");
                    textBox2.Text = string.Empty;
                    primeiraVez = false;
                    pausado = false;
                    timer1.Start();
                    if (int.TryParse(textBox3.Text, out int potencia) && potencia >= 1 && potencia <= 10) {
                        SelectedItemPotencia = potencia;
                        label1.Text = "";
                        textBox3.Text = string.Empty;
                        pausado = false;
                        timer1.Start();
                    }
                    return;
                }
                else if (TimeSpan.TryParseExact(textBox2.Text, "mm\\:ss", CultureInfo.InvariantCulture, out TimeSpan timeSpan)) {
                    this.segundos = (int)timeSpan.TotalSeconds;
                    textBox1.Text = timeSpan.ToString(@"mm\:ss");
                    textBox2.Text = string.Empty;
                    textBox3.Text = string.Empty;
                    primeiraVez = false;
                    pausado = false;
                    timer1.Start();
                    return;
                }
            }

            if (pausado) {
                pausado = false;
                timer1.Start();
                if (primeiraVez) {
                    segundos += 30;
                    textBox1.Text = TimeSpan.FromSeconds(segundos).ToString(@"mm\:ss");
                    primeiraVez = false;
                }
            }
            else {
                segundos += 30;
                textBox1.Text = TimeSpan.FromSeconds(segundos).ToString(@"mm\:ss");
            }
        }

        private void button2_Click(object sender, EventArgs e) {
            if (pausado) {
                segundos = 0;
                textBox1.Text = "00:00";
                label1.Text = "";
                SelectedItemCaractere = '.';
                primeiraVez = true;
            }
            else {
                pausado = true;
                timer1.Stop();
            }
        }

        private void button3_Click(object sender, EventArgs e) {
            Form2 form2 = new Form2(itens);
            form2.ShowDialog();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) {
            if (textBox2.Text.Length >= 3 && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e) {
            string input = textBox2.Text.Trim();
            if (int.TryParse(input, out int tempo) && tempo >= 1 && tempo <= 120) {
                textBox2.ForeColor = Color.Black;
            }
            else if (TimeSpan.TryParseExact(input, "mm\\:ss", CultureInfo.InvariantCulture, out TimeSpan timeSpan)) {
                textBox2.ForeColor = Color.Black;
            }
            else {
                textBox2.ForeColor = Color.Red;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) {
            if (textBox3.Text.Length >= 3 && !char.IsControl(e.KeyChar)) {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e) {
            string input = textBox3.Text.Trim();
            if (int.TryParse(input, out int potencia)) {
                if (potencia >= 1 && potencia <= 10) {
                    textBox3.ForeColor = Color.Black;
                }
                else {
                    textBox3.ForeColor = Color.Red;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) {

            label1.Invoke((MethodInvoker)delegate {
                string powerCharacter = "";
                char character = SelectedItemCaractere != '\0' ? SelectedItemCaractere : '.';
                int power = SelectedItemPotencia != 0 ? SelectedItemPotencia : 10;
                for (int i = 0; i < power; i++) {
                    powerCharacter += character;
                }
                label1.Text += powerCharacter;
            });

            segundos--;
            if (segundos >= 0) {
                textBox1.Text = TimeSpan.FromSeconds(segundos).ToString(@"mm\:ss");
            }
            else {
                pausado = true;
                segundos = 0;
                timer1.Stop();
                primeiraVez = true;
            }
        }
    }
}
