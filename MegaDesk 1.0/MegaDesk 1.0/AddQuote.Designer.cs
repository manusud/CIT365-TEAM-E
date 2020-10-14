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
            this.lbCostumerName = new System.Windows.Forms.Label();
            this.QuoteCostumerName = new System.Windows.Forms.TextBox();
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
            // lbCostumerName
            // 
            this.lbCostumerName.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lbCostumerName.Location = new System.Drawing.Point(26, 25);
            this.lbCostumerName.Name = "lbCostumerName";
            this.lbCostumerName.Size = new System.Drawing.Size(186, 34);
            this.lbCostumerName.TabIndex = 0;
            this.lbCostumerName.Text = "Costumer Name:";
            this.lbCostumerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuoteCostumerName
            // 
            this.QuoteCostumerName.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteCostumerName.Location = new System.Drawing.Point(207, 27);
            this.QuoteCostumerName.Name = "QuoteCostumerName";
            this.QuoteCostumerName.Size = new System.Drawing.Size(353, 32);
            this.QuoteCostumerName.TabIndex = 0;
            this.QuoteCostumerName.TextChanged += new System.EventHandler(this.QuoteCostumerName_TextChanged);
            // 
            // btSubmit
            // 
            this.btSubmit.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btSubmit.ForeColor = System.Drawing.Color.Blue;
            this.btSubmit.Location = new System.Drawing.Point(31, 443);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(219, 37);
            this.btSubmit.TabIndex = 2;
            this.btSubmit.TabStop = false;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // btClose
            // 
            this.btClose.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.btClose.ForeColor = System.Drawing.Color.Red;
            this.btClose.Location = new System.Drawing.Point(341, 443);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(219, 37);
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
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(31, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(529, 74);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Size ( in. )";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(366, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 12);
            this.label4.TabIndex = 13;
            this.label4.Text = "Min: 12 Max: 48";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbWarning
            // 
            this.lbWarning.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWarning.ForeColor = System.Drawing.Color.Red;
            this.lbWarning.Location = new System.Drawing.Point(71, 56);
            this.lbWarning.Name = "lbWarning";
            this.lbWarning.Size = new System.Drawing.Size(92, 12);
            this.lbWarning.TabIndex = 12;
            this.lbWarning.Text = "Min: 24 Max: 96";
            this.lbWarning.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // QuoteDepth
            // 
            this.QuoteDepth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteDepth.Location = new System.Drawing.Point(369, 29);
            this.QuoteDepth.Name = "QuoteDepth";
            this.QuoteDepth.Size = new System.Drawing.Size(138, 26);
            this.QuoteDepth.TabIndex = 3;
            this.QuoteDepth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuoteDepth.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ValidateDepth);
            this.QuoteDepth.Validating += new System.ComponentModel.CancelEventHandler(this.ValidadeDeph2);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(306, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Depth:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // QuoteWidth
            // 
            this.QuoteWidth.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteWidth.Location = new System.Drawing.Point(74, 29);
            this.QuoteWidth.Name = "QuoteWidth";
            this.QuoteWidth.Size = new System.Drawing.Size(138, 26);
            this.QuoteWidth.TabIndex = 2;
            this.QuoteWidth.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.QuoteWidth.Validating += new System.ComponentModel.CancelEventHandler(this.ValidadeWidth);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 18);
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
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(31, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(529, 74);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuration";
            // 
            // QuoteMaterial
            // 
            this.QuoteMaterial.BackColor = System.Drawing.Color.White;
            this.QuoteMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteMaterial.FormattingEnabled = true;
            this.QuoteMaterial.Location = new System.Drawing.Point(370, 29);
            this.QuoteMaterial.Name = "QuoteMaterial";
            this.QuoteMaterial.Size = new System.Drawing.Size(137, 27);
            this.QuoteMaterial.TabIndex = 10;
            // 
            // QuoteDrawers
            // 
            this.QuoteDrawers.BackColor = System.Drawing.Color.White;
            this.QuoteDrawers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteDrawers.FormattingEnabled = true;
            this.QuoteDrawers.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.QuoteDrawers.Location = new System.Drawing.Point(180, 29);
            this.QuoteDrawers.MaxLength = 1;
            this.QuoteDrawers.Name = "QuoteDrawers";
            this.QuoteDrawers.Size = new System.Drawing.Size(43, 27);
            this.QuoteDrawers.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desktop Material:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(171, 18);
            this.label6.TabIndex = 6;
            this.label6.Text = "Number of Drawers:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.QuoteRush);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox3.Location = new System.Drawing.Point(31, 330);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(529, 74);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Shipping";
            // 
            // QuoteRush
            // 
            this.QuoteRush.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteRush.FormattingEnabled = true;
            this.QuoteRush.Location = new System.Drawing.Point(184, 30);
            this.QuoteRush.Name = "QuoteRush";
            this.QuoteRush.Size = new System.Drawing.Size(323, 27);
            this.QuoteRush.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(171, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Rush Order Options:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AddNewQuote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 521);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.QuoteCostumerName);
            this.Controls.Add(this.lbCostumerName);
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

        private System.Windows.Forms.Label lbCostumerName;
        private System.Windows.Forms.TextBox QuoteCostumerName;
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