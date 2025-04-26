namespace EfratShmueliProject.KindOrder
{
    partial class KindOrderAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KindOrderAddUpdate));
            this.lblkodKindOrder = new System.Windows.Forms.Label();
            this.lblNameKindOrder = new System.Windows.Forms.Label();
            this.txtbNameKindOrder = new System.Windows.Forms.TextBox();
            this.txtbKodKindOrder = new System.Windows.Forms.TextBox();
            this.AddKindOrder = new System.Windows.Forms.Button();
            this.lblPriceKindOrder = new System.Windows.Forms.Label();
            this.txtbPriceKindOrder = new System.Windows.Forms.TextBox();
            this.ErpDescribKindOrder = new System.Windows.Forms.ErrorProvider(this.components);
            this.erpPriceKindOrder = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbltimeWorking = new System.Windows.Forms.Label();
            this.txttimeWorking = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ErpDescribKindOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPriceKindOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblkodKindOrder
            // 
            this.lblkodKindOrder.AutoSize = true;
            this.lblkodKindOrder.Location = new System.Drawing.Point(371, 98);
            this.lblkodKindOrder.Name = "lblkodKindOrder";
            this.lblkodKindOrder.Size = new System.Drawing.Size(96, 13);
            this.lblkodKindOrder.TabIndex = 14;
            this.lblkodKindOrder.Text = "קוד פריט בקטלוג";
            // 
            // lblNameKindOrder
            // 
            this.lblNameKindOrder.AutoSize = true;
            this.lblNameKindOrder.Location = new System.Drawing.Point(404, 153);
            this.lblNameKindOrder.Name = "lblNameKindOrder";
            this.lblNameKindOrder.Size = new System.Drawing.Size(33, 13);
            this.lblNameKindOrder.TabIndex = 13;
            this.lblNameKindOrder.Text = "תאור";
            // 
            // txtbNameKindOrder
            // 
            this.txtbNameKindOrder.Location = new System.Drawing.Point(176, 146);
            this.txtbNameKindOrder.Name = "txtbNameKindOrder";
            this.txtbNameKindOrder.Size = new System.Drawing.Size(213, 20);
            this.txtbNameKindOrder.TabIndex = 12;
            this.txtbNameKindOrder.TextChanged += new System.EventHandler(this.txtbNameKindOrder_TextChanged);
            // 
            // txtbKodKindOrder
            // 
            this.txtbKodKindOrder.Enabled = false;
            this.txtbKodKindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbKodKindOrder.Location = new System.Drawing.Point(328, 87);
            this.txtbKodKindOrder.Name = "txtbKodKindOrder";
            this.txtbKodKindOrder.Size = new System.Drawing.Size(41, 24);
            this.txtbKodKindOrder.TabIndex = 11;
            // 
            // AddKindOrder
            // 
            this.AddKindOrder.BackColor = System.Drawing.Color.Gold;
            this.AddKindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddKindOrder.Location = new System.Drawing.Point(60, 267);
            this.AddKindOrder.Name = "AddKindOrder";
            this.AddKindOrder.Size = new System.Drawing.Size(89, 27);
            this.AddKindOrder.TabIndex = 10;
            this.AddKindOrder.Text = "הוסף";
            this.AddKindOrder.UseVisualStyleBackColor = false;
            this.AddKindOrder.Click += new System.EventHandler(this.AddKindOrder_Click);
            // 
            // lblPriceKindOrder
            // 
            this.lblPriceKindOrder.AutoSize = true;
            this.lblPriceKindOrder.Location = new System.Drawing.Point(398, 199);
            this.lblPriceKindOrder.Name = "lblPriceKindOrder";
            this.lblPriceKindOrder.Size = new System.Drawing.Size(39, 13);
            this.lblPriceKindOrder.TabIndex = 16;
            this.lblPriceKindOrder.Text = "תעריף";
            // 
            // txtbPriceKindOrder
            // 
            this.txtbPriceKindOrder.Location = new System.Drawing.Point(281, 192);
            this.txtbPriceKindOrder.Name = "txtbPriceKindOrder";
            this.txtbPriceKindOrder.Size = new System.Drawing.Size(100, 20);
            this.txtbPriceKindOrder.TabIndex = 15;
            this.txtbPriceKindOrder.TextChanged += new System.EventHandler(this.txtbPriceKindOrder_TextChanged);
            // 
            // ErpDescribKindOrder
            // 
            this.ErpDescribKindOrder.ContainerControl = this;
            // 
            // erpPriceKindOrder
            // 
            this.erpPriceKindOrder.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(383, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 63;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(391, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "*";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(169, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 67;
            this.label3.Text = "*";
            // 
            // lbltimeWorking
            // 
            this.lbltimeWorking.AutoSize = true;
            this.lbltimeWorking.Location = new System.Drawing.Point(181, 199);
            this.lbltimeWorking.Name = "lbltimeWorking";
            this.lbltimeWorking.Size = new System.Drawing.Size(86, 13);
            this.lbltimeWorking.TabIndex = 66;
            this.lbltimeWorking.Text = "משך זמן עבודה";
            // 
            // txttimeWorking
            // 
            this.txttimeWorking.Location = new System.Drawing.Point(84, 192);
            this.txttimeWorking.Name = "txttimeWorking";
            this.txttimeWorking.Size = new System.Drawing.Size(84, 20);
            this.txttimeWorking.TabIndex = 65;
            this.txttimeWorking.TextChanged += new System.EventHandler(this.txttimeWorking_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(60, 300);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // KindOrderAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 363);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbltimeWorking);
            this.Controls.Add(this.txttimeWorking);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPriceKindOrder);
            this.Controls.Add(this.txtbPriceKindOrder);
            this.Controls.Add(this.lblkodKindOrder);
            this.Controls.Add(this.lblNameKindOrder);
            this.Controls.Add(this.txtbNameKindOrder);
            this.Controls.Add(this.txtbKodKindOrder);
            this.Controls.Add(this.AddKindOrder);
            this.Name = "KindOrderAddUpdate";
            this.Text = "KindOrderAddUpdate";
            this.Load += new System.EventHandler(this.KindOrderAddUpdate_Load);
            this.Controls.SetChildIndex(this.AddKindOrder, 0);
            this.Controls.SetChildIndex(this.txtbKodKindOrder, 0);
            this.Controls.SetChildIndex(this.txtbNameKindOrder, 0);
            this.Controls.SetChildIndex(this.lblNameKindOrder, 0);
            this.Controls.SetChildIndex(this.lblkodKindOrder, 0);
            this.Controls.SetChildIndex(this.txtbPriceKindOrder, 0);
            this.Controls.SetChildIndex(this.lblPriceKindOrder, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txttimeWorking, 0);
            this.Controls.SetChildIndex(this.lbltimeWorking, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ErpDescribKindOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.erpPriceKindOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblkodKindOrder;
        private System.Windows.Forms.Label lblNameKindOrder;
        private System.Windows.Forms.TextBox txtbNameKindOrder;
        private System.Windows.Forms.TextBox txtbKodKindOrder;
        private System.Windows.Forms.Button AddKindOrder;
        private System.Windows.Forms.Label lblPriceKindOrder;
        private System.Windows.Forms.TextBox txtbPriceKindOrder;
        private System.Windows.Forms.ErrorProvider ErpDescribKindOrder;
        private System.Windows.Forms.ErrorProvider erpPriceKindOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbltimeWorking;
        private System.Windows.Forms.TextBox txttimeWorking;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}