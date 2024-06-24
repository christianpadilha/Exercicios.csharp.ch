namespace Exercicios
{
    partial class FrmUsuario
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnVoltarUsuario = new Button();
            LinkCadartrar = new LinkLabel();
            checkBoxSenha = new CheckBox();
            groupBoxLogin = new GroupBox();
            groupBoxLogin.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(83, 62);
            textBox1.Margin = new Padding(4, 5, 4, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 44);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(83, 177);
            textBox2.Margin = new Padding(4, 5, 4, 5);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(307, 44);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(83, 300);
            textBox3.Margin = new Padding(4, 5, 4, 5);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(307, 44);
            textBox3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(178, 20);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(137, 37);
            label1.TabIndex = 3;
            label1.Text = "NOME :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(137, 37);
            label2.TabIndex = 4;
            label2.Text = "EMAIL :";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(178, 258);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(153, 37);
            label3.TabIndex = 5;
            label3.Text = "SENHA :";
            // 
            // btnVoltarUsuario
            // 
            btnVoltarUsuario.BackColor = Color.Yellow;
            btnVoltarUsuario.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVoltarUsuario.Location = new Point(439, 40);
            btnVoltarUsuario.Margin = new Padding(4, 5, 4, 5);
            btnVoltarUsuario.Name = "btnVoltarUsuario";
            btnVoltarUsuario.Size = new Size(60, 62);
            btnVoltarUsuario.TabIndex = 6;
            btnVoltarUsuario.Text = "↶";
            btnVoltarUsuario.UseVisualStyleBackColor = false;
            btnVoltarUsuario.Click += btnVoltarUsuario_Click;
            // 
            // LinkCadartrar
            // 
            LinkCadartrar.AutoSize = true;
            LinkCadartrar.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            LinkCadartrar.LinkColor = Color.FromArgb(0, 192, 192);
            LinkCadartrar.Location = new Point(75, 439);
            LinkCadartrar.Margin = new Padding(4, 0, 4, 0);
            LinkCadartrar.Name = "LinkCadartrar";
            LinkCadartrar.Size = new Size(355, 25);
            LinkCadartrar.TabIndex = 7;
            LinkCadartrar.TabStop = true;
            LinkCadartrar.Text = "NÃO É USUÁRIO? CADASTRE-SE";
            LinkCadartrar.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // checkBoxSenha
            // 
            checkBoxSenha.AutoSize = true;
            checkBoxSenha.Location = new Point(33, 370);
            checkBoxSenha.Margin = new Padding(4, 5, 4, 5);
            checkBoxSenha.Name = "checkBoxSenha";
            checkBoxSenha.Size = new Size(416, 41);
            checkBoxSenha.TabIndex = 8;
            checkBoxSenha.Text = "MANTER-ME LOGADO?";
            checkBoxSenha.UseVisualStyleBackColor = true;
            // 
            // groupBoxLogin
            // 
            groupBoxLogin.Controls.Add(label1);
            groupBoxLogin.Controls.Add(checkBoxSenha);
            groupBoxLogin.Controls.Add(textBox1);
            groupBoxLogin.Controls.Add(LinkCadartrar);
            groupBoxLogin.Controls.Add(textBox2);
            groupBoxLogin.Controls.Add(textBox3);
            groupBoxLogin.Controls.Add(label3);
            groupBoxLogin.Controls.Add(label2);
            groupBoxLogin.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            groupBoxLogin.Location = new Point(33, 112);
            groupBoxLogin.Margin = new Padding(4, 5, 4, 5);
            groupBoxLogin.Name = "groupBoxLogin";
            groupBoxLogin.Padding = new Padding(4, 5, 4, 5);
            groupBoxLogin.Size = new Size(466, 525);
            groupBoxLogin.TabIndex = 9;
            groupBoxLogin.TabStop = false;
            groupBoxLogin.Text = "LOGIN";
            // 
            // FrmUsuario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(541, 750);
            Controls.Add(groupBoxLogin);
            Controls.Add(btnVoltarUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmUsuario";
            Text = "FrmUsuario";
            groupBoxLogin.ResumeLayout(false);
            groupBoxLogin.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnVoltarUsuario;
        private LinkLabel LinkCadartrar;
        private CheckBox checkBoxSenha;
        private GroupBox groupBoxLogin;
    }
}