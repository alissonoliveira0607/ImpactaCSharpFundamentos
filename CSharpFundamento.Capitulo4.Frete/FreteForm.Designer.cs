namespace CSharpFundamento.Capitulo4.Frete
{
    partial class FreteForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.clienteTextBox = new System.Windows.Forms.TextBox();
            this.ufComboBox = new System.Windows.Forms.ComboBox();
            this.freteTextBox = new System.Windows.Forms.TextBox();
            this.resultadoTextBox = new System.Windows.Forms.TextBox();
            this.calcularButton = new System.Windows.Forms.Button();
            this.limparButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "UF";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "% Frete";
            // 
            // valorTextBox
            // 
            this.valorTextBox.Location = new System.Drawing.Point(70, 46);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(121, 20);
            this.valorTextBox.TabIndex = 3;
            // 
            // clienteTextBox
            // 
            this.clienteTextBox.Location = new System.Drawing.Point(70, 12);
            this.clienteTextBox.Name = "clienteTextBox";
            this.clienteTextBox.Size = new System.Drawing.Size(198, 20);
            this.clienteTextBox.TabIndex = 1;
            // 
            // ufComboBox
            // 
            this.ufComboBox.FormattingEnabled = true;
            this.ufComboBox.Items.AddRange(new object[] {
            "SP",
            "RJ",
            "MG",
            "AM",
            "OUTROS"});
            this.ufComboBox.Location = new System.Drawing.Point(70, 80);
            this.ufComboBox.Name = "ufComboBox";
            this.ufComboBox.Size = new System.Drawing.Size(121, 21);
            this.ufComboBox.TabIndex = 5;
            this.ufComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // freteTextBox
            // 
            this.freteTextBox.Location = new System.Drawing.Point(70, 114);
            this.freteTextBox.Name = "freteTextBox";
            this.freteTextBox.ReadOnly = true;
            this.freteTextBox.Size = new System.Drawing.Size(121, 20);
            this.freteTextBox.TabIndex = 7;
            // 
            // resultadoTextBox
            // 
            this.resultadoTextBox.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.resultadoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultadoTextBox.Location = new System.Drawing.Point(61, 258);
            this.resultadoTextBox.Multiline = true;
            this.resultadoTextBox.Name = "resultadoTextBox";
            this.resultadoTextBox.ReadOnly = true;
            this.resultadoTextBox.Size = new System.Drawing.Size(156, 48);
            this.resultadoTextBox.TabIndex = 10;
            // 
            // calcularButton
            // 
            this.calcularButton.BackColor = System.Drawing.Color.MediumTurquoise;
            this.calcularButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularButton.Location = new System.Drawing.Point(31, 163);
            this.calcularButton.Name = "calcularButton";
            this.calcularButton.Size = new System.Drawing.Size(91, 37);
            this.calcularButton.TabIndex = 8;
            this.calcularButton.Text = "Calcular";
            this.calcularButton.UseVisualStyleBackColor = false;
            this.calcularButton.Click += new System.EventHandler(this.calcularButton_Click);
            // 
            // limparButton
            // 
            this.limparButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.limparButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.limparButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limparButton.Location = new System.Drawing.Point(159, 163);
            this.limparButton.Name = "limparButton";
            this.limparButton.Size = new System.Drawing.Size(91, 37);
            this.limparButton.TabIndex = 9;
            this.limparButton.Text = "Limpar";
            this.limparButton.UseVisualStyleBackColor = false;
            this.limparButton.Click += new System.EventHandler(this.limparButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "TOTAL";
            // 
            // FreteForm
            // 
            this.AcceptButton = this.calcularButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.limparButton;
            this.ClientSize = new System.Drawing.Size(292, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.limparButton);
            this.Controls.Add(this.calcularButton);
            this.Controls.Add(this.resultadoTextBox);
            this.Controls.Add(this.freteTextBox);
            this.Controls.Add(this.ufComboBox);
            this.Controls.Add(this.clienteTextBox);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FreteForm";
            this.Text = "Frete";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.TextBox clienteTextBox;
        private System.Windows.Forms.ComboBox ufComboBox;
        private System.Windows.Forms.TextBox freteTextBox;
        private System.Windows.Forms.TextBox resultadoTextBox;
        private System.Windows.Forms.Button calcularButton;
        private System.Windows.Forms.Button limparButton;
        private System.Windows.Forms.Label label5;
    }
}

