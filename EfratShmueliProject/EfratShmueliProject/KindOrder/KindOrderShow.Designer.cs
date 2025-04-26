namespace EfratShmueliProject.KindOrder
{
    partial class KindOrderShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KindOrderShow));
            this.DGKindOrders = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.הוסףToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עדכןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGKindOrders)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGKindOrders
            // 
            this.DGKindOrders.BackgroundColor = System.Drawing.Color.White;
            this.DGKindOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGKindOrders.Location = new System.Drawing.Point(34, 158);
            this.DGKindOrders.Name = "DGKindOrders";
            this.DGKindOrders.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGKindOrders.Size = new System.Drawing.Size(458, 207);
            this.DGKindOrders.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוסףToolStripMenuItem,
            this.עדכןToolStripMenuItem,
            this.מחקToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(528, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            //this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // הוסףToolStripMenuItem
            // 
            this.הוסףToolStripMenuItem.Name = "הוסףToolStripMenuItem";
            this.הוסףToolStripMenuItem.RightToLeftAutoMirrorImage = true;
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
            this.מחקToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.מחקToolStripMenuItem.Text = "מחק";
            this.מחקToolStripMenuItem.Click += new System.EventHandler(this.מחקToolStripMenuItem_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(134, 114);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "הקש ערך לחיפוש";
            this.txtSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txtSearch_MouseClick);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.MouseLeave += new System.EventHandler(this.txtSearch_MouseLeave);
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.Gold;
            this.btnFresh.Location = new System.Drawing.Point(34, 113);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 21);
            this.btnFresh.TabIndex = 14;
            this.btnFresh.Text = "רענן";
            this.btnFresh.UseVisualStyleBackColor = false;
            this.btnFresh.Click += new System.EventHandler(this.btnFresh_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(257, 114);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // KindOrderShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 402);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.DGKindOrders);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "KindOrderShow";
            this.Text = "KindOrderShow";
            this.Load += new System.EventHandler(this.KindOrderShow_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.DGKindOrders, 0);
            this.Controls.SetChildIndex(this.btnFresh, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGKindOrders)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGKindOrders;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem הוסףToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עדכןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}