namespace CadastroNif
{
    partial class Cadastro
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
            this.CadastrarButton = new System.Windows.Forms.Button();
            this.SobreButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.ObterButton = new System.Windows.Forms.Button();
            this.ListarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CadastrarButton
            // 
            this.CadastrarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CadastrarButton.Location = new System.Drawing.Point(12, 12);
            this.CadastrarButton.Name = "CadastrarButton";
            this.CadastrarButton.Size = new System.Drawing.Size(79, 43);
            this.CadastrarButton.TabIndex = 0;
            this.CadastrarButton.Text = "Cadastrar";
            this.CadastrarButton.UseVisualStyleBackColor = true;
            this.CadastrarButton.Click += new System.EventHandler(this.CadastrarButton_Click);
            // 
            // SobreButton
            // 
            this.SobreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SobreButton.Location = new System.Drawing.Point(113, 161);
            this.SobreButton.Name = "SobreButton";
            this.SobreButton.Size = new System.Drawing.Size(68, 28);
            this.SobreButton.TabIndex = 1;
            this.SobreButton.Text = "Sobre";
            this.SobreButton.UseVisualStyleBackColor = true;
            this.SobreButton.Click += new System.EventHandler(this.SobreButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EliminarButton.Location = new System.Drawing.Point(12, 74);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(79, 43);
            this.EliminarButton.TabIndex = 2;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // ObterButton
            // 
            this.ObterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ObterButton.Location = new System.Drawing.Point(102, 12);
            this.ObterButton.Name = "ObterButton";
            this.ObterButton.Size = new System.Drawing.Size(79, 43);
            this.ObterButton.TabIndex = 3;
            this.ObterButton.Text = "Obter";
            this.ObterButton.UseVisualStyleBackColor = true;
            this.ObterButton.Click += new System.EventHandler(this.ObterButton_Click);
            // 
            // ListarButton
            // 
            this.ListarButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListarButton.Location = new System.Drawing.Point(102, 74);
            this.ListarButton.Name = "ListarButton";
            this.ListarButton.Size = new System.Drawing.Size(79, 43);
            this.ListarButton.TabIndex = 4;
            this.ListarButton.Text = "Listar";
            this.ListarButton.UseVisualStyleBackColor = true;
            // 
            // Cadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 201);
            this.Controls.Add(this.ListarButton);
            this.Controls.Add(this.ObterButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.SobreButton);
            this.Controls.Add(this.CadastrarButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NIF";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CadastrarButton;
        private System.Windows.Forms.Button SobreButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button ObterButton;
        private System.Windows.Forms.Button ListarButton;
    }
}

