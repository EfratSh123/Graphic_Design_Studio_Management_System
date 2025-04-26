namespace EfratShmueliProject.Orders
{
    partial class OrdersShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersShow));
            this.DGOrders = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.הצגתפרטיהזמנהToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.הוסףToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עדכןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGOrders)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGOrders
            // 
            this.DGOrders.BackgroundColor = System.Drawing.Color.White;
            this.DGOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGOrders.Location = new System.Drawing.Point(32, 146);
            this.DGOrders.Name = "DGOrders";
            this.DGOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGOrders.Size = new System.Drawing.Size(734, 226);
            this.DGOrders.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הצגתפרטיהזמנהToolStripMenuItem,
            this.הוסףToolStripMenuItem,
            this.עדכןToolStripMenuItem,
            this.מחקToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // הצגתפרטיהזמנהToolStripMenuItem
            // 
            this.הצגתפרטיהזמנהToolStripMenuItem.Name = "הצגתפרטיהזמנהToolStripMenuItem";
            this.הצגתפרטיהזמנהToolStripMenuItem.Size = new System.Drawing.Size(113, 20);
            this.הצגתפרטיהזמנהToolStripMenuItem.Text = "הצגת פרטי הזמנה";
            this.הצגתפרטיהזמנהToolStripMenuItem.Click += new System.EventHandler(this.הצגתפרטיהזמנהToolStripMenuItem_Click);
            // 
            // הוסףToolStripMenuItem
            // 
            this.הוסףToolStripMenuItem.Name = "הוסףToolStripMenuItem";
            this.הוסףToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.הוסףToolStripMenuItem.Text = "הוסף";
            this.הוסףToolStripMenuItem.Click += new System.EventHandler(this.הוסףToolStripMenuItem_Click);
            // 
            // עדכןToolStripMenuItem
            // 
            this.עדכןToolStripMenuItem.Name = "עדכןToolStripMenuItem";
            this.עדכןToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.עדכןToolStripMenuItem.Text = "עדכן";
            this.עדכןToolStripMenuItem.Click += new System.EventHandler(this.עדכןToolStripMenuItem_Click);
            // 
            // מחקToolStripMenuItem
            // 
            this.מחקToolStripMenuItem.Name = "מחקToolStripMenuItem";
            this.מחקToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.מחקToolStripMenuItem.Text = "בטל הזמנה";
            this.מחקToolStripMenuItem.Click += new System.EventHandler(this.בטל_הזמנהToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(132, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 9;
            this.txtSearch.Text = "הקש ערך לחיפוש";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.Gold;
            this.btnFresh.Location = new System.Drawing.Point(32, 101);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 21);
            this.btnFresh.TabIndex = 8;
            this.btnFresh.Text = "רענן";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(262, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // OrdersShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 408);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.DGOrders);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "OrdersShow";
            this.Text = "OrdersShow";
            this.Load += new System.EventHandler(this.OrdersShow_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.DGOrders, 0);
            this.Controls.SetChildIndex(this.btnFresh, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGOrders)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem הוסףToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עדכןToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem הצגתפרטיהזמנהToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}