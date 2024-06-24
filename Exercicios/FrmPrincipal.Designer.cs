namespace Exercicios
{
    partial class FrmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnUsuario = new Button();
            btnChamado = new Button();
            btnSair = new Button();
            SuspendLayout();
            // 
            // btnUsuario
            // 
            btnUsuario.Font = new Font("Sitka Text", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUsuario.ForeColor = Color.Blue;
            btnUsuario.Location = new Point(69, 110);
            btnUsuario.Margin = new Padding(4, 5, 4, 5);
            btnUsuario.Name = "btnUsuario";
            btnUsuario.Size = new Size(400, 108);
            btnUsuario.TabIndex = 0;
            btnUsuario.Text = "USUÁRIO";
            btnUsuario.UseVisualStyleBackColor = true;
            btnUsuario.Click += btnUsuario_Click;
            // 
            // btnChamado
            // 
            btnChamado.Font = new Font("Sitka Small", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnChamado.Location = new Point(69, 287);
            btnChamado.Margin = new Padding(4, 5, 4, 5);
            btnChamado.Name = "btnChamado";
            btnChamado.Size = new Size(400, 108);
            btnChamado.TabIndex = 1;
            btnChamado.Text = "CHAMADO";
            btnChamado.UseVisualStyleBackColor = true;
            btnChamado.Click += btnChamado_Click;
            // 
            // btnSair
            // 
            btnSair.BackColor = Color.FromArgb(0, 64, 64);
            btnSair.Font = new Font("Sitka Text", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnSair.ForeColor = SystemColors.MenuBar;
            btnSair.Location = new Point(93, 518);
            btnSair.Margin = new Padding(4, 5, 4, 5);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(326, 68);
            btnSair.TabIndex = 2;
            btnSair.Text = "SAIR";
            btnSair.UseVisualStyleBackColor = false;
            btnSair.Click += btnSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(543, 750);
            Controls.Add(btnSair);
            Controls.Add(btnChamado);
            Controls.Add(btnUsuario);
            Margin = new Padding(4, 5, 4, 5);
            Name = "FrmPrincipal";
            Text = "FrmPrincipal";
            ResumeLayout(false);
        }

        #endregion

        private Button btnUsuario;
        private Button btnChamado;
        private Button btnSair;
    }
}
