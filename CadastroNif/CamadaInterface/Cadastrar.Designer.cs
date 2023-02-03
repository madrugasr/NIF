using System.Windows.Forms;

namespace CadastroNif.CamadaInterface
{
    partial class Cadastrar
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.novoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarNIFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GravarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeCompletoTextBox = new System.Windows.Forms.TextBox();
            this.MoradaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfissaoTextBox = new System.Windows.Forms.TextBox();
            this.NovoButton = new System.Windows.Forms.Button();
            this.GravarButton = new System.Windows.Forms.Button();
            this.SobreButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.nifGeradoLabel = new System.Windows.Forms.Label();
            this.NifLabel = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.novoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // novoToolStripMenuItem
            // 
            this.novoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.criarNIFToolStripMenuItem,
            this.GravarToolStripMenuItem,
            this.EliminarToolStripMenuItem,
            this.SobreToolStripMenuItem});
            this.novoToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.novoToolStripMenuItem.Name = "novoToolStripMenuItem";
            this.novoToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.novoToolStripMenuItem.Text = "NIF";
            // 
            // criarNIFToolStripMenuItem
            // 
            this.criarNIFToolStripMenuItem.Name = "criarNIFToolStripMenuItem";
            this.criarNIFToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.criarNIFToolStripMenuItem.Text = "Novo";
            this.criarNIFToolStripMenuItem.Click += new System.EventHandler(this.Novo_Click);
            // 
            // GravarToolStripMenuItem
            // 
            this.GravarToolStripMenuItem.Name = "GravarToolStripMenuItem";
            this.GravarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.GravarToolStripMenuItem.Text = "Gravar";
            this.GravarToolStripMenuItem.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // EliminarToolStripMenuItem
            // 
            this.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem";
            this.EliminarToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            // 
            // SobreToolStripMenuItem
            // 
            this.SobreToolStripMenuItem.Name = "SobreToolStripMenuItem";
            this.SobreToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.SobreToolStripMenuItem.Text = "Sobre";
            this.SobreToolStripMenuItem.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Profissão:";
            // 
            // NomeCompletoTextBox
            // 
            this.NomeCompletoTextBox.Location = new System.Drawing.Point(144, 40);
            this.NomeCompletoTextBox.Name = "NomeCompletoTextBox";
            this.NomeCompletoTextBox.Size = new System.Drawing.Size(257, 20);
            this.NomeCompletoTextBox.TabIndex = 6;
            // 
            // MoradaTextBox
            // 
            this.MoradaTextBox.Location = new System.Drawing.Point(144, 75);
            this.MoradaTextBox.Name = "MoradaTextBox";
            this.MoradaTextBox.Size = new System.Drawing.Size(257, 20);
            this.MoradaTextBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "Morada:";
            // 
            // ProfissaoTextBox
            // 
            this.ProfissaoTextBox.Location = new System.Drawing.Point(144, 189);
            this.ProfissaoTextBox.Name = "ProfissaoTextBox";
            this.ProfissaoTextBox.Size = new System.Drawing.Size(257, 20);
            this.ProfissaoTextBox.TabIndex = 11;
            // 
            // NovoButton
            // 
            this.NovoButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.NovoButton.Location = new System.Drawing.Point(12, 360);
            this.NovoButton.Name = "NovoButton";
            this.NovoButton.Size = new System.Drawing.Size(60, 32);
            this.NovoButton.TabIndex = 12;
            this.NovoButton.Text = "Novo";
            this.NovoButton.UseVisualStyleBackColor = true;
            this.NovoButton.Click += new System.EventHandler(this.Novo_Click);
            // 
            // GravarButton
            // 
            this.GravarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.GravarButton.Location = new System.Drawing.Point(78, 360);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(60, 32);
            this.GravarButton.TabIndex = 13;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.UseVisualStyleBackColor = true;
            this.GravarButton.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // SobreButton
            // 
            this.SobreButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.SobreButton.Location = new System.Drawing.Point(323, 360);
            this.SobreButton.Name = "SobreButton";
            this.SobreButton.Size = new System.Drawing.Size(78, 32);
            this.SobreButton.TabIndex = 16;
            this.SobreButton.Text = "Sobre";
            this.SobreButton.UseVisualStyleBackColor = true;
            this.SobreButton.Click += new System.EventHandler(this.Sobre_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(144, 226);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(257, 20);
            this.EmailTextBox.TabIndex = 18;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Telefone:";
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(144, 265);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(78, 20);
            this.TelefoneTextBox.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 21;
            this.label8.Text = "Data de Nascimento:";
            // 
            // DataNascimentoDateTimePicker
            // 
            this.DataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascimentoDateTimePicker.Location = new System.Drawing.Point(144, 152);
            this.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker";
            this.DataNascimentoDateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.DataNascimentoDateTimePicker.TabIndex = 23;
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Location = new System.Drawing.Point(144, 112);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(78, 21);
            this.SexoComboBox.TabIndex = 24;
            // 
            // nifGeradoLabel
            // 
            this.nifGeradoLabel.AutoSize = true;
            this.nifGeradoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nifGeradoLabel.Location = new System.Drawing.Point(12, 306);
            this.nifGeradoLabel.Name = "nifGeradoLabel";
            this.nifGeradoLabel.Size = new System.Drawing.Size(27, 15);
            this.nifGeradoLabel.TabIndex = 25;
            this.nifGeradoLabel.Text = "Nif:";
            // 
            // NifLabel
            // 
            this.NifLabel.AutoSize = true;
            this.NifLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NifLabel.Location = new System.Drawing.Point(141, 306);
            this.NifLabel.Name = "NifLabel";
            this.NifLabel.Size = new System.Drawing.Size(71, 17);
            this.NifLabel.TabIndex = 26;
            this.NifLabel.Text = "NifGerado";
            // 
            // Cadastrar
            // 
            this.ClientSize = new System.Drawing.Size(413, 404);
            this.Controls.Add(this.NifLabel);
            this.Controls.Add(this.nifGeradoLabel);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.DataNascimentoDateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.TelefoneTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.SobreButton);
            this.Controls.Add(this.GravarButton);
            this.Controls.Add(this.NovoButton);
            this.Controls.Add(this.ProfissaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoradaTextBox);
            this.Controls.Add(this.NomeCompletoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem novoToolStripMenuItem;
        private ToolStripMenuItem criarNIFToolStripMenuItem;
        private ToolStripMenuItem GravarToolStripMenuItem;
        private ToolStripMenuItem EliminarToolStripMenuItem;
        private ToolStripMenuItem SobreToolStripMenuItem;
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox NomeCompletoTextBox;
        private TextBox MoradaTextBox;
        private Label label2;
        private TextBox ProfissaoTextBox;
        private Button NovoButton;
        private Button GravarButton;
        private Button SobreButton;
        private Label label6;
        private TextBox EmailTextBox;
        private Label label7;
        private TextBox TelefoneTextBox;
        private Label label8;
        private DateTimePicker DataNascimentoDateTimePicker;
        private ComboBox SexoComboBox;
        private Label nifGeradoLabel;
        private Label NifLabel;
    }
}