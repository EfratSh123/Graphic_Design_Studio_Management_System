namespace EfratShmueliProject.Workers
{
    partial class WorkersAddUpDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WorkersAddUpDate));
            this.rbstatusnp = new System.Windows.Forms.RadioButton();
            this.rbStatusp = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtbPhone2 = new System.Windows.Forms.TextBox();
            this.txtbMail = new System.Windows.Forms.TextBox();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblPhone2 = new System.Windows.Forms.Label();
            this.cmbPhone2 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtbAdress = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.cmbCity = new System.Windows.Forms.ComboBox();
            this.btnAddCitiy = new System.Windows.Forms.Button();
            this.lblDateOfBirth = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblIDMast = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbLastName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtbKodWorker = new System.Windows.Forms.TextBox();
            this.lblKodWorker = new System.Windows.Forms.Label();
            this.btnAddWorker = new System.Windows.Forms.Button();
            this.errorProviderADDRESS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderKODCITY = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPHONE1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPHONE2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDATEOFBIRTH = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSTATUS = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderLastName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderMail = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtbPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderADDRESS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKODCITY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPHONE1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPHONE2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDATEOFBIRTH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSTATUS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rbstatusnp
            // 
            this.rbstatusnp.AutoSize = true;
            this.rbstatusnp.Location = new System.Drawing.Point(445, 416);
            this.rbstatusnp.Name = "rbstatusnp";
            this.rbstatusnp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbstatusnp.Size = new System.Drawing.Size(69, 17);
            this.rbstatusnp.TabIndex = 69;
            this.rbstatusnp.TabStop = true;
            this.rbstatusnp.Text = "לא פעיל";
            this.rbstatusnp.UseVisualStyleBackColor = true;
            // 
            // rbStatusp
            // 
            this.rbStatusp.AutoSize = true;
            this.rbStatusp.Location = new System.Drawing.Point(463, 391);
            this.rbStatusp.Name = "rbStatusp";
            this.rbStatusp.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rbStatusp.Size = new System.Drawing.Size(51, 17);
            this.rbStatusp.TabIndex = 68;
            this.rbStatusp.TabStop = true;
            this.rbStatusp.Text = "פעיל";
            this.rbStatusp.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(520, 391);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(40, 13);
            this.lblStatus.TabIndex = 67;
            this.lblStatus.Text = "סטטוס";
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtbPhone2);
            this.groupBox3.Controls.Add(this.txtbMail);
            this.groupBox3.Controls.Add(this.lblMail);
            this.groupBox3.Controls.Add(this.lblPhone2);
            this.groupBox3.Controls.Add(this.cmbPhone2);
            this.groupBox3.Location = new System.Drawing.Point(139, 282);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(611, 66);
            this.groupBox3.TabIndex = 66;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "פרטים ליצירת קשר";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(237, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(506, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 63;
            this.label4.Text = "*";
            // 
            // txtbPhone2
            // 
            this.txtbPhone2.Location = new System.Drawing.Point(402, 27);
            this.txtbPhone2.Name = "txtbPhone2";
            this.txtbPhone2.Size = new System.Drawing.Size(100, 20);
            this.txtbPhone2.TabIndex = 38;
            this.txtbPhone2.TextChanged += new System.EventHandler(this.txtbPhone2_TextChanged);
            // 
            // txtbMail
            // 
            this.txtbMail.Location = new System.Drawing.Point(17, 24);
            this.txtbMail.Name = "txtbMail";
            this.txtbMail.Size = new System.Drawing.Size(215, 20);
            this.txtbMail.TabIndex = 53;
            this.txtbMail.TextChanged += new System.EventHandler(this.txtbMail_TextChanged);
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(254, 30);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(67, 13);
            this.lblMail.TabIndex = 52;
            this.lblMail.Text = "כתובת מייל";
            // 
            // lblPhone2
            // 
            this.lblPhone2.AutoSize = true;
            this.lblPhone2.Location = new System.Drawing.Point(522, 31);
            this.lblPhone2.Name = "lblPhone2";
            this.lblPhone2.Size = new System.Drawing.Size(76, 13);
            this.lblPhone2.TabIndex = 36;
            this.lblPhone2.Text = "מספר פלאפון";
            // 
            // cmbPhone2
            // 
            this.cmbPhone2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPhone2.FormattingEnabled = true;
            this.cmbPhone2.Items.AddRange(new object[] {
            "050",
            "052",
            "053",
            "054",
            "055",
            "058"});
            this.cmbPhone2.Location = new System.Drawing.Point(345, 26);
            this.cmbPhone2.Name = "cmbPhone2";
            this.cmbPhone2.Size = new System.Drawing.Size(51, 21);
            this.cmbPhone2.TabIndex = 37;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtbAdress);
            this.groupBox2.Controls.Add(this.lblCity);
            this.groupBox2.Controls.Add(this.address);
            this.groupBox2.Controls.Add(this.cmbCity);
            this.groupBox2.Controls.Add(this.btnAddCitiy);
            this.groupBox2.Location = new System.Drawing.Point(415, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(335, 57);
            this.groupBox2.TabIndex = 65;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "כתובת";
            // 
            // txtbAdress
            // 
            this.txtbAdress.Location = new System.Drawing.Point(18, 19);
            this.txtbAdress.Name = "txtbAdress";
            this.txtbAdress.Size = new System.Drawing.Size(100, 20);
            this.txtbAdress.TabIndex = 44;
            this.txtbAdress.TextChanged += new System.EventHandler(this.txtbAdress_TextChanged);
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(294, 26);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(25, 13);
            this.lblCity.TabIndex = 32;
            this.lblCity.Text = "עיר";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.Location = new System.Drawing.Point(122, 26);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(32, 13);
            this.address.TabIndex = 43;
            this.address.Text = "רחוב";
            // 
            // cmbCity
            // 
            this.cmbCity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCity.FormattingEnabled = true;
            this.cmbCity.Location = new System.Drawing.Point(190, 18);
            this.cmbCity.Name = "cmbCity";
            this.cmbCity.Size = new System.Drawing.Size(100, 21);
            this.cmbCity.TabIndex = 45;
            this.cmbCity.SelectedIndexChanged += new System.EventHandler(this.cmbCity_SelectedIndexChanged);
            // 
            // btnAddCitiy
            // 
            this.btnAddCitiy.BackColor = System.Drawing.Color.White;
            this.btnAddCitiy.Location = new System.Drawing.Point(157, 18);
            this.btnAddCitiy.Name = "btnAddCitiy";
            this.btnAddCitiy.Size = new System.Drawing.Size(27, 21);
            this.btnAddCitiy.TabIndex = 46;
            this.btnAddCitiy.Text = "...";
            this.btnAddCitiy.UseVisualStyleBackColor = false;
            this.btnAddCitiy.Click += new System.EventHandler(this.btnAddCitiy_Click);
            // 
            // lblDateOfBirth
            // 
            this.lblDateOfBirth.AutoSize = true;
            this.lblDateOfBirth.Location = new System.Drawing.Point(147, 32);
            this.lblDateOfBirth.Name = "lblDateOfBirth";
            this.lblDateOfBirth.Size = new System.Drawing.Size(69, 13);
            this.lblDateOfBirth.TabIndex = 60;
            this.lblDateOfBirth.Text = "תאריך לידה";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblIDMast);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtbLastName);
            this.groupBox1.Controls.Add(this.lblLastName);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDateOfBirth);
            this.groupBox1.Location = new System.Drawing.Point(139, 126);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 70);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטים אישיים";
            // 
            // lblIDMast
            // 
            this.lblIDMast.AutoSize = true;
            this.lblIDMast.Location = new System.Drawing.Point(498, 46);
            this.lblIDMast.Name = "lblIDMast";
            this.lblIDMast.Size = new System.Drawing.Size(0, 13);
            this.lblIDMast.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(475, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 61;
            this.label2.Text = "*";
            // 
            // txtbLastName
            // 
            this.txtbLastName.Location = new System.Drawing.Point(236, 27);
            this.txtbLastName.Name = "txtbLastName";
            this.txtbLastName.Size = new System.Drawing.Size(231, 20);
            this.txtbLastName.TabIndex = 51;
            this.txtbLastName.TextChanged += new System.EventHandler(this.txtbLastName_TextChanged);
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(494, 32);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(96, 13);
            this.lblLastName.TabIndex = 50;
            this.lblLastName.Text = "שם פרטי ומשפחה";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(32, 27);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(109, 20);
            this.dateTimePicker1.TabIndex = 61;
            // 
            // txtbKodWorker
            // 
            this.txtbKodWorker.Enabled = false;
            this.txtbKodWorker.Location = new System.Drawing.Point(664, 85);
            this.txtbKodWorker.Name = "txtbKodWorker";
            this.txtbKodWorker.Size = new System.Drawing.Size(33, 20);
            this.txtbKodWorker.TabIndex = 63;
            // 
            // lblKodWorker
            // 
            this.lblKodWorker.AutoSize = true;
            this.lblKodWorker.Location = new System.Drawing.Point(698, 89);
            this.lblKodWorker.Name = "lblKodWorker";
            this.lblKodWorker.Size = new System.Drawing.Size(55, 13);
            this.lblKodWorker.TabIndex = 62;
            this.lblKodWorker.Text = "קוד עובד";
            // 
            // btnAddWorker
            // 
            this.btnAddWorker.BackColor = System.Drawing.Color.Gold;
            this.btnAddWorker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnAddWorker.Location = new System.Drawing.Point(64, 406);
            this.btnAddWorker.Name = "btnAddWorker";
            this.btnAddWorker.Size = new System.Drawing.Size(100, 36);
            this.btnAddWorker.TabIndex = 70;
            this.btnAddWorker.Text = "הוסף";
            this.btnAddWorker.UseVisualStyleBackColor = false;
            this.btnAddWorker.Click += new System.EventHandler(this.btnAddWorker_Click);
            // 
            // errorProviderADDRESS
            // 
            this.errorProviderADDRESS.ContainerControl = this;
            // 
            // errorProviderFirstName
            // 
            this.errorProviderFirstName.ContainerControl = this;
            // 
            // errorProviderKODCITY
            // 
            this.errorProviderKODCITY.ContainerControl = this;
            // 
            // errorProviderPHONE1
            // 
            this.errorProviderPHONE1.ContainerControl = this;
            // 
            // errorProviderPHONE2
            // 
            this.errorProviderPHONE2.ContainerControl = this;
            // 
            // errorProviderDATEOFBIRTH
            // 
            this.errorProviderDATEOFBIRTH.ContainerControl = this;
            // 
            // errorProviderSTATUS
            // 
            this.errorProviderSTATUS.ContainerControl = this;
            // 
            // errorProviderLastName
            // 
            this.errorProviderLastName.ContainerControl = this;
            // 
            // errorProviderMail
            // 
            this.errorProviderMail.ContainerControl = this;
            // 
            // txtbPassword
            // 
            this.txtbPassword.Location = new System.Drawing.Point(583, 388);
            this.txtbPassword.Name = "txtbPassword";
            this.txtbPassword.Size = new System.Drawing.Size(96, 20);
            this.txtbPassword.TabIndex = 72;
            this.txtbPassword.TextChanged += new System.EventHandler(this.txtbPassword_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(683, 391);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 13);
            this.lblPassword.TabIndex = 71;
            this.lblPassword.Text = "סיסמת עובד";
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(64, 449);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 17);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // WorkersAddUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(803, 519);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtbPassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.btnAddWorker);
            this.Controls.Add(this.rbstatusnp);
            this.Controls.Add(this.rbStatusp);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtbKodWorker);
            this.Controls.Add(this.lblKodWorker);
            this.Name = "WorkersAddUpDate";
            this.Text = "Workers";
            this.Load += new System.EventHandler(this.WorkersAddUpDate_Load);
            this.Controls.SetChildIndex(this.lblKodWorker, 0);
            this.Controls.SetChildIndex(this.txtbKodWorker, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.lblStatus, 0);
            this.Controls.SetChildIndex(this.rbStatusp, 0);
            this.Controls.SetChildIndex(this.rbstatusnp, 0);
            this.Controls.SetChildIndex(this.btnAddWorker, 0);
            this.Controls.SetChildIndex(this.lblPassword, 0);
            this.Controls.SetChildIndex(this.txtbPassword, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderADDRESS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFirstName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderKODCITY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPHONE1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPHONE2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDATEOFBIRTH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSTATUS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderLastName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderMail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbstatusnp;
        private System.Windows.Forms.RadioButton rbStatusp;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtbPhone2;
        private System.Windows.Forms.TextBox txtbMail;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblPhone2;
        private System.Windows.Forms.ComboBox cmbPhone2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtbAdress;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.ComboBox cmbCity;
        private System.Windows.Forms.Button btnAddCitiy;
        private System.Windows.Forms.Label lblDateOfBirth;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblIDMast;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbLastName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txtbKodWorker;
        private System.Windows.Forms.Label lblKodWorker;
        private System.Windows.Forms.Button btnAddWorker;
        private System.Windows.Forms.ErrorProvider errorProviderADDRESS;
        private System.Windows.Forms.ErrorProvider errorProviderFirstName;
        private System.Windows.Forms.ErrorProvider errorProviderKODCITY;
        private System.Windows.Forms.ErrorProvider errorProviderPHONE1;
        private System.Windows.Forms.ErrorProvider errorProviderPHONE2;
        private System.Windows.Forms.ErrorProvider errorProviderDATEOFBIRTH;
        private System.Windows.Forms.ErrorProvider errorProviderSTATUS;
        private System.Windows.Forms.ErrorProvider errorProviderLastName;
        private System.Windows.Forms.ErrorProvider errorProviderMail;
        private System.Windows.Forms.TextBox txtbPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}