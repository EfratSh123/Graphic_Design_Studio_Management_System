namespace EfratShmueliProject.Cities
{
    partial class CitiesShow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitiesShow));
            this.DGCities = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.הוסףToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.עדכוןToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.מחקToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnFresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGCities)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // DGCities
            // 
            this.DGCities.BackgroundColor = System.Drawing.Color.White;
            this.DGCities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGCities.Location = new System.Drawing.Point(68, 165);
            this.DGCities.Name = "DGCities";
            this.DGCities.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DGCities.Size = new System.Drawing.Size(258, 192);
            this.DGCities.TabIndex = 0;
            this.DGCities.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGCities_CellContentClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.הוסףToolStripMenuItem,
            this.עדכוןToolStripMenuItem,
            this.מחקToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 49);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // הוסףToolStripMenuItem
            // 
            this.הוסףToolStripMenuItem.Name = "הוסףToolStripMenuItem";
            this.הוסףToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.הוסףToolStripMenuItem.Text = "הוסף";
            this.הוסףToolStripMenuItem.Click += new System.EventHandler(this.הוסףToolStripMenuItem_Click);
            // 
            // עדכוןToolStripMenuItem
            // 
            this.עדכוןToolStripMenuItem.Name = "עדכוןToolStripMenuItem";
            this.עדכוןToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.עדכוןToolStripMenuItem.Text = "עדכן";
            this.עדכוןToolStripMenuItem.Click += new System.EventHandler(this.עדכוןToolStripMenuItem_Click);
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
            this.txtSearch.Location = new System.Drawing.Point(168, 126);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(100, 20);
            this.txtSearch.TabIndex = 15;
            this.txtSearch.Text = "הקש ערך לחיפוש";
            // 
            // btnFresh
            // 
            this.btnFresh.BackColor = System.Drawing.Color.Gold;
            this.btnFresh.Location = new System.Drawing.Point(68, 125);
            this.btnFresh.Name = "btnFresh";
            this.btnFresh.Size = new System.Drawing.Size(75, 21);
            this.btnFresh.TabIndex = 14;
            this.btnFresh.Text = "רענן";
            this.btnFresh.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 126);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 82;
            this.pictureBox1.TabStop = false;
            // 
            // CitiesShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 389);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnFresh);
            this.Controls.Add(this.DGCities);
            this.Controls.Add(this.menuStrip1);
            this.Name = "CitiesShow";
            this.Text = "CitiesShow";
            this.Load += new System.EventHandler(this.CitiesShow_Load);
            this.Controls.SetChildIndex(this.menuStrip1, 0);
            this.Controls.SetChildIndex(this.DGCities, 0);
            this.Controls.SetChildIndex(this.btnFresh, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.DGCities)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGCities;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem הוסףToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem עדכוןToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem מחקToolStripMenuItem;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnFresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}