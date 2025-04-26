namespace EfratShmueliProject.Mittings
{
    partial class MittingsAddUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MittingsAddUpdate));
            this.LBLkodMitting = new System.Windows.Forms.Label();
            this.lbldateMitting = new System.Windows.Forms.Label();
            this.txtbkodMitting = new System.Windows.Forms.TextBox();
            this.btnAddMitting = new System.Windows.Forms.Button();
            this.dateTimePickerMitting = new System.Windows.Forms.DateTimePicker();
            this.lblHourMitting = new System.Windows.Forms.Label();
            this.txtbClientPhone = new System.Windows.Forms.TextBox();
            this.lblClientPhone = new System.Windows.Forms.Label();
            this.txtbClientName = new System.Windows.Forms.TextBox();
            this.lblClientLastName = new System.Windows.Forms.Label();
            this.lblStatusMitting = new System.Windows.Forms.Label();
            this.rbStatusMittingYes = new System.Windows.Forms.RadioButton();
            this.rbStatusMittingNo = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbHour = new System.Windows.Forms.ComboBox();
            this.cmbMoment = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbID = new System.Windows.Forms.ComboBox();
            this.lblClientID = new System.Windows.Forms.Label();
            this.errorProviderHour = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderStatus = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDate = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderId = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LBLkodMitting
            // 
            this.LBLkodMitting.AutoSize = true;
            this.LBLkodMitting.Location = new System.Drawing.Point(651, 95);
            this.LBLkodMitting.Name = "LBLkodMitting";
            this.LBLkodMitting.Size = new System.Drawing.Size(63, 13);
            this.LBLkodMitting.TabIndex = 14;
            this.LBLkodMitting.Text = "קוד פגישה";
            // 
            // lbldateMitting
            // 
            this.lbldateMitting.AutoSize = true;
            this.lbldateMitting.Location = new System.Drawing.Point(306, 24);
            this.lbldateMitting.Name = "lbldateMitting";
            this.lbldateMitting.Size = new System.Drawing.Size(40, 13);
            this.lbldateMitting.TabIndex = 13;
            this.lbldateMitting.Text = "תאריך";
            // 
            // txtbkodMitting
            // 
            this.txtbkodMitting.Enabled = false;
            this.txtbkodMitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtbkodMitting.Location = new System.Drawing.Point(606, 87);
            this.txtbkodMitting.Name = "txtbkodMitting";
            this.txtbkodMitting.Size = new System.Drawing.Size(41, 24);
            this.txtbkodMitting.TabIndex = 11;
            // 
            // btnAddMitting
            // 
            this.btnAddMitting.BackColor = System.Drawing.Color.Gold;
            this.btnAddMitting.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddMitting.Location = new System.Drawing.Point(61, 333);
            this.btnAddMitting.Name = "btnAddMitting";
            this.btnAddMitting.Size = new System.Drawing.Size(89, 32);
            this.btnAddMitting.TabIndex = 10;
            this.btnAddMitting.Text = "הוסף";
            this.btnAddMitting.UseVisualStyleBackColor = false;
            this.btnAddMitting.Click += new System.EventHandler(this.AddMitting_Click);
            // 
            // dateTimePickerMitting
            // 
            this.dateTimePickerMitting.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dateTimePickerMitting.CalendarTitleForeColor = System.Drawing.Color.Red;
            this.dateTimePickerMitting.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerMitting.Location = new System.Drawing.Point(179, 19);
            this.dateTimePickerMitting.Name = "dateTimePickerMitting";
            this.dateTimePickerMitting.Size = new System.Drawing.Size(109, 20);
            this.dateTimePickerMitting.TabIndex = 15;
            this.dateTimePickerMitting.ValueChanged += new System.EventHandler(this.dateTimePickerMitting_ValueChanged);
            // 
            // lblHourMitting
            // 
            this.lblHourMitting.AutoSize = true;
            this.lblHourMitting.Location = new System.Drawing.Point(135, 26);
            this.lblHourMitting.Name = "lblHourMitting";
            this.lblHourMitting.Size = new System.Drawing.Size(30, 13);
            this.lblHourMitting.TabIndex = 16;
            this.lblHourMitting.Text = "שעה";
            // 
            // txtbClientPhone
            // 
            this.txtbClientPhone.Enabled = false;
            this.txtbClientPhone.Location = new System.Drawing.Point(13, 22);
            this.txtbClientPhone.Name = "txtbClientPhone";
            this.txtbClientPhone.Size = new System.Drawing.Size(91, 20);
            this.txtbClientPhone.TabIndex = 19;
            // 
            // lblClientPhone
            // 
            this.lblClientPhone.AutoSize = true;
            this.lblClientPhone.Location = new System.Drawing.Point(105, 29);
            this.lblClientPhone.Name = "lblClientPhone";
            this.lblClientPhone.Size = new System.Drawing.Size(38, 13);
            this.lblClientPhone.TabIndex = 18;
            this.lblClientPhone.Text = "טלפון";
            // 
            // txtbClientName
            // 
            this.txtbClientName.Enabled = false;
            this.txtbClientName.Location = new System.Drawing.Point(153, 22);
            this.txtbClientName.Name = "txtbClientName";
            this.txtbClientName.Size = new System.Drawing.Size(136, 20);
            this.txtbClientName.TabIndex = 21;
            this.txtbClientName.TextChanged += new System.EventHandler(this.txtbClientName_TextChanged);
            // 
            // lblClientLastName
            // 
            this.lblClientLastName.AutoSize = true;
            this.lblClientLastName.Location = new System.Drawing.Point(295, 30);
            this.lblClientLastName.Name = "lblClientLastName";
            this.lblClientLastName.Size = new System.Drawing.Size(52, 13);
            this.lblClientLastName.TabIndex = 20;
            this.lblClientLastName.Text = "שם לקוח";
            // 
            // lblStatusMitting
            // 
            this.lblStatusMitting.AutoSize = true;
            this.lblStatusMitting.Location = new System.Drawing.Point(375, 293);
            this.lblStatusMitting.Name = "lblStatusMitting";
            this.lblStatusMitting.Size = new System.Drawing.Size(77, 13);
            this.lblStatusMitting.TabIndex = 22;
            this.lblStatusMitting.Text = "סטטוס פגישה";
            this.lblStatusMitting.Click += new System.EventHandler(this.lblStatusMitting_Click);
            // 
            // rbStatusMittingYes
            // 
            this.rbStatusMittingYes.AutoSize = true;
            this.rbStatusMittingYes.Location = new System.Drawing.Point(302, 290);
            this.rbStatusMittingYes.Name = "rbStatusMittingYes";
            this.rbStatusMittingYes.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStatusMittingYes.Size = new System.Drawing.Size(58, 17);
            this.rbStatusMittingYes.TabIndex = 23;
            this.rbStatusMittingYes.TabStop = true;
            this.rbStatusMittingYes.Text = "בוצעה";
            this.rbStatusMittingYes.UseVisualStyleBackColor = true;
            // 
            // rbStatusMittingNo
            // 
            this.rbStatusMittingNo.AutoSize = true;
            this.rbStatusMittingNo.Location = new System.Drawing.Point(284, 313);
            this.rbStatusMittingNo.Name = "rbStatusMittingNo";
            this.rbStatusMittingNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStatusMittingNo.Size = new System.Drawing.Size(76, 17);
            this.rbStatusMittingNo.TabIndex = 24;
            this.rbStatusMittingNo.TabStop = true;
            this.rbStatusMittingNo.Text = "לא בוצעה";
            this.rbStatusMittingNo.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbHour);
            this.groupBox1.Controls.Add(this.cmbMoment);
            this.groupBox1.Controls.Add(this.dateTimePickerMitting);
            this.groupBox1.Controls.Add(this.lbldateMitting);
            this.groupBox1.Controls.Add(this.lblHourMitting);
            this.groupBox1.Location = new System.Drawing.Point(353, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 58);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "זמן";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(179, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(141, 12);
            this.label5.TabIndex = 65;
            this.label5.Text = "לא ניתן לקבוע פגישה בימי שישי ושבת";
            this.label5.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(122, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 64;
            this.label2.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(290, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(61, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = ":";
            // 
            // cmbHour
            // 
            this.cmbHour.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHour.FormattingEnabled = true;
            this.cmbHour.Items.AddRange(new object[] {
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.cmbHour.Location = new System.Drawing.Point(11, 22);
            this.cmbHour.Name = "cmbHour";
            this.cmbHour.Size = new System.Drawing.Size(46, 21);
            this.cmbHour.TabIndex = 18;
            // 
            // cmbMoment
            // 
            this.cmbMoment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMoment.FormattingEnabled = true;
            this.cmbMoment.Items.AddRange(new object[] {
            "00",
            "30"});
            this.cmbMoment.Location = new System.Drawing.Point(74, 22);
            this.cmbMoment.Name = "cmbMoment";
            this.cmbMoment.Size = new System.Drawing.Size(46, 21);
            this.cmbMoment.TabIndex = 17;
            this.cmbMoment.SelectedIndexChanged += new System.EventHandler(this.cmbMoment_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAddClient);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbID);
            this.groupBox2.Controls.Add(this.lblClientID);
            this.groupBox2.Controls.Add(this.lblClientLastName);
            this.groupBox2.Controls.Add(this.lblClientPhone);
            this.groupBox2.Controls.Add(this.txtbClientPhone);
            this.groupBox2.Controls.Add(this.txtbClientName);
            this.groupBox2.Location = new System.Drawing.Point(71, 208);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(640, 56);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "פרטי לקוח";
            // 
            // btnAddClient
            // 
            this.btnAddClient.BackColor = System.Drawing.Color.White;
            this.btnAddClient.Location = new System.Drawing.Point(359, 22);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(27, 21);
            this.btnAddClient.TabIndex = 47;
            this.btnAddClient.Text = "...";
            this.btnAddClient.UseVisualStyleBackColor = false;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(516, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "*";
            // 
            // cmbID
            // 
            this.cmbID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbID.FormattingEnabled = true;
            this.cmbID.Location = new System.Drawing.Point(392, 22);
            this.cmbID.Name = "cmbID";
            this.cmbID.Size = new System.Drawing.Size(121, 21);
            this.cmbID.TabIndex = 23;
            this.cmbID.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(532, 25);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(96, 13);
            this.lblClientID.TabIndex = 22;
            this.lblClientID.Text = "תעודת זהות לקוח";
            // 
            // errorProviderHour
            // 
            this.errorProviderHour.ContainerControl = this;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderStatus
            // 
            this.errorProviderStatus.ContainerControl = this;
            // 
            // errorProviderDate
            // 
            this.errorProviderDate.ContainerControl = this;
            // 
            // errorProviderId
            // 
            this.errorProviderId.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(61, 369);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // MittingsAddUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 433);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbStatusMittingNo);
            this.Controls.Add(this.rbStatusMittingYes);
            this.Controls.Add(this.lblStatusMitting);
            this.Controls.Add(this.LBLkodMitting);
            this.Controls.Add(this.txtbkodMitting);
            this.Controls.Add(this.btnAddMitting);
            this.Name = "MittingsAddUpdate";
            this.Text = "MittingsAddUpdate";
            this.Load += new System.EventHandler(this.MittingsAddUpdate_Load);
            this.Controls.SetChildIndex(this.btnAddMitting, 0);
            this.Controls.SetChildIndex(this.txtbkodMitting, 0);
            this.Controls.SetChildIndex(this.LBLkodMitting, 0);
            this.Controls.SetChildIndex(this.lblStatusMitting, 0);
            this.Controls.SetChildIndex(this.rbStatusMittingYes, 0);
            this.Controls.SetChildIndex(this.rbStatusMittingNo, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLkodMitting;
        private System.Windows.Forms.Label lbldateMitting;
        private System.Windows.Forms.TextBox txtbkodMitting;
        private System.Windows.Forms.Button btnAddMitting;
        private System.Windows.Forms.DateTimePicker dateTimePickerMitting;
        private System.Windows.Forms.Label lblHourMitting;
        private System.Windows.Forms.TextBox txtbClientPhone;
        private System.Windows.Forms.Label lblClientPhone;
        private System.Windows.Forms.TextBox txtbClientName;
        private System.Windows.Forms.Label lblClientLastName;
        private System.Windows.Forms.Label lblStatusMitting;
        private System.Windows.Forms.RadioButton rbStatusMittingYes;
        private System.Windows.Forms.RadioButton rbStatusMittingNo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbID;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.ErrorProvider errorProviderHour;
        private System.Windows.Forms.ErrorProvider errorProviderName;
        private System.Windows.Forms.ErrorProvider errorProviderPhone;
        private System.Windows.Forms.ErrorProvider errorProviderStatus;
        private System.Windows.Forms.ErrorProvider errorProviderDate;
        private System.Windows.Forms.ErrorProvider errorProviderId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbHour;
        private System.Windows.Forms.ComboBox cmbMoment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label5;
    }
}