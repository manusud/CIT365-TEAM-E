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
            this.label1 = new System.Windows.Forms.Label();
            this.btAddNewQuote = new System.Windows.Forms.Button();
            this.btViewQuotes = new System.Windows.Forms.Button();
            this.btSearchQuotes = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.lbVersion = new System.Windows.Forms.Label();
            this.lbMainDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mega Desk";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btAddNewQuote
            // 
            this.btAddNewQuote.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btAddNewQuote.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btAddNewQuote.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btAddNewQuote.Location = new System.Drawing.Point(199, 447);
            this.btAddNewQuote.Name = "btAddNewQuote";
            this.btAddNewQuote.Size = new System.Drawing.Size(195, 44);
            this.btAddNewQuote.TabIndex = 1;
            this.btAddNewQuote.Text = "&Add New Quote";
            this.btAddNewQuote.UseVisualStyleBackColor = false;
            this.btAddNewQuote.Click += new System.EventHandler(this.btAddNewQuote_Click);
            // 
            // btViewQuotes
            // 
            this.btViewQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btViewQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btViewQuotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btViewQuotes.Location = new System.Drawing.Point(199, 497);
            this.btViewQuotes.Name = "btViewQuotes";
            this.btViewQuotes.Size = new System.Drawing.Size(195, 44);
            this.btViewQuotes.TabIndex = 2;
            this.btViewQuotes.Text = "&View Quotes";
            this.btViewQuotes.UseVisualStyleBackColor = false;
            this.btViewQuotes.Click += new System.EventHandler(this.btViewQuotes_Click);
            // 
            // btSearchQuotes
            // 
            this.btSearchQuotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btSearchQuotes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearchQuotes.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearchQuotes.Location = new System.Drawing.Point(199, 547);
            this.btSearchQuotes.Name = "btSearchQuotes";
            this.btSearchQuotes.Size = new System.Drawing.Size(195, 44);
            this.btSearchQuotes.TabIndex = 3;
            this.btSearchQuotes.Text = "&Search Quotes";
            this.btSearchQuotes.UseVisualStyleBackColor = false;
            this.btSearchQuotes.Click += new System.EventHandler(this.btSearchQuotes_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btExit.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btExit.Location = new System.Drawing.Point(199, 597);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(195, 44);
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
            this.lbVersion.Location = new System.Drawing.Point(9, 649);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(59, 13);
            this.lbVersion.TabIndex = 5;
            this.lbVersion.Text = "version 1.0";
            // 
            // lbMainDate
            // 
            this.lbMainDate.AutoSize = true;
            this.lbMainDate.BackColor = System.Drawing.Color.Transparent;
            this.lbMainDate.Location = new System.Drawing.Point(535, 650);
            this.lbMainDate.Name = "lbMainDate";
            this.lbMainDate.Size = new System.Drawing.Size(59, 13);
            this.lbMainDate.TabIndex = 6;
            this.lbMainDate.Text = "version 1.0";
            // 
            // mainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            //this.BackgroundImage = global::MegaDesk_CostaLuiz.Properties.Resources.mainMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(601, 669);
            this.Controls.Add(this.lbMainDate);
            this.Controls.Add(this.lbVersion);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btSearchQuotes);
            this.Controls.Add(this.btViewQuotes);
            this.Controls.Add(this.btAddNewQuote);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "mainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MegaDesk";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeMainForm);
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
    }
}

