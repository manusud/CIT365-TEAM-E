namespace MegaDesk_CostaLuiz
{
    partial class AddNewQuote
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewQuote));
            this.lbcustomerName = new System.Windows.Forms.Label();
            this.QuotecustomerName = new System.Windows.Forms.TextBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbWarning = new System.Windows.Forms.Label();
            this.QuoteDepth = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.QuoteWidth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.QuoteMaterial = new System.Windows.Forms.ComboBox();
            this.QuoteDrawers = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.QuoteRush = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbcustomerName
            // 
            this.lbcustomerName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcustomerName.ForeColor = System.Drawing.Color.White;
            this.lbcustomerName.Location = new System.Drawing.Point(74, 37);
            this.lbcustomerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbcustomerName.Name = "lbcustomerName";
            this.lbcustomerName.Size = new System.Drawing.Size(262, 42);
            this.lbcustomerName.TabIndex = 0;
            this.lbcustomerName.Text = "Customer Name:";
            this.lbcustomerName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbcustomerName.Click += new System.EventHandler(this.lbcustomerName_Click);
            // 
            // QuotecustomerName
            // 
            this.QuotecustomerName.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuotecustomerName.Location = new System.Drawing.Point(349, 41);
            this.QuotecustomerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuotecustomerName.Name = "QuotecustomerName";
            this.QuotecustomerName.Size = new System.Drawing.Size(418, 38);
            this.QuotecustomerName.TabIndex = 0;
            this.QuotecustomerName.TextChanged += new System.EventHandler(this.QuotecustomerName_TextChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSubmit.ForeColor = System.Drawing.Color.Red;
            this.btSubmit.Location = new System.Drawing.Point(438, 522);
            this.btSubmit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(300, 75);
            this.btSubmit.TabIndex = 2;
            this.btSubmit.TabStop = false;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Black;
            this.btClose.Location = new System.Drawing.Point(63, 547);
            this.btClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(150, 50);
            this.btClose.TabIndex = 3;
            this.btClose.TabStop = false;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbWarning);
            this.groupBox1.Controls.Add(this.QuoteDepth);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.QuoteWidth);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(63, 131);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 91);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size ( in. )";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(488, 69);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 15);
            this.label4.TabIndex = 13;
            this.label4.Text = "Min: 12 Max: 48";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbWarning
            // 
            this.lbWarning.Font = new System.Drawing.Font("Bahnschrift Condensed", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(95, 69);
            this.lbWarning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(123, 15);
            this.lbWarning.TabIndex = 12;
            this.lbWarning.Text = "Min: 24 Max: 96";
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuoteDepth
            // 
            this.QuoteDepth.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDepth.Location = new System.Drawing.Point(492, 36);
            this.QuoteDepth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuoteDepth.Name = "QuoteDepth";
            this.QuoteDepth.Size = new System.Drawing.Size(183, 32);
            this.QuoteDepth.TabIndex = 3;
            this.QuoteDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuoteDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDepth);
            this.QuoteDepth.Validating += new System.ComponentModel.CancelEventHandler(this.ValidadeDeph2);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(408, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Depth:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuoteWidth
            // 
            this.QuoteWidth.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteWidth.Location = new System.Drawing.Point(99, 36);
            this.QuoteWidth.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuoteWidth.Name = "QuoteWidth";
            this.QuoteWidth.Size = new System.Drawing.Size(183, 32);
            this.QuoteWidth.TabIndex = 2;
            this.QuoteWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuoteWidth.Validating += new System.ComponentModel.CancelEventHandler(this.ValidadeWidth);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Width:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.QuoteMaterial);
            this.groupBox2.Controls.Add(this.QuoteDrawers);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(63, 269);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(705, 91);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // QuoteMaterial
            // 
            this.QuoteMaterial.BackColor = System.Drawing.Color.White;
            this.QuoteMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteMaterial.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteMaterial.FormattingEnabled = true;
            this.QuoteMaterial.Location = new System.Drawing.Point(493, 36);
            this.QuoteMaterial.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuoteMaterial.Name = "QuoteMaterial";
            this.QuoteMaterial.Size = new System.Drawing.Size(181, 32);
            this.QuoteMaterial.TabIndex = 10;
            // 
            // QuoteDrawers
            // 
            this.QuoteDrawers.BackColor = System.Drawing.Color.White;
            this.QuoteDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteDrawers.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDrawers.FormattingEnabled = true;
            this.QuoteDrawers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.QuoteDrawers.Location = new System.Drawing.Point(240, 36);
            this.QuoteDrawers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuoteDrawers.MaxLength = 1;
            this.QuoteDrawers.Name = "QuoteDrawers";
            this.QuoteDrawers.Size = new System.Drawing.Size(56, 32);
            this.QuoteDrawers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(305, 41);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desktop Material:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(13, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(228, 22);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Drawers:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QuoteRush);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(63, 414);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox3.Size = new System.Drawing.Size(705, 91);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shipping";
            // 
            // QuoteRush
            // 
            this.QuoteRush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteRush.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteRush.FormattingEnabled = true;
            this.QuoteRush.Location = new System.Drawing.Point(245, 37);
            this.QuoteRush.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.QuoteRush.Name = "QuoteRush";
            this.QuoteRush.Size = new System.Drawing.Size(429, 32);
            this.QuoteRush.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(13, 41);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(228, 22);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rush Order Options:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(832, 653);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.QuotecustomerName);
            this.Controls.Add(this.lbcustomerName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "AddNewQuote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbcustomerName;
        private System.Windows.Forms.TextBox QuotecustomerName;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox QuoteDepth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox QuoteWidth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox QuoteMaterial;
        private System.Windows.Forms.ComboBox QuoteDrawers;
        private System.Windows.Forms.ComboBox QuoteRush;
        private System.Windows.Forms.Label lbWarning;
        private System.Windows.Forms.Label label4;
    }
}