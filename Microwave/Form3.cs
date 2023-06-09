using Microwave.Entities;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Microwave {
    public partial class Form3 : Form {

        public Form3() {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void button2_Click(object sender, EventArgs e) {

            if (ValidarCampos()) {
                string nome = textBox1.Text;
                int potencia = Convert.ToInt32(textBox2.Text);
                TimeSpan tempo = TimeSpan.ParseExact(textBox3.Text, "mm\\:ss", CultureInfo.InvariantCulture);
                char caractere = Convert.ToChar(textBox4.Text);
                string texto = textBox5.Text;

                Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();

                ItemObj item = new ItemObj();
                item.Nome = nome;
                item.Potencia = potencia;
                item.Tempo = tempo;
                item.Caractere = caractere;
                item.Texto = texto;

                if (form2 != null) {
                    form2.itens.Add(item);
                    form2.AtualizarListBox();
                }

                this.Close();
            }
        }

        private bool ValidarCampos() {
            if (string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox5.Text)) {
                MessageBox.Show("Todos os campos devem ser preenchidos.");
                return false;
            }

            if (!Regex.IsMatch(textBox1.Text, "^[A-Za-z]+$")) {
                MessageBox.Show("O campo Nome deve conter apenas letras.");
                return false;
            }

            int potencia;
            if (!int.TryParse(textBox2.Text, out potencia) || potencia < 1 || potencia > 10) {
                MessageBox.Show("O campo Potência deve ser um número de 1 a 10.");
                return false;
            }

            TimeSpan tempo;
            if (!TimeSpan.TryParseExact(textBox3.Text, "mm\\:ss", CultureInfo.InvariantCulture, out tempo)) {
                MessageBox.Show("O campo Tempo deve estar no formato mm:ss.");
                return false;
            }

            if (textBox4.Text.Length != 1 || !char.IsLetter(textBox4.Text[0])) {
                MessageBox.Show("O campo Caractere deve conter apenas uma letra.");
                return false;
            }

            Form2 form2 = Application.OpenForms.OfType<Form2>().FirstOrDefault();
            if (form2 != null && form2.itens.Any(item => item.Caractere == textBox4.Text[0])) {
                MessageBox.Show("Já existe um objeto com o mesmo caractere.");
                return false;
            }

            return true;
        }
    }
}