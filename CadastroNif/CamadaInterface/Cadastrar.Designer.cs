using System.Windows.Forms;

namespace Nif.CamadaInterface
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
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NomeCompletoTextBox = new System.Windows.Forms.TextBox();
            this.MoradaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ProfissaoTextBox = new System.Windows.Forms.TextBox();
            this.GravarButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TelefoneTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.DataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.nifGeradoLabel = new System.Windows.Forms.Label();
            this.NifLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nome Completo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 15);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sexo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Profissão:";
            // 
            // NomeCompletoTextBox
            // 
            this.NomeCompletoTextBox.Location = new System.Drawing.Point(144, 40);
            this.NomeCompletoTextBox.Name = "NomeCompletoTextBox";
            this.NomeCompletoTextBox.Size = new System.Drawing.Size(257, 20);
            this.NomeCompletoTextBox.TabIndex = 0;
            // 
            // MoradaTextBox
            // 
            this.MoradaTextBox.Location = new System.Drawing.Point(144, 75);
            this.MoradaTextBox.Name = "MoradaTextBox";
            this.MoradaTextBox.Size = new System.Drawing.Size(257, 20);
            this.MoradaTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(12, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Morada:";
            // 
            // ProfissaoTextBox
            // 
            this.ProfissaoTextBox.Location = new System.Drawing.Point(144, 189);
            this.ProfissaoTextBox.Name = "ProfissaoTextBox";
            this.ProfissaoTextBox.Size = new System.Drawing.Size(257, 20);
            this.ProfissaoTextBox.TabIndex = 4;
            // 
            // GravarButton
            // 
            this.GravarButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.GravarButton.Location = new System.Drawing.Point(15, 360);
            this.GravarButton.Name = "GravarButton";
            this.GravarButton.Size = new System.Drawing.Size(60, 32);
            this.GravarButton.TabIndex = 8;
            this.GravarButton.Text = "Gravar";
            this.GravarButton.UseVisualStyleBackColor = true;
            this.GravarButton.Click += new System.EventHandler(this.Gravar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(12, 234);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Email:";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(144, 226);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(257, 20);
            this.EmailTextBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(12, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Telefone:";
            // 
            // TelefoneTextBox
            // 
            this.TelefoneTextBox.Location = new System.Drawing.Point(144, 265);
            this.TelefoneTextBox.Name = "TelefoneTextBox";
            this.TelefoneTextBox.Size = new System.Drawing.Size(78, 20);
            this.TelefoneTextBox.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(12, 157);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "Data de Nascimento:";
            // 
            // DataNascimentoDateTimePicker
            // 
            this.DataNascimentoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DataNascimentoDateTimePicker.Location = new System.Drawing.Point(144, 152);
            this.DataNascimentoDateTimePicker.Name = "DataNascimentoDateTimePicker";
            this.DataNascimentoDateTimePicker.Size = new System.Drawing.Size(78, 20);
            this.DataNascimentoDateTimePicker.TabIndex = 3;
            // 
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Location = new System.Drawing.Point(144, 112);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(78, 21);
            this.SexoComboBox.TabIndex = 2;
            // 
            // nifGeradoLabel
            // 
            this.nifGeradoLabel.AutoSize = true;
            this.nifGeradoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nifGeradoLabel.Location = new System.Drawing.Point(12, 306);
            this.nifGeradoLabel.Name = "nifGeradoLabel";
            this.nifGeradoLabel.Size = new System.Drawing.Size(29, 15);
            this.nifGeradoLabel.TabIndex = 16;
            this.nifGeradoLabel.Text = "NIF:";
            // 
            // NifLabel
            // 
            this.NifLabel.AutoSize = true;
            this.NifLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NifLabel.Location = new System.Drawing.Point(141, 306);
            this.NifLabel.Name = "NifLabel";
            this.NifLabel.Size = new System.Drawing.Size(0, 17);
            this.NifLabel.TabIndex = 26;
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
            this.Controls.Add(this.GravarButton);
            this.Controls.Add(this.ProfissaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MoradaTextBox);
            this.Controls.Add(this.NomeCompletoTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Cadastrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label5;
        private TextBox NomeCompletoTextBox;
        private TextBox MoradaTextBox;
        private Label label2;
        private TextBox ProfissaoTextBox;
        private Button GravarButton;
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