namespace EfratShmueliProject.Cities
{
    partial class CitiesAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CitiesAddUpdate));
            this.lblkodCity = new System.Windows.Forms.Label();
            this.lblnameCity = new System.Windows.Forms.Label();
            this.txtbNameCity = new System.Windows.Forms.TextBox();
            this.txtbkodCity = new System.Windows.Forms.TextBox();
            this.AddCitiy = new System.Windows.Forms.Button();
            this.ErpNameCity = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErpNameCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkodCity
            // 
            this.lblkodCity.AutoSize = true;
            this.lblkodCity.Location = new System.Drawing.Point(310, 89);
            this.lblkodCity.Name = "lblkodCity";
            this.lblkodCity.Size = new System.Drawing.Size(47, 13);
            this.lblkodCity.TabIndex = 9;
            this.lblkodCity.Text = "קוד עיר";
            // 
            // lblnameCity
            // 
            this.lblnameCity.AutoSize = true;
            this.lblnameCity.Location = new System.Drawing.Point(208, 89);
            this.lblnameCity.Name = "lblnameCity";
            this.lblnameCity.Size = new System.Drawing.Size(44, 13);
            this.lblnameCity.TabIndex = 8;
            this.lblnameCity.Text = "שם עיר";
            // 
            // txtbNameCity
            // 
            this.txtbNameCity.Location = new System.Drawing.Point(91, 82);
            this.txtbNameCity.Name = "txtbNameCity";
            this.txtbNameCity.Size = new System.Drawing.Size(100, 20);
            this.txtbNameCity.TabIndex = 7;
            this.txtbNameCity.TextChanged += new System.EventHandler(this.txtbNameCity_TextChanged);
            // 
            // txtbkodCity
            // 
            this.txtbkodCity.Enabled = false;
            this.txtbkodCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbkodCity.Location = new System.Drawing.Point(263, 78);
            this.txtbkodCity.Name = "txtbkodCity";
            this.txtbkodCity.Size = new System.Drawing.Size(41, 24);
            this.txtbkodCity.TabIndex = 6;
            this.txtbkodCity.TextChanged += new System.EventHandler(this.txtkodCity_TextChanged);
            // 
            // AddCitiy
            // 
            this.AddCitiy.BackColor = System.Drawing.Color.Gold;
            this.AddCitiy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddCitiy.Location = new System.Drawing.Point(60, 130);
            this.AddCitiy.Name = "AddCitiy";
            this.AddCitiy.Size = new System.Drawing.Size(89, 27);
            this.AddCitiy.TabIndex = 5;
            this.AddCitiy.Text = "הוסף";
            this.AddCitiy.UseVisualStyleBackColor = false;
            this.AddCitiy.Click += new System.EventHandler(this.AddCitiy_Click);
            // 
            // ErpNameCity
            // 
            this.ErpNameCity.BlinkRate = 180;
            this.ErpNameCity.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(191, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // CitiesAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 208);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblkodCity);
            this.Controls.Add(this.lblnameCity);
            this.Controls.Add(this.txtbNameCity);
            this.Controls.Add(this.txtbkodCity);
            this.Controls.Add(this.AddCitiy);
            this.Name = "CitiesAddUpdate";
            this.Text = "CitiesAddUpdate";
            this.Load += new System.EventHandler(this.CitiesAddUpdate_Load);
            this.Controls.SetChildIndex(this.AddCitiy, 0);
            this.Controls.SetChildIndex(this.txtbkodCity, 0);
            this.Controls.SetChildIndex(this.txtbNameCity, 0);
            this.Controls.SetChildIndex(this.lblnameCity, 0);
            this.Controls.SetChildIndex(this.lblkodCity, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErpNameCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkodCity;
        private System.Windows.Forms.Label lblnameCity;
        private System.Windows.Forms.TextBox txtbNameCity;
        private System.Windows.Forms.TextBox txtbkodCity;
        private System.Windows.Forms.Button AddCitiy;
        private System.Windows.Forms.ErrorProvider ErpNameCity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}