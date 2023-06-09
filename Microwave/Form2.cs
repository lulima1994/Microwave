using Microwave.Entities;
using System.ComponentModel;
using System.Globalization;

namespace Microwave {
    public partial class Form2 : Form {

        public BindingList<ItemObj> itens { get; set; }

        public Form2(BindingList<ItemObj> itens) {
            InitializeComponent();
            this.itens = itens;
            listBox1.DataSource = this.itens;
            listBox1.DisplayMember = "DisplayText";
            AtualizarListBox();
        }

        private void button1_Click(object sender, EventArgs e) {

            if (listBox1.SelectedItem == null) {
                MessageBox.Show("Nenhum item selecionado.");
                return;
            }

            ItemObj itemSelecionado = (ItemObj)listBox1.SelectedItem;

            if (itemSelecionado.Caractere == 'A' || itemSelecionado.Caractere == 'B' || itemSelecionado.Caractere == 'C' || itemSelecionado.Caractere == 'D' || itemSelecionado.Caractere == 'E') {
                MessageBox.Show("Não é possível remover este item.");
                return;
            }

            itens.Remove(itemSelecionado);
            AtualizarListBox();
        }

        private void button2_Click(object sender, EventArgs e) {

            Form3 form3 = new Form3();
            form3.ShowDialog();

        }

        private void button3_Click(object sender, EventArgs e) {

            this.Close();
        }

        private void button4_Click(object sender, EventArgs e) {

            Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();

            if (form1 != null && listBox1.SelectedItem != null) {
                ItemObj itemSelecionado = (ItemObj)listBox1.SelectedItem;
                form1.SelectedItemTime = itemSelecionado.Tempo;
                form1.SelectedItemPotencia = itemSelecionado.Potencia;
                form1.SelectedItemCaractere = itemSelecionado.Caractere;

                TextBox textBox2 = form1.Controls.Find("textBox2", true).FirstOrDefault() as TextBox;
                if (textBox2 != null) {
                    textBox2.Text = form1.SelectedItemTime.ToString(@"mm\:ss");
                }

                TextBox textBox3 = form1.Controls.Find("textbox3", true).FirstOrDefault() as TextBox;
                if (textBox3 != null) {
                    textBox3.Text = form1.SelectedItemPotencia.ToString();
                }

                Label label1 = form1.Controls.Find("label1", true).FirstOrDefault() as Label;
                if (label1 != null) {
                    label1.Text = form1.SelectedItemCaractere.ToString();
                }
            }

            if (listBox1.SelectedItem == null) {
                MessageBox.Show("Nenhum item selecionado.");
                return;
            }

            this.Close();
        }

        public ListBox ListBoxItems {
            get { return listBox1; }
        }

        public void AtualizarListBox() {

            var dataSource = listBox1.DataSource;
            listBox1.DataSource = null;
            var itensOrdenados = itens.OrderBy(item => item.Caractere.ToString()).ToList();

            listBox1.Items.Clear();
            foreach (var item in itensOrdenados) {
                listBox1.Items.Add(item);
            }

            listBox1.DataSource = itensOrdenados;
            listBox1.DisplayMember = "DisplayText";
        }

        private void Form2_Load(object sender, EventArgs e) {
            if (!itens.Any(item => item.Caractere == 'A')) {
                ItemObj A = new ItemObj();
                A.Nome = "Pipoca";
                A.Potencia = 7;
                A.Tempo = TimeSpan.ParseExact("03:00", "mm\\:ss", CultureInfo.InvariantCulture);
                A.Caractere = 'A';
                A.Texto = "Observar o barulho de estouros do milho, caso houver um intervalo de mais de 10 segundos entre um\r\nestouro e outro, interrompa o aquecimento";

                ItemObj B = new ItemObj();
                B.Nome = "Leite";
                B.Potencia = 5;
                B.Tempo = TimeSpan.ParseExact("05:00", "mm\\:ss", CultureInfo.InvariantCulture);
                B.Caractere = 'B';
                B.Texto = "Cuidado com aquecimento de líquidos, o choque térmico aliado ao movimento do recipiente pode\r\ncausar fervura imediata causando risco de queimaduras.";

                ItemObj C = new ItemObj();
                C.Nome = "Carne";
                C.Potencia = 4;
                C.Tempo = TimeSpan.ParseExact("14:00", "mm\\:ss", CultureInfo.InvariantCulture);
                C.Caractere = 'C';
                C.Texto = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o\r\ndescongelamento uniforme.";

                ItemObj D = new ItemObj();
                D.Nome = "Frango";
                D.Potencia = 7;
                D.Tempo = TimeSpan.ParseExact("08:00", "mm\\:ss", CultureInfo.InvariantCulture);
                D.Caractere = 'D';
                D.Texto = "Interrompa o processo na metade e vire o conteúdo com a parte de baixo para cima para o\r\ndescongelamento uniforme.";

                ItemObj E = new ItemObj();
                E.Nome = "Feijão";
                E.Potencia = 9;
                E.Tempo = TimeSpan.ParseExact("08:00", "mm\\:ss", CultureInfo.InvariantCulture);
                E.Caractere = 'E';
                E.Texto = "Deixe o recipiente destampado e em casos de plástico, cuidado ao retirar o recipiente pois o mesmo\r\npode perder resistência em altas temperaturas.";

                itens.Add(A);
                itens.Add(B);
                itens.Add(C);
                itens.Add(D);
                itens.Add(E);
            }

            AtualizarListBox();
        }
    }
}
