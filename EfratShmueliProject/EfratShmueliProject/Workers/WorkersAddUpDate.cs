using EfratShmueliProject.Cities;
using EfratShmueliProject.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.Workers
{
    public partial class WorkersAddUpDate : Designer
    {
        WorkersTbl cctbl = new WorkersTbl();
        string status;
        Cities.Cities city;
        Workers c = new Workers();
        CitiesTbl citiestbl = new CitiesTbl();
        public WorkersAddUpDate()
        {
            InitializeComponent();
            status = "Add";
            //סטטוס לקוח  חדש- פעיל
            rbStatusp.Checked = true;
            c = new Workers();
        }
        public WorkersAddUpDate(int W_kod)
        {
            InitializeComponent();
            status = "Update";
            DataRow dr = cctbl.Find("W_kod", W_kod);
            c = new Workers(dr);
            FillForm();
        }
        public void FillForm()
        {
            txtbKodWorker.Text = c.FW_kod.ToString();
            txtbLastName.Text = c.FW_lastName.ToString();
            txtbMail.Text = c.FW_Mail.ToString();
            txtbPassword.Text = c.FW_password.ToString();
            if (c.FW_phone != "")
            {
                string[] str1 = c.FW_phone.Split('-');
                cmbPhone2.Text = str1[0];
                txtbPhone2.Text = str1[1];
            }
            txtbAdress.Text = c.FW_adress.ToString();
            txtbMail.Text = c.FW_Mail.ToString();
            dateTimePicker1.Text = c.FW_dateOfBirth.ToString();
            btnAddWorker.Text = "עדכן";
            this.Text = "עדכון לקוח";
            if (c.FW_status == "פעיל")
            {
                rbStatusp.Checked = true;
            }
            else
            {
                rbstatusnp.Checked = true;
            }

        }
        public void FillCBCity()
        {
            cmbCity.SelectedIndexChanged -= cmbCity_SelectedIndexChanged;
            cmbCity.DataSource = citiestbl.getalltable();
            cmbCity.DisplayMember = "שם עיר";
            cmbCity.ValueMember = "קוד עיר";
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            cmbCity.SelectedIndex = 0;
        }
        public bool CheckLegal()
        {
            errorProviderLastName.Clear();
            errorProviderPassword.Clear();
            errorProviderDATEOFBIRTH.Clear();
            errorProviderMail.Clear();
            errorProviderFirstName.Clear();
            errorProviderKODCITY.Clear();
            errorProviderPHONE1.Clear();
            errorProviderPHONE2.Clear();
            errorProviderDATEOFBIRTH.Clear();
            errorProviderSTATUS.Clear();
            errorProviderADDRESS.Clear();
            bool degel = true;
            c.FW_cityKod = int.Parse(cmbCity.SelectedValue.ToString());
            c.FW_kod = int.Parse(txtbKodWorker.Text);

            //סטטוס
            if (rbStatusp.Checked)
                c.FW_status = "פעיל";
            else
                c.FW_status = "לא פעיל";
            
            //שם משפחה
            if (txtbLastName.Text != "" && txtbLastName.Text.Length >= 2)

                try
                {
                    c.FW_lastName = txtbLastName.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderLastName.SetError(txtbLastName, ex1.Message);
                    degel = false;
                }
            else
            {
                txtbLastName.BackColor = Color.LightSalmon;
                degel = false;
            }
            //כתובת
            //if (txtbAdress.Text != "")
                try
                {
                c.FW_adress = txtbAdress.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderADDRESS.SetError(txtbAdress, ex1.Message);
                    degel = false;
                }
            //else
            //{
            //    txtbAdress.BackColor = Color.LightSalmon;
            //    degel = false;
            //}
            //מייל
            if (txtbMail.Text != "")
            try
            {
                c.FW_Mail = txtbMail.Text;
            }
            catch (Exception ex1)
            {
                errorProviderMail.SetError(txtbMail, ex1.Message);
                degel = false;
            }
            else
            {
                txtbMail.BackColor = Color.LightSalmon;
                degel = false;
            }
            //תאריך לידה
            try
            {
                c.FW_dateOfBirth = dateTimePicker1.Text;
            }
            catch (Exception ex1)
            {
                errorProviderDATEOFBIRTH.SetError(dateTimePicker1, ex1.Message);
                degel = false;
            }
            //פלאפון
            if (txtbPhone2.Text != "" && txtbPhone2.Text.Length == 7)
            try
            {
                c.FW_phone = cmbPhone2.Text + "-" + txtbPhone2.Text;
            }
            catch (Exception ex1)
            {
                errorProviderPHONE2.SetError(txtbPhone2, ex1.Message);
                degel = false;
            }
            else
            {
                txtbPhone2.BackColor = Color.LightSalmon;
                degel = false;
            }
            //סיסמת עובד
            if (txtbPassword.Text != "" && txtbPassword.Text.Length == 4)
            {
                try
                {
                    c.FW_password = txtbPassword.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderPassword.SetError(txtbPassword, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txtbPassword.BackColor = Color.LightSalmon;
                degel = false;
            }
            return degel;



        }
        private void WorkersAddUpDate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            dateTimePicker1.MaxDate = DateTime.Now;
            cctbl = new WorkersTbl();
            FillCBCity();

            if (status != "Add")
            {
                this.Text = "עדכון עובד";
                DataRow drcity = citiestbl.Find("CI_kod", c.FW_cityKod);
                city = new Cities.Cities(drcity);
                cmbCity.Text = city.FCi_name;
            }
            else
            {
                txtbKodWorker.Text = cctbl.GetNext("W_kod").ToString();
                this.Text = "הוספת עובד";
                rbstatusnp.Visible = false;
                rbStatusp.Visible = false;
                lblStatus.Visible = false;
                cmbPhone2.SelectedIndex = 0;
            }
        }

        private void CITYADD_Click(object sender, EventArgs e)
        {
            {
                CitiesAddUpdate C = new CitiesAddUpdate();
                C.ShowDialog();
                cmbCity.SelectedIndexChanged -= cmbCity_SelectedIndexChanged;
                cmbCity.DataSource = citiestbl.getalltable();
                cmbCity.DisplayMember = "שם עיר";
                cmbCity.ValueMember = "קוד עיר";
                cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
                cmbCity.SelectedIndex = 0;
                DataRow DR = citiestbl.Find("CI_kod", citiestbl.GetNext("CI_kod") - 1);
                cmbCity.Text = DR["CI_name"].ToString();
            }
        }
        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            if (CheckLegal())
            {
                if (status == "Add")
                {
                    cctbl.AddWorkwrs(c);
                }
                else
                {
                    cctbl.UpDateWorkers(c);
                }
                this.Close();
            }
        }
        private void btnAddCitiy_Click(object sender, EventArgs e)
        {
            CitiesAddUpdate cc = new CitiesAddUpdate();
            cc.ShowDialog();
            CitiesAddUpdate C = new CitiesAddUpdate();
            cmbCity.SelectedIndexChanged -= cmbCity_SelectedIndexChanged;
            cmbCity.DataSource = citiestbl.getalltable();
            cmbCity.DisplayMember = "שם עיר";
            cmbCity.ValueMember = "קוד עיר";
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            cmbCity.SelectedIndex = 0;
            DataRow drr = citiestbl.Find("CI_kod", citiestbl.GetNext("CI_kod") - 1);
            cmbCity.Text = drr["CI_name"].ToString();
        }

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtbLastName.BackColor == Color.LightSalmon)
                txtbLastName.BackColor = Color.White;
        }
        private void txtbAdress_TextChanged(object sender, EventArgs e)
        {
            if (txtbAdress.BackColor == Color.LightSalmon)
                txtbAdress.BackColor = Color.White;
        }

        private void txtbMail_TextChanged(object sender, EventArgs e)
        {
            if (txtbMail.BackColor == Color.LightSalmon)
                txtbMail.BackColor = Color.White;
        }

        private void txtbPhone2_TextChanged(object sender, EventArgs e)
        {
            if (txtbPhone2.BackColor == Color.LightSalmon)
                txtbPhone2.BackColor = Color.White;
        }

        private void txtbPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtbPassword.BackColor == Color.LightSalmon)
                txtbPassword.BackColor = Color.White;
        }

        private void lblStatus_Click(object sender, EventArgs e)
        {

        }
    }
}
