namespace EfratShmueliProject.Mittings
{
    partial class MittingsShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MittingsShow));
            this.DGMittings = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.עדכןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGMittings)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGMittings
            // 
            this.DGMittings.BackgroundColor = System.Drawing.Color.White;
            this.DGMittings.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGMittings.Location = new System.Drawing.Point(31, 172);
            this.DGMittings.Name = "DGMittings";
            this.DGMittings.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGMittings.Size = new System.Drawing.Size(743, 191);
            this.DGMittings.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.עדכןToolStripMenuItem,
            this.מחקToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
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
            this.txtSearch.Location = new System.Drawing.Point(131, 126);
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
            this.btnFresh.Location = new System.Drawing.Point(31, 125);
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
            this.pictureBox1.Location = new System.Drawing.Point(255, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // MittingsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.DGMittings);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MittingsShow";
            this.Text = "MittingsShow";
            this.Load += new System.EventHandler(this.MittingsShow_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.DGMittings, 0);
            this.Controls.SetChildIndex(this.btnFresh, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGMittings)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGMittings;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem עדכןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}