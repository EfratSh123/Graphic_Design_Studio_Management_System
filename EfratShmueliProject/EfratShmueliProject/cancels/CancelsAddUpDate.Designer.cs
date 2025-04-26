namespace EfratShmueliProject.cancels
{
    partial class CancelsAddUpDate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelsAddUpDate));
            this.lblDateStart = new System.Windows.Forms.Label();
            this.lblKodCancel = new System.Windows.Forms.Label();
            this.txtKodCancel = new System.Windows.Forms.TextBox();
            this.AddKindOrder = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.errorProviderWorkerKod = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderDATE = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblLastNameWorker = new System.Windows.Forms.Label();
            this.lblPhoneWorker = new System.Windows.Forms.Label();
            this.txtbWorkerPhone = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.lbldateEnd = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rbStatusYes = new System.Windows.Forms.RadioButton();
            this.rbStatusNo = new System.Windows.Forms.RadioButton();
            this.lblStatus = new System.Windows.Forms.Label();
            this.rbStatusWate = new System.Windows.Forms.RadioButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnWorkingForGrafics = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWorkerKod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDATE)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(311, 35);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(78, 13);
            this.lblDateStart.TabIndex = 74;
            this.lblDateStart.Text = "תאריך התחלה";
            // 
            // lblKodCancel
            // 
            this.lblKodCancel.AutoSize = true;
            this.lblKodCancel.Location = new System.Drawing.Point(584, 106);
            this.lblKodCancel.Name = "lblKodCancel";
            this.lblKodCancel.Size = new System.Drawing.Size(64, 13);
            this.lblKodCancel.TabIndex = 72;
            this.lblKodCancel.Text = "קוד חופשה";
            // 
            // txtKodCancel
            // 
            this.txtKodCancel.BackColor = System.Drawing.Color.White;
            this.txtKodCancel.Enabled = false;
            this.txtKodCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.txtKodCancel.Location = new System.Drawing.Point(537, 95);
            this.txtKodCancel.Name = "txtKodCancel";
            this.txtKodCancel.Size = new System.Drawing.Size(41, 24);
            this.txtKodCancel.TabIndex = 69;
            // 
            // AddKindOrder
            // 
            this.AddKindOrder.BackColor = System.Drawing.Color.Gold;
            this.AddKindOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddKindOrder.Location = new System.Drawing.Point(58, 438);
            this.AddKindOrder.Name = "AddKindOrder";
            this.AddKindOrder.Size = new System.Drawing.Size(89, 32);
            this.AddKindOrder.TabIndex = 68;
            this.AddKindOrder.Text = "הוסף";
            this.AddKindOrder.UseVisualStyleBackColor = false;
            this.AddKindOrder.Click += new System.EventHandler(this.AddKindOrder_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker1.TabIndex = 77;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // errorProviderWorkerKod
            // 
            this.errorProviderWorkerKod.ContainerControl = this;
            // 
            // errorProviderDATE
            // 
            this.errorProviderDATE.ContainerControl = this;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.cmbName);
            this.groupBox2.Controls.Add(this.lblLastNameWorker);
            this.groupBox2.Controls.Add(this.lblPhoneWorker);
            this.groupBox2.Controls.Add(this.txtbWorkerPhone);
            this.groupBox2.Location = new System.Drawing.Point(132, 141);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(513, 56);
            this.groupBox2.TabIndex = 78;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "פרטי עובד";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(455, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 20);
            this.label4.TabIndex = 65;
            this.label4.Text = "*";
            // 
            // cmbName
            // 
            this.cmbName.BackColor = System.Drawing.Color.White;
            this.cmbName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Location = new System.Drawing.Point(204, 22);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(245, 21);
            this.cmbName.TabIndex = 23;
            this.cmbName.SelectedIndexChanged += new System.EventHandler(this.cmbID_SelectedIndexChanged);
            // 
            // lblLastNameWorker
            // 
            this.lblLastNameWorker.AutoSize = true;
            this.lblLastNameWorker.Location = new System.Drawing.Point(469, 29);
            this.lblLastNameWorker.Name = "lblLastNameWorker";
            this.lblLastNameWorker.Size = new System.Drawing.Size(26, 13);
            this.lblLastNameWorker.TabIndex = 22;
            this.lblLastNameWorker.Text = " שם";
            // 
            // lblPhoneWorker
            // 
            this.lblPhoneWorker.AutoSize = true;
            this.lblPhoneWorker.Location = new System.Drawing.Point(116, 29);
            this.lblPhoneWorker.Name = "lblPhoneWorker";
            this.lblPhoneWorker.Size = new System.Drawing.Size(76, 13);
            this.lblPhoneWorker.TabIndex = 18;
            this.lblPhoneWorker.Text = "מספר פלאפון";
            // 
            // txtbWorkerPhone
            // 
            this.txtbWorkerPhone.BackColor = System.Drawing.Color.White;
            this.txtbWorkerPhone.Enabled = false;
            this.txtbWorkerPhone.Location = new System.Drawing.Point(19, 22);
            this.txtbWorkerPhone.Name = "txtbWorkerPhone";
            this.txtbWorkerPhone.Size = new System.Drawing.Size(91, 20);
            this.txtbWorkerPhone.TabIndex = 19;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.lbldateEnd);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.lblDateStart);
            this.groupBox1.Location = new System.Drawing.Point(238, 218);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(407, 64);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "פרטי חופשה";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.Color.OldLace;
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(18, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker2.TabIndex = 79;
            // 
            // lbldateEnd
            // 
            this.lbldateEnd.AutoSize = true;
            this.lbldateEnd.Location = new System.Drawing.Point(120, 35);
            this.lbldateEnd.Name = "lbldateEnd";
            this.lbldateEnd.Size = new System.Drawing.Size(67, 13);
            this.lbldateEnd.TabIndex = 78;
            this.lbldateEnd.Text = "תאריך סיום";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(58, 476);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(89, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 80;
            this.pictureBox1.TabStop = false;
            // 
            // rbStatusYes
            // 
            this.rbStatusYes.AutoSize = true;
            this.rbStatusYes.ForeColor = System.Drawing.Color.Black;
            this.rbStatusYes.Location = new System.Drawing.Point(256, 438);
            this.rbStatusYes.Name = "rbStatusYes";
            this.rbStatusYes.Size = new System.Drawing.Size(60, 17);
            this.rbStatusYes.TabIndex = 83;
            this.rbStatusYes.Text = "מאושר";
            this.rbStatusYes.UseVisualStyleBackColor = true;
            // 
            // rbStatusNo
            // 
            this.rbStatusNo.AutoSize = true;
            this.rbStatusNo.ForeColor = System.Drawing.Color.Black;
            this.rbStatusNo.Location = new System.Drawing.Point(238, 470);
            this.rbStatusNo.Name = "rbStatusNo";
            this.rbStatusNo.Size = new System.Drawing.Size(78, 17);
            this.rbStatusNo.TabIndex = 82;
            this.rbStatusNo.Text = "לא מאושר";
            this.rbStatusNo.UseVisualStyleBackColor = true;
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Location = new System.Drawing.Point(323, 406);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(74, 13);
            this.lblStatus.TabIndex = 81;
            this.lblStatus.Text = "סטטוס ביטול";
            // 
            // rbStatusWate
            // 
            this.rbStatusWate.AutoSize = true;
            this.rbStatusWate.Checked = true;
            this.rbStatusWate.ForeColor = System.Drawing.Color.Black;
            this.rbStatusWate.Location = new System.Drawing.Point(261, 406);
            this.rbStatusWate.Name = "rbStatusWate";
            this.rbStatusWate.Size = new System.Drawing.Size(55, 17);
            this.rbStatusWate.TabIndex = 84;
            this.rbStatusWate.TabStop = true;
            this.rbStatusWate.Text = "בקשה";
            this.rbStatusWate.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(132, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(513, 77);
            this.dataGridView1.TabIndex = 85;
            this.dataGridView1.Visible = false;
            // 
            // btnWorkingForGrafics
            // 
            this.btnWorkingForGrafics.BackColor = System.Drawing.Color.White;
            this.btnWorkingForGrafics.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btnWorkingForGrafics.ForeColor = System.Drawing.Color.Black;
            this.btnWorkingForGrafics.Location = new System.Drawing.Point(26, 69);
            this.btnWorkingForGrafics.Name = "btnWorkingForGrafics";
            this.btnWorkingForGrafics.Size = new System.Drawing.Size(156, 40);
            this.btnWorkingForGrafics.TabIndex = 86;
            this.btnWorkingForGrafics.Text = "עבודות של גרפיקאית זו";
            this.btnWorkingForGrafics.UseVisualStyleBackColor = false;
            this.btnWorkingForGrafics.Click += new System.EventHandler(this.btnWorkingForGrafics_Click);
            // 
            // CancelsAddUpDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 539);
            this.Controls.Add(this.btnWorkingForGrafics);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.rbStatusWate);
            this.Controls.Add(this.rbStatusYes);
            this.Controls.Add(this.rbStatusNo);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lblKodCancel);
            this.Controls.Add(this.txtKodCancel);
            this.Controls.Add(this.AddKindOrder);
            this.Name = "CancelsAddUpDate";
            this.Text = "CancelsAddUpDate";
            this.Load += new System.EventHandler(this.CancelsAddUpDate_Load);
            this.Controls.SetChildIndex(this.AddKindOrder, 0);
            this.Controls.SetChildIndex(this.txtKodCancel, 0);
            this.Controls.SetChildIndex(this.lblKodCancel, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.lblStatus, 0);
            this.Controls.SetChildIndex(this.rbStatusNo, 0);
            this.Controls.SetChildIndex(this.rbStatusYes, 0);
            this.Controls.SetChildIndex(this.rbStatusWate, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.btnWorkingForGrafics, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderWorkerKod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderDATE)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblKodCancel;
        private System.Windows.Forms.TextBox txtKodCancel;
        private System.Windows.Forms.Button AddKindOrder;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ErrorProvider errorProviderWorkerKod;
        private System.Windows.Forms.ErrorProvider errorProviderDATE;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblLastNameWorker;
        private System.Windows.Forms.Label lblPhoneWorker;
        private System.Windows.Forms.TextBox txtbWorkerPhone;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label lbldateEnd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RadioButton rbStatusWate;
        private System.Windows.Forms.RadioButton rbStatusYes;
        private System.Windows.Forms.RadioButton rbStatusNo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnWorkingForGrafics;
    }
}