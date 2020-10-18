namespace MegaDesk_CostaLuiz
{
    partial class SearchQuotes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchQuotes));
            this.button2 = new System.Windows.Forms.Button();
            this.listQuoteByMaterial = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.viewAllQuotesMessage = new System.Windows.Forms.Label();
            this.QuoteMaterial = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(18, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 41);
            this.button2.TabIndex = 4;
            this.button2.TabStop = false;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listQuoteByMaterial
            // 
            this.listQuoteByMaterial.AllowColumnReorder = true;
            this.listQuoteByMaterial.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listQuoteByMaterial.FullRowSelect = true;
            this.listQuoteByMaterial.GridLines = true;
            this.listQuoteByMaterial.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listQuoteByMaterial.HideSelection = false;
            this.listQuoteByMaterial.Location = new System.Drawing.Point(21, 121);
            this.listQuoteByMaterial.MultiSelect = false;
            this.listQuoteByMaterial.Name = "listQuoteByMaterial";
            this.listQuoteByMaterial.Size = new System.Drawing.Size(560, 214);
            this.listQuoteByMaterial.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listQuoteByMaterial.TabIndex = 16;
            this.listQuoteByMaterial.UseCompatibleStateImageBehavior = false;
            this.listQuoteByMaterial.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Costumer Name";
            this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Quote Date";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 91;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Width";
            this.columnHeader3.Width = 49;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Deph";
            this.columnHeader4.Width = 51;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Total Size";
            this.columnHeader5.Width = 70;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Final Price";
            this.columnHeader6.Width = 73;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.viewAllQuotesMessage);
            this.groupBox2.Controls.Add(this.QuoteMaterial);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Firebrick;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(21, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 74);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // viewAllQuotesMessage
            // 
            this.viewAllQuotesMessage.Font = new System.Drawing.Font("Bahnschrift Condensed", 10F, System.Drawing.FontStyle.Bold);
            this.viewAllQuotesMessage.Location = new System.Drawing.Point(318, 18);
            this.viewAllQuotesMessage.Name = "viewAllQuotesMessage";
            this.viewAllQuotesMessage.Size = new System.Drawing.Size(219, 45);
            this.viewAllQuotesMessage.TabIndex = 11;
            this.viewAllQuotesMessage.Text = "View Quotes by selecting material type";
            this.viewAllQuotesMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // QuoteMaterial
            // 
            this.QuoteMaterial.BackColor = System.Drawing.Color.White;
            this.QuoteMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.QuoteMaterial.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuoteMaterial.FormattingEnabled = true;
            this.QuoteMaterial.Location = new System.Drawing.Point(165, 30);
            this.QuoteMaterial.Name = "QuoteMaterial";
            this.QuoteMaterial.Size = new System.Drawing.Size(137, 27);
            this.QuoteMaterial.TabIndex = 10;
            this.QuoteMaterial.SelectedIndexChanged += new System.EventHandler(this.ChangeDeskTopMaterial);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(17, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Desktop Material:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(606, 449);
            this.Controls.Add(this.listQuoteByMaterial);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchQuotes";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchQuotes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.closeForm);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView listQuoteByMaterial;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label viewAllQuotesMessage;
        private System.Windows.Forms.ComboBox QuoteMaterial;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
    }
}