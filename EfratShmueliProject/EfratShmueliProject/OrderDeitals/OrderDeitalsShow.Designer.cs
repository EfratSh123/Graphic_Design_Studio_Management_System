namespace EfratShmueliProject.OrderDeitals
{
    partial class OrderDeitalsShow
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
            this.DGOrderDeitals = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGOrderDeitals)).BeginInit();
            this.SuspendLayout();
            // 
            // DGOrderDeitals
            // 
            this.DGOrderDeitals.BackgroundColor = System.Drawing.Color.White;
            this.DGOrderDeitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGOrderDeitals.Location = new System.Drawing.Point(36, 127);
            this.DGOrderDeitals.Name = "DGOrderDeitals";
            this.DGOrderDeitals.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGOrderDeitals.Size = new System.Drawing.Size(393, 207);
            this.DGOrderDeitals.TabIndex = 2;
            // 
            // OrderDeitalsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 367);
            this.Controls.Add(this.DGOrderDeitals);
            this.Name = "OrderDeitalsShow";
            this.Text = "OrderDeitalsShow";
            this.Load += new System.EventHandler(this.OrderDeitalsShow_Load);
            this.Controls.SetChildIndex(this.DGOrderDeitals, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGOrderDeitals)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGOrderDeitals;
    }
}