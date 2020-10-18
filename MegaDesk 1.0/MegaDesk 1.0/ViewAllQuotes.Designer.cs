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
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.material = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.width = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.depth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quotesModelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesModelBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // closeAllQuotes
            // 
            this.closeAllQuotes.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAllQuotes.ForeColor = System.Drawing.Color.Black;
            this.closeAllQuotes.Location = new System.Drawing.Point(311, 464);
            this.closeAllQuotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeAllQuotes.Name = "closeAllQuotes";
            this.closeAllQuotes.Size = new System.Drawing.Size(149, 50);
            this.closeAllQuotes.TabIndex = 5;
            this.closeAllQuotes.TabStop = false;
            this.closeAllQuotes.Text = "Close";
            this.closeAllQuotes.UseVisualStyleBackColor = true;
            this.closeAllQuotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customerName,
            this.material,
            this.width,
            this.depth,
            this.totalSize,
            this.totalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(23, 28);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(717, 409);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // customerName
            // 
            this.customerName.HeaderText = "Customer Name";
            this.customerName.MinimumWidth = 6;
            this.customerName.Name = "customerName";
            this.customerName.Width = 125;
            // 
            // material
            // 
            this.material.HeaderText = "Material";
            this.material.MinimumWidth = 6;
            this.material.Name = "material";
            this.material.Width = 125;
            // 
            // width
            // 
            this.width.HeaderText = "Width";
            this.width.MinimumWidth = 6;
            this.width.Name = "width";
            this.width.Width = 50;
            // 
            // depth
            // 
            this.depth.HeaderText = "Depth";
            this.depth.MinimumWidth = 6;
            this.depth.Name = "depth";
            this.depth.Width = 50;
            // 
            // totalSize
            // 
            this.totalSize.HeaderText = "Total Size";
            this.totalSize.MinimumWidth = 6;
            this.totalSize.Name = "totalSize";
            this.totalSize.Width = 50;
            // 
            // totalPrice
            // 
            this.totalPrice.HeaderText = "totalPrice";
            this.totalPrice.MinimumWidth = 6;
            this.totalPrice.Name = "totalPrice";
            // 
            // quotesModelBindingSource
            // 
            this.quotesModelBindingSource.DataSource = typeof(MegaDesk_CostaLuiz.QuotesModel);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(771, 553);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.closeAllQuotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quotesModelBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeAllQuotes;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource quotesModelBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn material;
        private System.Windows.Forms.DataGridViewTextBoxColumn width;
        private System.Windows.Forms.DataGridViewTextBoxColumn depth;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPrice;
    }
}