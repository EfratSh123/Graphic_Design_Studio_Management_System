namespace EfratShmueliProject.AllTheUsers
{
    partial class UserMeeting
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
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.btnMittingDeitals = new System.Windows.Forms.Button();
            this.labelCa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelName.Location = new System.Drawing.Point(9, 4);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 8;
            this.labelName.Text = "label7";
            this.labelName.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(90, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = ":שם לקוח";
            this.label1.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.ActiveLinkColor = System.Drawing.Color.Red;
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.linkLabel2.ForeColor = System.Drawing.Color.Crimson;
            this.linkLabel2.LinkColor = System.Drawing.Color.Crimson;
            this.linkLabel2.Location = new System.Drawing.Point(12, 5);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(121, 24);
            this.linkLabel2.TabIndex = 6;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "לקביעת פגישה";
            this.linkLabel2.Visible = false;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // btnMittingDeitals
            // 
            this.btnMittingDeitals.Location = new System.Drawing.Point(7, 19);
            this.btnMittingDeitals.Name = "btnMittingDeitals";
            this.btnMittingDeitals.Size = new System.Drawing.Size(130, 23);
            this.btnMittingDeitals.TabIndex = 9;
            this.btnMittingDeitals.Text = "הצגת פרטי פגישה";
            this.btnMittingDeitals.UseVisualStyleBackColor = true;
            this.btnMittingDeitals.Visible = false;
            this.btnMittingDeitals.Click += new System.EventHandler(this.btnMittingDeitals_Click);
            // 
            // labelCa
            // 
            this.labelCa.AutoSize = true;
            this.labelCa.Enabled = false;
            this.labelCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCa.ForeColor = System.Drawing.Color.Blue;
            this.labelCa.Location = new System.Drawing.Point(29, 10);
            this.labelCa.Name = "labelCa";
            this.labelCa.Size = new System.Drawing.Size(76, 25);
            this.labelCa.TabIndex = 10;
            this.labelCa.Text = "חופשה";
            this.labelCa.Visible = false;
            // 
            // UserMeeting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelCa);
            this.Controls.Add(this.btnMittingDeitals);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.linkLabel2);
            this.Name = "UserMeeting";
            this.Size = new System.Drawing.Size(144, 45);
            this.Load += new System.EventHandler(this.UserMeeting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelName;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Button btnMittingDeitals;
        public System.Windows.Forms.Label labelCa;
    }
}
