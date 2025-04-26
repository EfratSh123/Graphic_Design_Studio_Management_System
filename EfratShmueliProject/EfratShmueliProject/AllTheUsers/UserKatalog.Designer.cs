namespace EfratShmueliProject.AllTheUsers
{
    partial class UserKatalog
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblKodCatalog = new System.Windows.Forms.Label();
            this.btnPicture = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtbTimeWorking = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(183, 11);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(35, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "label3";
            // 
            // lblKodCatalog
            // 
            this.lblKodCatalog.AutoSize = true;
            this.lblKodCatalog.Location = new System.Drawing.Point(514, 11);
            this.lblKodCatalog.Name = "lblKodCatalog";
            this.lblKodCatalog.Size = new System.Drawing.Size(35, 13);
            this.lblKodCatalog.TabIndex = 5;
            this.lblKodCatalog.Text = "label1";
            // 
            // btnPicture
            // 
            this.btnPicture.Location = new System.Drawing.Point(50, 3);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(120, 23);
            this.btnPicture.TabIndex = 4;
            this.btnPicture.Text = "לחץ להצגת תמונה";
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(576, 9);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(307, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(197, 20);
            this.textBox1.TabIndex = 10;
            // 
            // txtbTimeWorking
            // 
            this.txtbTimeWorking.Enabled = false;
            this.txtbTimeWorking.Location = new System.Drawing.Point(234, 5);
            this.txtbTimeWorking.Name = "txtbTimeWorking";
            this.txtbTimeWorking.Size = new System.Drawing.Size(56, 20);
            this.txtbTimeWorking.TabIndex = 12;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(20, 8);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 13;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // UserKatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.txtbTimeWorking);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblKodCatalog);
            this.Controls.Add(this.btnPicture);
            this.Name = "UserKatalog";
            this.Size = new System.Drawing.Size(602, 29);
            this.Load += new System.EventHandler(this.UserKatalog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblPrice;
        public System.Windows.Forms.Label lblKodCatalog;
        public System.Windows.Forms.Button btnPicture;
        public System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.TextBox textBox1;
        public System.Windows.Forms.TextBox txtbTimeWorking;
        public System.Windows.Forms.CheckBox checkBox2;
    }
}
