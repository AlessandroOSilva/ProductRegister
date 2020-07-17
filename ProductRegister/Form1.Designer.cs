namespace ProductRegister
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelChild = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkBlue;
            this.panelMenu.Controls.Add(this.btnCadastro);
            this.panelMenu.Controls.Add(this.btnListar);
            this.panelMenu.Controls.Add(this.btnSair);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 561);
            this.panelMenu.TabIndex = 0;
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnCadastro.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCadastro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadastro.Location = new System.Drawing.Point(0, 249);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(200, 100);
            this.btnCadastro.TabIndex = 3;
            this.btnCadastro.Text = "Cadastro";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnListar.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnListar.FlatAppearance.BorderSize = 0;
            this.btnListar.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnListar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnListar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnListar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListar.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnListar.Location = new System.Drawing.Point(0, 355);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(200, 100);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar";
            this.btnListar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.Navy;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatAppearance.CheckedBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Malgun Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSair.Location = new System.Drawing.Point(0, 461);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(200, 100);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "Sair";
            this.btnSair.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // panelChild
            // 
            this.panelChild.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(200, 0);
            this.panelChild.MaximumSize = new System.Drawing.Size(584, 561);
            this.panelChild.Name = "panelChild";
            this.panelChild.Size = new System.Drawing.Size(584, 561);
            this.panelChild.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelChild;
    }
}

