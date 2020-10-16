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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewAllQuotes));
            this.closeAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeAllQuotes
            // 
            this.closeAllQuotes.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeAllQuotes.ForeColor = System.Drawing.Color.Black;
            this.closeAllQuotes.Location = new System.Drawing.Point(31, 476);
            this.closeAllQuotes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.closeAllQuotes.Name = "closeAllQuotes";
            this.closeAllQuotes.Size = new System.Drawing.Size(150, 50);
            this.closeAllQuotes.TabIndex = 5;
            this.closeAllQuotes.TabStop = false;
            this.closeAllQuotes.Text = "Close";
            this.closeAllQuotes.UseVisualStyleBackColor = true;
            this.closeAllQuotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(582, 553);
            this.Controls.Add(this.closeAllQuotes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeAllQuotes;
    }
}