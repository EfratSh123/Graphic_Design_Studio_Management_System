namespace EfratShmueliProject.OrderDeitals
{
    partial class OrderDeitalsAddUpDate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTimeWorking = new System.Windows.Forms.Label();
            this.txtTimeWorking = new System.Windows.Forms.TextBox();
            this.lblkoddOrder = new System.Windows.Forms.Label();
            this.lblNameKindOrder = new System.Windows.Forms.Label();
            this.txtbNameKindOrder = new System.Windows.Forms.TextBox();
            this.txtbKodOrder = new System.Windows.Forms.TextBox();
            this.AddKindOrder = new System.Windows.Forms.Button();
            this.lblkoddKindOrder = new System.Windows.Forms.Label();
            this.txtKodKindOrder = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.rbstatusnp = new System.Windows.Forms.RadioButton();
            this.rbStatusp = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(497, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 20);
            this.label1.TabIndex = 73;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(276, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 72;
            this.label2.Text = "*";
            // 
            // lblTimeWorking
            // 
            this.lblTimeWorking.AutoSize = true;
            this.lblTimeWorking.Location = new System.Drawing.Point(290, 193);
            this.lblTimeWorking.Name = "lblTimeWorking";
            this.lblTimeWorking.Size = new System.Drawing.Size(101, 13);
            this.lblTimeWorking.TabIndex = 71;
            this.lblTimeWorking.Text = "מספר שעות עבודה";
            // 
            // txtTimeWorking
            // 
            this.txtTimeWorking.Location = new System.Drawing.Point(176, 186);
            this.txtTimeWorking.Name = "txtTimeWorking";
            this.txtTimeWorking.Size = new System.Drawing.Size(100, 20);
            this.txtTimeWorking.TabIndex = 70;
            this.txtTimeWorking.TextChanged += new System.EventHandler(this.txtTimeWorking_TextChanged);
            // 
            // lblkoddOrder
            // 
            this.lblkoddOrder.AutoSize = true;
            this.lblkoddOrder.Location = new System.Drawing.Point(474, 148);
            this.lblkoddOrder.Name = "lblkoddOrder";
            this.lblkoddOrder.Size = new System.Drawing.Size(60, 13);
            this.lblkoddOrder.TabIndex = 69;
            this.lblkoddOrder.Text = "קוד הזמנה";
            // 
            // lblNameKindOrder
            // 
            this.lblNameKindOrder.AutoSize = true;
            this.lblNameKindOrder.Location = new System.Drawing.Point(511, 193);
            this.lblNameKindOrder.Name = "lblNameKindOrder";
            this.lblNameKindOrder.Size = new System.Drawing.Size(33, 13);
            this.lblNameKindOrder.TabIndex = 68;
            this.lblNameKindOrder.Text = "תאור";
            // 
            // txtbNameKindOrder
            // 
            this.txtbNameKindOrder.Location = new System.Drawing.Point(397, 186);
            this.txtbNameKindOrder.Name = "txtbNameKindOrder";
            this.txtbNameKindOrder.Size = new System.Drawing.Size(100, 20);
            this.txtbNameKindOrder.TabIndex = 67;
            this.txtbNameKindOrder.TextChanged += new System.EventHandler(this.txtbNameKindOrder_TextChanged);
            // 
            // txtbKodOrder
            // 
            this.txtbKodOrder.Enabled = false;
            this.txtbKodOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbKodOrder.Location = new System.Drawing.Point(427, 137);
            this.txtbKodOrder.Name = "txtbKodOrder";
            this.txtbKodOrder.Size = new System.Drawing.Size(41, 24);
            this.txtbKodOrder.TabIndex = 66;
            // 
            // AddKindOrder
            // 
            this.AddKindOrder.BackColor = System.Drawing.Color.White;
            this.AddKindOrder.Location = new System.Drawing.Point(42, 286);
            this.AddKindOrder.Name = "AddKindOrder";
            this.AddKindOrder.Size = new System.Drawing.Size(75, 23);
            this.AddKindOrder.TabIndex = 65;
            this.AddKindOrder.Text = "הוסף";
            this.AddKindOrder.UseVisualStyleBackColor = false;
            this.AddKindOrder.Click += new System.EventHandler(this.AddKindOrder_Click);
            // 
            // lblkoddKindOrder
            // 
            this.lblkoddKindOrder.AutoSize = true;
            this.lblkoddKindOrder.Location = new System.Drawing.Point(317, 148);
            this.lblkoddKindOrder.Name = "lblkoddKindOrder";
            this.lblkoddKindOrder.Size = new System.Drawing.Size(96, 13);
            this.lblkoddKindOrder.TabIndex = 75;
            this.lblkoddKindOrder.Text = "קוד פריט בקטלוג";
            // 
            // txtKodKindOrder
            // 
            this.txtKodKindOrder.Enabled = false;
            this.txtKodKindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKodKindOrder.Location = new System.Drawing.Point(270, 137);
            this.txtKodKindOrder.Name = "txtKodKindOrder";
            this.txtKodKindOrder.Size = new System.Drawing.Size(41, 24);
            this.txtKodKindOrder.TabIndex = 74;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(524, 91);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(26, 13);
            this.lblKod.TabIndex = 77;
            this.lblKod.Text = "קוד";
            // 
            // txtKod
            // 
            this.txtKod.Enabled = false;
            this.txtKod.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKod.Location = new System.Drawing.Point(477, 80);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(41, 24);
            this.txtKod.TabIndex = 76;
            // 
            // rbstatusnp
            // 
            this.rbstatusnp.AutoSize = true;
            this.rbstatusnp.Location = new System.Drawing.Point(183, 246);
            this.rbstatusnp.Name = "rbstatusnp";
            this.rbstatusnp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbstatusnp.Size = new System.Drawing.Size(96, 17);
            this.rbstatusnp.TabIndex = 80;
            this.rbstatusnp.TabStop = true;
            this.rbstatusnp.Text = "בשלבי עבודה";
            this.rbstatusnp.UseVisualStyleBackColor = true;
            // 
            // rbStatusp
            // 
            this.rbStatusp.AutoSize = true;
            this.rbStatusp.Location = new System.Drawing.Point(201, 223);
            this.rbStatusp.Name = "rbStatusp";
            this.rbStatusp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStatusp.Size = new System.Drawing.Size(51, 17);
            this.rbStatusp.TabIndex = 79;
            this.rbStatusp.TabStop = true;
            this.rbStatusp.Text = "בוצע";
            this.rbStatusp.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(254, 225);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 78;
            this.lblStatus.Text = "סטטוס";
            // 
            // OrderDeitalsAddUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 335);
            this.Controls.Add(this.rbstatusnp);
            this.Controls.Add(this.rbStatusp);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblkoddKindOrder);
            this.Controls.Add(this.txtKodKindOrder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTimeWorking);
            this.Controls.Add(this.txtTimeWorking);
            this.Controls.Add(this.lblkoddOrder);
            this.Controls.Add(this.lblNameKindOrder);
            this.Controls.Add(this.txtbNameKindOrder);
            this.Controls.Add(this.txtbKodOrder);
            this.Controls.Add(this.AddKindOrder);
            this.Name = "OrderDeitalsAddUpDate";
            this.Text = "OrderDeitalsAddUpDate";
            this.Load += new System.EventHandler(this.OrderDeitalsAddUpDate_Load);
            this.Controls.SetChildIndex(this.AddKindOrder, 0);
            this.Controls.SetChildIndex(this.txtbKodOrder, 0);
            this.Controls.SetChildIndex(this.txtbNameKindOrder, 0);
            this.Controls.SetChildIndex(this.lblNameKindOrder, 0);
            this.Controls.SetChildIndex(this.lblkoddOrder, 0);
            this.Controls.SetChildIndex(this.txtTimeWorking, 0);
            this.Controls.SetChildIndex(this.lblTimeWorking, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtKodKindOrder, 0);
            this.Controls.SetChildIndex(this.lblkoddKindOrder, 0);
            this.Controls.SetChildIndex(this.txtKod, 0);
            this.Controls.SetChildIndex(this.lblKod, 0);
            this.Controls.SetChildIndex(this.lblStatus, 0);
            this.Controls.SetChildIndex(this.rbStatusp, 0);
            this.Controls.SetChildIndex(this.rbstatusnp, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTimeWorking;
        private System.Windows.Forms.TextBox txtTimeWorking;
        private System.Windows.Forms.Label lblkoddOrder;
        private System.Windows.Forms.Label lblNameKindOrder;
        private System.Windows.Forms.TextBox txtbNameKindOrder;
        private System.Windows.Forms.TextBox txtbKodOrder;
        private System.Windows.Forms.Button AddKindOrder;
        private System.Windows.Forms.Label lblkoddKindOrder;
        private System.Windows.Forms.TextBox txtKodKindOrder;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.RadioButton rbstatusnp;
        private System.Windows.Forms.RadioButton rbStatusp;
        private System.Windows.Forms.Label lblStatus;
    }
}