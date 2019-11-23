namespace CSharpFundamentos.Capitulo03.Variaveis
{
    partial class VariaveisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VariaveisForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.operaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resultadoListBox = new System.Windows.Forms.ListBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.aritméticasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduzidasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.incrementaisDecrementaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bOOLEANASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lógicasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ternariasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Gray;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(343, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // operaçõesToolStripMenuItem
            // 
            this.operaçõesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aritméticasToolStripMenuItem,
            this.reduzidasToolStripMenuItem,
            this.incrementaisDecrementaisToolStripMenuItem,
            this.bOOLEANASToolStripMenuItem,
            this.lógicasToolStripMenuItem,
            this.ternariasToolStripMenuItem});
            this.operaçõesToolStripMenuItem.Name = "operaçõesToolStripMenuItem";
            this.operaçõesToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.operaçõesToolStripMenuItem.Text = "&Operações";
            // 
            // resultadoListBox
            // 
            this.resultadoListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.resultadoListBox.FormattingEnabled = true;
            this.resultadoListBox.Location = new System.Drawing.Point(0, 24);
            this.resultadoListBox.Name = "resultadoListBox";
            this.resultadoListBox.Size = new System.Drawing.Size(343, 249);
            this.resultadoListBox.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.BackColor = System.Drawing.Color.Gray;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.minimize;
            this.pictureBox3.Location = new System.Drawing.Point(271, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.BackColor = System.Drawing.Color.Gray;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.maximize;
            this.pictureBox2.Location = new System.Drawing.Point(297, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 24);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.Gray;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.cloose;
            this.pictureBox1.Location = new System.Drawing.Point(323, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // aritméticasToolStripMenuItem
            // 
            this.aritméticasToolStripMenuItem.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.aritmetica;
            this.aritméticasToolStripMenuItem.Name = "aritméticasToolStripMenuItem";
            this.aritméticasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.aritméticasToolStripMenuItem.Text = "&Aritméticas";
            this.aritméticasToolStripMenuItem.Click += new System.EventHandler(this.aritméticasToolStripMenuItem_Click);
            // 
            // reduzidasToolStripMenuItem
            // 
            this.reduzidasToolStripMenuItem.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.minimum_maximum_chart_256;
            this.reduzidasToolStripMenuItem.Name = "reduzidasToolStripMenuItem";
            this.reduzidasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.reduzidasToolStripMenuItem.Text = "&Reduzidas";
            this.reduzidasToolStripMenuItem.Click += new System.EventHandler(this.reduzidasToolStripMenuItem_Click);
            // 
            // incrementaisDecrementaisToolStripMenuItem
            // 
            this.incrementaisDecrementaisToolStripMenuItem.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.istockphoto_851994120_1024x1024;
            this.incrementaisDecrementaisToolStripMenuItem.Name = "incrementaisDecrementaisToolStripMenuItem";
            this.incrementaisDecrementaisToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.incrementaisDecrementaisToolStripMenuItem.Text = "&Incrementais/Decrementais";
            this.incrementaisDecrementaisToolStripMenuItem.Click += new System.EventHandler(this.incrementaisDecrementaisToolStripMenuItem_Click);
            // 
            // bOOLEANASToolStripMenuItem
            // 
            this.bOOLEANASToolStripMenuItem.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources._7683___Logic_256;
            this.bOOLEANASToolStripMenuItem.Name = "bOOLEANASToolStripMenuItem";
            this.bOOLEANASToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.bOOLEANASToolStripMenuItem.Text = "&Booleanas";
            this.bOOLEANASToolStripMenuItem.Click += new System.EventHandler(this.bOOLEANASToolStripMenuItem_Click);
            // 
            // lógicasToolStripMenuItem
            // 
            this.lógicasToolStripMenuItem.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources.development_algorithm_scheme_128;
            this.lógicasToolStripMenuItem.Name = "lógicasToolStripMenuItem";
            this.lógicasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.lógicasToolStripMenuItem.Text = "&Lógicas";
            this.lógicasToolStripMenuItem.Click += new System.EventHandler(this.lógicasToolStripMenuItem_Click);
            // 
            // ternariasToolStripMenuItem
            // 
            this.ternariasToolStripMenuItem.Image = global::CSharpFundamentos.Capitulo03.Variaveis.Properties.Resources._041_calendar_plans_schedule_time_date_day_week_128;
            this.ternariasToolStripMenuItem.Name = "ternariasToolStripMenuItem";
            this.ternariasToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.ternariasToolStripMenuItem.Text = "&Ternarias";
            this.ternariasToolStripMenuItem.Click += new System.EventHandler(this.ternariasToolStripMenuItem_Click);
            // 
            // VariaveisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 273);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.resultadoListBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "VariaveisForm";
            this.Text = "Variaveis e Operações";
            this.Load += new System.EventHandler(this.VariaveisForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem operaçõesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aritméticasToolStripMenuItem;
        private System.Windows.Forms.ListBox resultadoListBox;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ToolStripMenuItem reduzidasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incrementaisDecrementaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bOOLEANASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lógicasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ternariasToolStripMenuItem;
    }
}

