namespace MegaDesk_CostaLuiz
{
    partial class ViewAllQuotes
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.closeAllQuotes = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.quotesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quotesModelBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesModelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesModelBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAllQuotes
            // 
            this.closeAllQuotes.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAllQuotes.ForeColor = System.Drawing.Color.Black;
            this.closeAllQuotes.Location = new System.Drawing.Point(233, 377);
            this.closeAllQuotes.Name = "closeAllQuotes";
            this.closeAllQuotes.Size = new System.Drawing.Size(112, 41);
            this.closeAllQuotes.TabIndex = 5;
            this.closeAllQuotes.TabStop = false;
            this.closeAllQuotes.Text = "Close";
            this.closeAllQuotes.UseVisualStyleBackColor = true;
            this.closeAllQuotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.quotesModelBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(190, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 6;
            // 
            // quotesModelBindingSource
            // 
            this.quotesModelBindingSource.DataSource = typeof(MegaDesk_CostaLuiz.QuotesModel);
            // 
            // quotesModelBindingSource1
            // 
            this.quotesModelBindingSource1.DataSource = typeof(MegaDesk_CostaLuiz.QuotesModel);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(578, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeAllQuotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesModelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesModelBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeAllQuotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource quotesModelBindingSource1;
        private System.Windows.Forms.BindingSource quotesModelBindingSource;
    }
}