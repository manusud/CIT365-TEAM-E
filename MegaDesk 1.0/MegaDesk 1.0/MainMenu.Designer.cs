namespace MegaDesk_CostaLuiz
{
    partial class mainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            this.label1 = new System.Windows.Forms.Label();
            this.btAddNewQuote = new System.Windows.Forms.Button();
            this.btViewQuotes = new System.Windows.Forms.Button();
            this.btSearchQuotes = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbMainDate = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Georgia", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(778, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mega Desk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAddNewQuote
            // 
            this.btAddNewQuote.BackColor = System.Drawing.Color.Firebrick;
            this.btAddNewQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddNewQuote.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewQuote.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btAddNewQuote.Location = new System.Drawing.Point(475, 132);
            this.btAddNewQuote.Margin = new System.Windows.Forms.Padding(4);
            this.btAddNewQuote.Name = "btAddNewQuote";
            this.btAddNewQuote.Size = new System.Drawing.Size(260, 100);
            this.btAddNewQuote.TabIndex = 1;
            this.btAddNewQuote.Text = "&Add New Quote";
            this.btAddNewQuote.UseVisualStyleBackColor = false;
            this.btAddNewQuote.Click += new System.EventHandler(this.btAddNewQuote_Click);
            // 
            // btViewQuotes
            // 
            this.btViewQuotes.BackColor = System.Drawing.Color.Firebrick;
            this.btViewQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btViewQuotes.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewQuotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btViewQuotes.Location = new System.Drawing.Point(475, 292);
            this.btViewQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.btViewQuotes.Name = "btViewQuotes";
            this.btViewQuotes.Size = new System.Drawing.Size(260, 100);
            this.btViewQuotes.TabIndex = 2;
            this.btViewQuotes.Text = "&View Quotes";
            this.btViewQuotes.UseVisualStyleBackColor = false;
            this.btViewQuotes.Click += new System.EventHandler(this.btViewQuotes_Click);
            // 
            // btSearchQuotes
            // 
            this.btSearchQuotes.BackColor = System.Drawing.Color.Firebrick;
            this.btSearchQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchQuotes.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchQuotes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSearchQuotes.Location = new System.Drawing.Point(475, 450);
            this.btSearchQuotes.Margin = new System.Windows.Forms.Padding(4);
            this.btSearchQuotes.Name = "btSearchQuotes";
            this.btSearchQuotes.Size = new System.Drawing.Size(260, 100);
            this.btSearchQuotes.TabIndex = 3;
            this.btSearchQuotes.Text = "&Search Quotes";
            this.btSearchQuotes.UseVisualStyleBackColor = false;
            this.btSearchQuotes.Click += new System.EventHandler(this.btSearchQuotes_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Firebrick;
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btExit.Location = new System.Drawing.Point(38, 557);
            this.btExit.Margin = new System.Windows.Forms.Padding(4);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(100, 54);
            this.btExit.TabIndex = 4;
            this.btExit.Text = "&Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.BackColor = System.Drawing.Color.Transparent;
            this.lbVersion.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.lbVersion.Location = new System.Drawing.Point(12, 799);
            this.lbVersion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(78, 17);
            this.lbVersion.TabIndex = 5;
            this.lbVersion.Text = "version 1.0";
            // 
            // lbMainDate
            // 
            this.lbMainDate.AutoSize = true;
            this.lbMainDate.BackColor = System.Drawing.Color.Transparent;
            this.lbMainDate.Location = new System.Drawing.Point(713, 800);
            this.lbMainDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMainDate.Name = "lbMainDate";
            this.lbMainDate.Size = new System.Drawing.Size(78, 17);
            this.lbMainDate.TabIndex = 6;
            this.lbMainDate.Text = "version 1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::MegaDesk_CostaLuiz.Properties.Resources.desk;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(55, 193);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(366, 282);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(801, 648);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbMainDate);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSearchQuotes);
            this.Controls.Add(this.btViewQuotes);
            this.Controls.Add(this.btAddNewQuote);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeMainForm);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAddNewQuote;
        private System.Windows.Forms.Button btViewQuotes;
        private System.Windows.Forms.Button btSearchQuotes;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.Label lbMainDate;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

