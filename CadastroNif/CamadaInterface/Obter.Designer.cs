using System.Windows.Forms;

namespace Nif.CamadaInterface
{
    partial class Obter
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
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.DataNascimentoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.nifGeradoLabel = new System.Windows.Forms.Label();
            this.NifLabel = new System.Windows.Forms.Label();
            this.SexoComboBox = new System.Windows.Forms.ComboBox();
            this.MoradaLabel = new System.Windows.Forms.Label();
            this.ProfissaoLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TelefoneLabel = new System.Windows.Forms.Label();
            this.ObterButton = new System.Windows.Forms.Button();
            this.NomeCompletoTextBox = new System.Windows.Forms.TextBox();
            this.LimparDadosButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            // nifGeradoLabel
            // 
            this.nifGeradoLabel.AutoSize = true;
            this.nifGeradoLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.nifGeradoLabel.Location = new System.Drawing.Point(12, 306);
            this.nifGeradoLabel.Name = "nifGeradoLabel";
            this.nifGeradoLabel.Size = new System.Drawing.Size(29, 15);
            this.nifGeradoLabel.TabIndex = 25;
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
            // SexoComboBox
            // 
            this.SexoComboBox.FormattingEnabled = true;
            this.SexoComboBox.Location = new System.Drawing.Point(144, 112);
            this.SexoComboBox.Name = "SexoComboBox";
            this.SexoComboBox.Size = new System.Drawing.Size(78, 21);
            this.SexoComboBox.TabIndex = 24;
            // 
            // MoradaLabel
            // 
            this.MoradaLabel.AutoSize = true;
            this.MoradaLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoradaLabel.Location = new System.Drawing.Point(141, 81);
            this.MoradaLabel.Name = "MoradaLabel";
            this.MoradaLabel.Size = new System.Drawing.Size(0, 17);
            this.MoradaLabel.TabIndex = 27;
            // 
            // ProfissaoLabel
            // 
            this.ProfissaoLabel.AutoSize = true;
            this.ProfissaoLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProfissaoLabel.Location = new System.Drawing.Point(141, 195);
            this.ProfissaoLabel.Name = "ProfissaoLabel";
            this.ProfissaoLabel.Size = new System.Drawing.Size(0, 17);
            this.ProfissaoLabel.TabIndex = 28;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailLabel.Location = new System.Drawing.Point(141, 232);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(0, 17);
            this.EmailLabel.TabIndex = 29;
            // 
            // TelefoneLabel
            // 
            this.TelefoneLabel.AutoSize = true;
            this.TelefoneLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneLabel.Location = new System.Drawing.Point(141, 268);
            this.TelefoneLabel.Name = "TelefoneLabel";
            this.TelefoneLabel.Size = new System.Drawing.Size(0, 17);
            this.TelefoneLabel.TabIndex = 30;
            // 
            // ObterButton
            // 
            this.ObterButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.ObterButton.Location = new System.Drawing.Point(15, 360);
            this.ObterButton.Name = "ObterButton";
            this.ObterButton.Size = new System.Drawing.Size(60, 32);
            this.ObterButton.TabIndex = 31;
            this.ObterButton.Text = "Obter";
            this.ObterButton.UseVisualStyleBackColor = true;
            this.ObterButton.Click += new System.EventHandler(this.ObterButton_Click);
            // 
            // NomeCompletoTextBox
            // 
            this.NomeCompletoTextBox.Location = new System.Drawing.Point(144, 38);
            this.NomeCompletoTextBox.Name = "NomeCompletoTextBox";
            this.NomeCompletoTextBox.Size = new System.Drawing.Size(161, 20);
            this.NomeCompletoTextBox.TabIndex = 0;
            // 
            // LimparDadosButton
            // 
            this.LimparDadosButton.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.LimparDadosButton.Location = new System.Drawing.Point(245, 360);
            this.LimparDadosButton.Name = "LimparDadosButton";
            this.LimparDadosButton.Size = new System.Drawing.Size(60, 32);
            this.LimparDadosButton.TabIndex = 32;
            this.LimparDadosButton.Text = "Limpar";
            this.LimparDadosButton.UseVisualStyleBackColor = true;
            this.LimparDadosButton.Click += new System.EventHandler(this.LimparDadosButton_Click);
            // 
            // Obter
            // 
            this.ClientSize = new System.Drawing.Size(321, 404);
            this.Controls.Add(this.LimparDadosButton);
            this.Controls.Add(this.NomeCompletoTextBox);
            this.Controls.Add(this.ObterButton);
            this.Controls.Add(this.TelefoneLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.ProfissaoLabel);
            this.Controls.Add(this.MoradaLabel);
            this.Controls.Add(this.NifLabel);
            this.Controls.Add(this.nifGeradoLabel);
            this.Controls.Add(this.SexoComboBox);
            this.Controls.Add(this.DataNascimentoDateTimePicker);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Obter";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Obter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label1;
        private Label label4;
        private Label label5;
        private Label label2;
        private Label label6;
        private Label label7;
        private Label label8;
        private DateTimePicker DataNascimentoDateTimePicker;
        private Label nifGeradoLabel;
        private Label NifLabel;
        private ComboBox SexoComboBox;
        private Label MoradaLabel;
        private Label ProfissaoLabel;
        private Label EmailLabel;
        private Label TelefoneLabel;
        private Button ObterButton;
        private TextBox NomeCompletoTextBox;
        private Button LimparDadosButton;
    }
}