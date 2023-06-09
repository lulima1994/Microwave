namespace Microwave {
    partial class Form3 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            textBox3 = new TextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox5 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            textBox4 = new TextBox();
            SuspendLayout();
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(304, 142);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 11;
            button2.Text = "CONFIRMAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(114, 142);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 10;
            button1.Text = "CANCELAR";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(114, 16);
            textBox1.Margin = new Padding(10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(94, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 19);
            label1.Margin = new Padding(10);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 0;
            label1.Text = "NOME";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(114, 51);
            textBox3.Margin = new Padding(10);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(94, 23);
            textBox3.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 54);
            label3.Margin = new Padding(10);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "TEMPO";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(310, 16);
            textBox2.Margin = new Padding(10);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(94, 23);
            textBox2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 19);
            label2.Margin = new Padding(10);
            label2.Name = "label2";
            label2.Size = new Size(62, 15);
            label2.TabIndex = 2;
            label2.Text = "POTENCIA";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(114, 86);
            textBox5.Margin = new Padding(10);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(290, 23);
            textBox5.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 89);
            label5.Margin = new Padding(10);
            label5.Name = "label5";
            label5.Size = new Size(75, 15);
            label5.TabIndex = 8;
            label5.Text = "INSTRUCOES";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(219, 54);
            label4.Margin = new Padding(10);
            label4.Name = "label4";
            label4.Size = new Size(71, 15);
            label4.TabIndex = 6;
            label4.Text = "CARACTERE";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(310, 51);
            textBox4.Margin = new Padding(10);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(94, 23);
            textBox4.TabIndex = 7;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 186);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Adicionar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button2;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox5;
        private Label label5;
        private Label label4;
        private TextBox textBox4;
    }
}