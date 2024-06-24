namespace Exercicios
{
    partial class FrmChamado
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
            btnCancelarChamado = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            textBox1 = new TextBox();
            labelSetorChamado = new Label();
            label1 = new Label();
            labelCategoriaChamado = new Label();
            labelMsgChamado = new Label();
            btnCriarChamado = new Button();
            SuspendLayout();
            // 
            // btnCancelarChamado
            // 
            btnCancelarChamado.BackColor = Color.FromArgb(64, 0, 64);
            btnCancelarChamado.ForeColor = SystemColors.Control;
            btnCancelarChamado.Location = new Point(307, 637);
            btnCancelarChamado.Margin = new Padding(4, 5, 4, 5);
            btnCancelarChamado.Name = "btnCancelarChamado";
            btnCancelarChamado.Size = new Size(172, 70);
            btnCancelarChamado.TabIndex = 0;
            btnCancelarChamado.Text = "Cancelar";
            btnCancelarChamado.UseVisualStyleBackColor = false;
            btnCancelarChamado.Click += btnCancelarChamado_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(101, 100);
            comboBox1.Margin = new Padding(4, 5, 4, 5);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(331, 33);
            comboBox1.TabIndex = 1;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(104, 195);
            comboBox2.Margin = new Padding(4, 5, 4, 5);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(331, 33);
            comboBox2.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.HighlightText;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.ForeColor = SystemColors.WindowText;
            textBox1.Location = new Point(99, 317);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 222);
            textBox1.TabIndex = 3;
            // 
            // labelSetorChamado
            // 
            labelSetorChamado.AutoSize = true;
            labelSetorChamado.BackColor = Color.SaddleBrown;
            labelSetorChamado.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelSetorChamado.Location = new Point(223, 48);
            labelSetorChamado.Margin = new Padding(4, 0, 4, 0);
            labelSetorChamado.Name = "labelSetorChamado";
            labelSetorChamado.Size = new Size(89, 28);
            labelSetorChamado.TabIndex = 4;
            labelSetorChamado.Text = "Setor :";
            labelSetorChamado.Click += labelSetorChamado_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(240, 270);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 5;
            // 
            // labelCategoriaChamado
            // 
            labelCategoriaChamado.AutoSize = true;
            labelCategoriaChamado.BackColor = Color.DarkOrange;
            labelCategoriaChamado.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelCategoriaChamado.Location = new Point(207, 163);
            labelCategoriaChamado.Margin = new Padding(4, 0, 4, 0);
            labelCategoriaChamado.Name = "labelCategoriaChamado";
            labelCategoriaChamado.Size = new Size(141, 28);
            labelCategoriaChamado.TabIndex = 6;
            labelCategoriaChamado.Text = "Categoria :";
            // 
            // labelMsgChamado
            // 
            labelMsgChamado.AutoSize = true;
            labelMsgChamado.BackColor = Color.IndianRed;
            labelMsgChamado.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelMsgChamado.Location = new Point(197, 268);
            labelMsgChamado.Margin = new Padding(4, 0, 4, 0);
            labelMsgChamado.Name = "labelMsgChamado";
            labelMsgChamado.Size = new Size(151, 28);
            labelMsgChamado.TabIndex = 7;
            labelMsgChamado.Text = "Mensagem :";
            // 
            // btnCriarChamado
            // 
            btnCriarChamado.BackColor = Color.Teal;
            btnCriarChamado.Font = new Font("Arial Narrow", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnCriarChamado.ForeColor = SystemColors.Desktop;
            btnCriarChamado.Location = new Point(60, 637);
            btnCriarChamado.Margin = new Padding(4, 5, 4, 5);
            btnCriarChamado.Name = "btnCriarChamado";
            btnCriarChamado.Size = new Size(209, 70);
            btnCriarChamado.TabIndex = 8;
            btnCriarChamado.Text = "Criar Chamado";
            btnCriarChamado.UseVisualStyleBackColor = false;
            // 
            // FrmChamado
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 750);
            Controls.Add(btnCriarChamado);
            Controls.Add(labelMsgChamado);
            Controls.Add(labelCategoriaChamado);
            Controls.Add(label1);
            Controls.Add(labelSetorChamado);
            Controls.Add(textBox1);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(btnCancelarChamado);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmChamado";
            Text = "FrmChamado";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarChamado;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private TextBox textBox1;
        private Label labelSetorChamado;
        private Label label1;
        private Label labelCategoriaChamado;
        private Label labelMsgChamado;
        private Button btnCriarChamado;
    }
}