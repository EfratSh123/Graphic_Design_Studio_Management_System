namespace EfratShmueliProject.Payments
{
    partial class PaymentsAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentsAddUpdate));
            this.lblKindPayment = new System.Windows.Forms.Label();
            this.rbBankTransfer = new System.Windows.Forms.RadioButton();
            this.rbCreditCard = new System.Windows.Forms.RadioButton();
            this.lblKodPayment = new System.Windows.Forms.Label();
            this.txtbKodPayment = new System.Windows.Forms.TextBox();
            this.lblNumPayments = new System.Windows.Forms.Label();
            this.cmbNumPayments = new System.Windows.Forms.ComboBox();
            this.lblNumCreditCard = new System.Windows.Forms.Label();
            this.txtbNumCreditCard = new System.Windows.Forms.TextBox();
            this.lblvalidity = new System.Windows.Forms.Label();
            this.txtbCVC = new System.Windows.Forms.TextBox();
            this.lblCVC = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtAsmachta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.rbStatusPaymentNo = new System.Windows.Forms.RadioButton();
            this.rbStatusPaymentYes = new System.Windows.Forms.RadioButton();
            this.lblStatusPayment = new System.Windows.Forms.Label();
            this.AddPayment = new System.Windows.Forms.Button();
            this.lblKodOrder = new System.Windows.Forms.Label();
            this.txtKodOrder = new System.Windows.Forms.TextBox();
            this.errorProviderNumCredetCard = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMonth = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderYear = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderCVC = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFileAttached = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKodPayment = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKodOrder = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderValidity = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumCredetCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCVC)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileAttached)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKodPayment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKodOrder)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblKindPayment
            // 
            this.lblKindPayment.AutoSize = true;
            this.lblKindPayment.Location = new System.Drawing.Point(489, 132);
            this.lblKindPayment.Name = "lblKindPayment";
            this.lblKindPayment.Size = new System.Drawing.Size(66, 13);
            this.lblKindPayment.TabIndex = 0;
            this.lblKindPayment.Text = ":סוג תשלום";
            // 
            // rbBankTransfer
            // 
            this.rbBankTransfer.AutoSize = true;
            this.rbBankTransfer.Location = new System.Drawing.Point(377, 130);
            this.rbBankTransfer.Name = "rbBankTransfer";
            this.rbBankTransfer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbBankTransfer.Size = new System.Drawing.Size(101, 17);
            this.rbBankTransfer.TabIndex = 1;
            this.rbBankTransfer.Text = "העברה בנקאית";
            this.rbBankTransfer.UseVisualStyleBackColor = true;
            this.rbBankTransfer.CheckedChanged += new System.EventHandler(this.rbBankTransfer_CheckedChanged);
            // 
            // rbCreditCard
            // 
            this.rbCreditCard.AutoSize = true;
            this.rbCreditCard.Location = new System.Drawing.Point(265, 130);
            this.rbCreditCard.Name = "rbCreditCard";
            this.rbCreditCard.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbCreditCard.Size = new System.Drawing.Size(106, 17);
            this.rbCreditCard.TabIndex = 2;
            this.rbCreditCard.Text = "תשלום באשראי";
            this.rbCreditCard.UseVisualStyleBackColor = true;
            this.rbCreditCard.CheckedChanged += new System.EventHandler(this.rbCreditCard_CheckedChanged);
            // 
            // lblKodPayment
            // 
            this.lblKodPayment.AutoSize = true;
            this.lblKodPayment.Location = new System.Drawing.Point(755, 132);
            this.lblKodPayment.Name = "lblKodPayment";
            this.lblKodPayment.Size = new System.Drawing.Size(64, 13);
            this.lblKodPayment.TabIndex = 16;
            this.lblKodPayment.Text = "קוד תשלום";
            // 
            // txtbKodPayment
            // 
            this.txtbKodPayment.Enabled = false;
            this.txtbKodPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbKodPayment.Location = new System.Drawing.Point(712, 121);
            this.txtbKodPayment.Name = "txtbKodPayment";
            this.txtbKodPayment.Size = new System.Drawing.Size(41, 24);
            this.txtbKodPayment.TabIndex = 15;
            // 
            // lblNumPayments
            // 
            this.lblNumPayments.AutoSize = true;
            this.lblNumPayments.Location = new System.Drawing.Point(372, 302);
            this.lblNumPayments.Name = "lblNumPayments";
            this.lblNumPayments.Size = new System.Drawing.Size(84, 13);
            this.lblNumPayments.TabIndex = 17;
            this.lblNumPayments.Text = "מספר תשלומים";
            // 
            // cmbNumPayments
            // 
            this.cmbNumPayments.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNumPayments.FormattingEnabled = true;
            this.cmbNumPayments.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbNumPayments.Location = new System.Drawing.Point(310, 294);
            this.cmbNumPayments.Name = "cmbNumPayments";
            this.cmbNumPayments.Size = new System.Drawing.Size(56, 21);
            this.cmbNumPayments.TabIndex = 18;
            // 
            // lblNumCreditCard
            // 
            this.lblNumCreditCard.AutoSize = true;
            this.lblNumCreditCard.Location = new System.Drawing.Point(623, 38);
            this.lblNumCreditCard.Name = "lblNumCreditCard";
            this.lblNumCreditCard.Size = new System.Drawing.Size(108, 13);
            this.lblNumCreditCard.TabIndex = 19;
            this.lblNumCreditCard.Text = "מספר כרטיס אשראי";
            // 
            // txtbNumCreditCard
            // 
            this.txtbNumCreditCard.Location = new System.Drawing.Point(400, 31);
            this.txtbNumCreditCard.Name = "txtbNumCreditCard";
            this.txtbNumCreditCard.Size = new System.Drawing.Size(209, 20);
            this.txtbNumCreditCard.TabIndex = 20;
            this.txtbNumCreditCard.TextChanged += new System.EventHandler(this.txtbNumCreditCard_TextChanged);
            // 
            // lblvalidity
            // 
            this.lblvalidity.AutoSize = true;
            this.lblvalidity.Location = new System.Drawing.Point(350, 35);
            this.lblvalidity.Name = "lblvalidity";
            this.lblvalidity.Size = new System.Drawing.Size(33, 13);
            this.lblvalidity.TabIndex = 21;
            this.lblvalidity.Text = "תוקף";
            // 
            // txtbCVC
            // 
            this.txtbCVC.Location = new System.Drawing.Point(13, 31);
            this.txtbCVC.Name = "txtbCVC";
            this.txtbCVC.Size = new System.Drawing.Size(56, 20);
            this.txtbCVC.TabIndex = 24;
            this.txtbCVC.TextChanged += new System.EventHandler(this.txtbCVC_TextChanged);
            // 
            // lblCVC
            // 
            this.lblCVC.AutoSize = true;
            this.lblCVC.Location = new System.Drawing.Point(87, 38);
            this.lblCVC.Name = "lblCVC";
            this.lblCVC.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblCVC.Size = new System.Drawing.Size(113, 13);
            this.lblCVC.TabIndex = 23;
            this.lblCVC.Text = "3 ספרות בגב הכרטיס";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbMonth);
            this.groupBox1.Controls.Add(this.cmbYear);
            this.groupBox1.Controls.Add(this.txtbCVC);
            this.groupBox1.Controls.Add(this.lblNumCreditCard);
            this.groupBox1.Controls.Add(this.lblCVC);
            this.groupBox1.Controls.Add(this.txtbNumCreditCard);
            this.groupBox1.Controls.Add(this.lblvalidity);
            this.groupBox1.Location = new System.Drawing.Point(73, 182);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(743, 78);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי כרטיס אשראי";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(71, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 69;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(335, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 68;
            this.label2.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(611, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 67;
            this.label4.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(259, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "/";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cmbMonth.Location = new System.Drawing.Point(210, 31);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(43, 21);
            this.cmbMonth.TabIndex = 26;
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030",
            "2031",
            "2032",
            "2033"});
            this.cmbYear.Location = new System.Drawing.Point(277, 31);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(56, 21);
            this.cmbYear.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAsmachta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(292, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 78);
            this.groupBox2.TabIndex = 71;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "אסמכתא להעברה בנקאית";
            // 
            // txtAsmachta
            // 
            this.txtAsmachta.Location = new System.Drawing.Point(20, 32);
            this.txtAsmachta.Name = "txtAsmachta";
            this.txtAsmachta.Size = new System.Drawing.Size(109, 20);
            this.txtAsmachta.TabIndex = 70;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(135, 35);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "מספר אסמכתא";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(220, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 70;
            this.label5.Text = "*";
            // 
            // rbStatusPaymentNo
            // 
            this.rbStatusPaymentNo.AutoSize = true;
            this.rbStatusPaymentNo.Location = new System.Drawing.Point(292, 368);
            this.rbStatusPaymentNo.Name = "rbStatusPaymentNo";
            this.rbStatusPaymentNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStatusPaymentNo.Size = new System.Drawing.Size(71, 17);
            this.rbStatusPaymentNo.TabIndex = 31;
            this.rbStatusPaymentNo.Text = "לא שולם";
            this.rbStatusPaymentNo.UseVisualStyleBackColor = true;
            // 
            // rbStatusPaymentYes
            // 
            this.rbStatusPaymentYes.AutoSize = true;
            this.rbStatusPaymentYes.Location = new System.Drawing.Point(310, 343);
            this.rbStatusPaymentYes.Name = "rbStatusPaymentYes";
            this.rbStatusPaymentYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStatusPaymentYes.Size = new System.Drawing.Size(53, 17);
            this.rbStatusPaymentYes.TabIndex = 30;
            this.rbStatusPaymentYes.Text = "שולם";
            this.rbStatusPaymentYes.UseVisualStyleBackColor = true;
            // 
            // lblStatusPayment
            // 
            this.lblStatusPayment.AutoSize = true;
            this.lblStatusPayment.Location = new System.Drawing.Point(378, 346);
            this.lblStatusPayment.Name = "lblStatusPayment";
            this.lblStatusPayment.Size = new System.Drawing.Size(78, 13);
            this.lblStatusPayment.TabIndex = 29;
            this.lblStatusPayment.Text = "סטטוס תשלום";
            // 
            // AddPayment
            // 
            this.AddPayment.BackColor = System.Drawing.Color.Gold;
            this.AddPayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddPayment.Location = new System.Drawing.Point(61, 386);
            this.AddPayment.Name = "AddPayment";
            this.AddPayment.Size = new System.Drawing.Size(89, 38);
            this.AddPayment.TabIndex = 32;
            this.AddPayment.Text = "הוסף";
            this.AddPayment.UseVisualStyleBackColor = false;
            this.AddPayment.Click += new System.EventHandler(this.AddPayment_Click);
            // 
            // lblKodOrder
            // 
            this.lblKodOrder.AutoSize = true;
            this.lblKodOrder.Location = new System.Drawing.Point(759, 98);
            this.lblKodOrder.Name = "lblKodOrder";
            this.lblKodOrder.Size = new System.Drawing.Size(60, 13);
            this.lblKodOrder.TabIndex = 33;
            this.lblKodOrder.Text = "קוד הזמנה";
            // 
            // txtKodOrder
            // 
            this.txtKodOrder.Enabled = false;
            this.txtKodOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKodOrder.Location = new System.Drawing.Point(712, 91);
            this.txtKodOrder.Name = "txtKodOrder";
            this.txtKodOrder.Size = new System.Drawing.Size(41, 24);
            this.txtKodOrder.TabIndex = 34;
            // 
            // errorProviderNumCredetCard
            // 
            this.errorProviderNumCredetCard.ContainerControl = this;
            // 
            // errorProviderMonth
            // 
            this.errorProviderMonth.ContainerControl = this;
            // 
            // errorProviderYear
            // 
            this.errorProviderYear.ContainerControl = this;
            // 
            // errorProviderCVC
            // 
            this.errorProviderCVC.ContainerControl = this;
            // 
            // errorProviderFileAttached
            // 
            this.errorProviderFileAttached.ContainerControl = this;
            // 
            // errorProviderKodPayment
            // 
            this.errorProviderKodPayment.ContainerControl = this;
            // 
            // errorProviderKodOrder
            // 
            this.errorProviderKodOrder.ContainerControl = this;
            // 
            // errorProviderValidity
            // 
            this.errorProviderValidity.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 430);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // PaymentsAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 497);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtKodOrder);
            this.Controls.Add(this.lblKodOrder);
            this.Controls.Add(this.AddPayment);
            this.Controls.Add(this.rbStatusPaymentNo);
            this.Controls.Add(this.rbStatusPaymentYes);
            this.Controls.Add(this.lblStatusPayment);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbNumPayments);
            this.Controls.Add(this.lblNumPayments);
            this.Controls.Add(this.lblKodPayment);
            this.Controls.Add(this.txtbKodPayment);
            this.Controls.Add(this.rbCreditCard);
            this.Controls.Add(this.rbBankTransfer);
            this.Controls.Add(this.lblKindPayment);
            this.Name = "PaymentsAddUpdate";
            this.Text = "PaymentsAddUpdate";
            this.Load += new System.EventHandler(this.PaymentsAddUpdate_Load);
            this.Controls.SetChildIndex(this.lblKindPayment, 0);
            this.Controls.SetChildIndex(this.rbBankTransfer, 0);
            this.Controls.SetChildIndex(this.rbCreditCard, 0);
            this.Controls.SetChildIndex(this.txtbKodPayment, 0);
            this.Controls.SetChildIndex(this.lblKodPayment, 0);
            this.Controls.SetChildIndex(this.lblNumPayments, 0);
            this.Controls.SetChildIndex(this.cmbNumPayments, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.lblStatusPayment, 0);
            this.Controls.SetChildIndex(this.rbStatusPaymentYes, 0);
            this.Controls.SetChildIndex(this.rbStatusPaymentNo, 0);
            this.Controls.SetChildIndex(this.AddPayment, 0);
            this.Controls.SetChildIndex(this.lblKodOrder, 0);
            this.Controls.SetChildIndex(this.txtKodOrder, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderNumCredetCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderCVC)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFileAttached)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKodPayment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKodOrder)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderValidity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblKindPayment;
        private System.Windows.Forms.RadioButton rbBankTransfer;
        private System.Windows.Forms.RadioButton rbCreditCard;
        private System.Windows.Forms.Label lblKodPayment;
        private System.Windows.Forms.TextBox txtbKodPayment;
        private System.Windows.Forms.Label lblNumPayments;
        private System.Windows.Forms.ComboBox cmbNumPayments;
        private System.Windows.Forms.Label lblNumCreditCard;
        private System.Windows.Forms.TextBox txtbNumCreditCard;
        private System.Windows.Forms.Label lblvalidity;
        private System.Windows.Forms.TextBox txtbCVC;
        private System.Windows.Forms.Label lblCVC;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbStatusPaymentNo;
        private System.Windows.Forms.RadioButton rbStatusPaymentYes;
        private System.Windows.Forms.Label lblStatusPayment;
        private System.Windows.Forms.Button AddPayment;
        private System.Windows.Forms.Label lblKodOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProviderNumCredetCard;
        private System.Windows.Forms.ErrorProvider errorProviderMonth;
        private System.Windows.Forms.ErrorProvider errorProviderYear;
        private System.Windows.Forms.ErrorProvider errorProviderCVC;
        private System.Windows.Forms.ErrorProvider errorProviderFileAttached;
        private System.Windows.Forms.ErrorProvider errorProviderKodPayment;
        private System.Windows.Forms.ErrorProvider errorProviderKodOrder;
        private System.Windows.Forms.ErrorProvider errorProviderValidity;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox txtKodOrder;
        private System.Windows.Forms.TextBox txtAsmachta;
        private System.Windows.Forms.Label label6;
    }
}