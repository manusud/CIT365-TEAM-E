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
            this.closeAllQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeAllQuotes
            // 
            this.closeAllQuotes.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.closeAllQuotes.ForeColor = System.Drawing.Color.Red;
            this.closeAllQuotes.Location = new System.Drawing.Point(113, 401);
            this.closeAllQuotes.Name = "closeAllQuotes";
            this.closeAllQuotes.Size = new System.Drawing.Size(219, 37);
            this.closeAllQuotes.TabIndex = 5;
            this.closeAllQuotes.TabStop = false;
            this.closeAllQuotes.Text = "Close";
            this.closeAllQuotes.UseVisualStyleBackColor = true;
            this.closeAllQuotes.Click += new System.EventHandler(this.button2_Click);
            // 
            // ViewAllQuotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 450);
            this.Controls.Add(this.closeAllQuotes);
            this.Name = "ViewAllQuotes";
            this.Text = "ViewAllQuotes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeAllQuotes;
    }
}