namespace Microwave {
    partial class Form2 {
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
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // button3
            // 
            button3.FlatStyle = FlatStyle.Popup;
            button3.Location = new Point(19, 317);
            button3.Margin = new Padding(10);
            button3.Name = "button3";
            button3.Size = new Size(100, 25);
            button3.TabIndex = 3;
            button3.Text = "CANCELAR";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatStyle = FlatStyle.Popup;
            button4.Location = new Point(390, 317);
            button4.Margin = new Padding(10);
            button4.Name = "button4";
            button4.Size = new Size(100, 25);
            button4.TabIndex = 4;
            button4.Text = "CONFIRMAR";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Location = new Point(19, 19);
            button1.Margin = new Padding(10);
            button1.Name = "button1";
            button1.Size = new Size(100, 25);
            button1.TabIndex = 1;
            button1.Text = "REMOVER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(390, 19);
            button2.Margin = new Padding(10);
            button2.Name = "button2";
            button2.Size = new Size(100, 25);
            button2.TabIndex = 2;
            button2.Text = "ADICIONAR";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(19, 57);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(471, 244);
            listBox1.TabIndex = 5;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(509, 361);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Receitas";
            Load += Form2_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button button3;
        private Button button4;
        private Button button1;
        private Button button2;
        private ListBox listBox1;
    }
}