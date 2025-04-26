using EfratShmueliProject.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.Clients
{
    public partial class ClientsAddUpdate : Designer
    {
        ClientsTbl cctbl=new ClientsTbl();
        string status;
        Cities.Cities city;
        Clients c = new Clients();
        CitiesTbl citiestbl = new CitiesTbl();
        public ClientsAddUpdate()
        {
            InitializeComponent();
            status = "Add";
            //סטטוס לקוח  חדש- פעיל
            rbStatusp.Checked = true;
            c = new Clients();
        }
        public ClientsAddUpdate(string C_id)
        {
            InitializeComponent();
            status = "Update";
            DataRow dr = cctbl.Find("C_id", C_id);
            c = new Clients(dr);
            FillForm();
        }
        public void FillForm()
        {
            txtbKodClient.Text = c.FC_kod.ToString();
            txtbAdress.Text = c.FC_address.ToString();
            txtbID.Text = c.FC_id.ToString();
            txtbName.Text = c.FC_lastName.ToString();
            txtbMail.Text = c.FC_eMail.ToString();
            
            if (c.FC_pel != "")
            {
                string[] str1 = c.FC_pel.Split('-');
                cmbPhone2.Text = str1[0];
                txtbPhone2.Text = str1[1];
            }
            txtbAdress.Text = c.FC_address.ToString();
            btnAddClient.Text = "עדכן";
            this.Text = "עדכון לקוח";
            if (c.FC_status == "פעיל")
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
            errorProviderDATEOFBIRTH.Clear();
            errorProviderMail.Clear();
            errorProviderID.Clear();
            errorProviderFirstName.Clear();
            errorProviderKODCITY.Clear();
            errorProviderPHONE1.Clear();
            errorProviderPHONE2.Clear();
            errorProviderDATEOFBIRTH.Clear();
            errorProviderSTATUS.Clear();
            errorProviderADDRESS.Clear();
            bool degel = true;
            c.FC_cityKod = int.Parse(cmbCity.SelectedValue.ToString());
            c.FC_kod = int.Parse(txtbKodClient.Text);
            //סטטוס
            if (rbStatusp.Checked)
                c.FC_status = "פעיל";
            else
                c.FC_status = "לא פעיל";
            //ת.ז.
            if (txtbID.Text != "" && txtbID.Text.Length == 9)
            {

                if (status == "Add" && cctbl.Find("C_id", txtbID.Text) != null)
                {
                    label1id.Text = "מספר זהות קיים במערכת";
                    degel = false;
                }
                else
                    try
                    {
                        c.FC_id = txtbID.Text;
                    }
                    catch (Exception ex1)
                    {
                        errorProviderID.SetError(txtbID, ex1.Message);
                        degel = false;
                    }
            }
            else
            {
                txtbID.BackColor = Color.LightSalmon;
                degel = false;
            }
            //שם משפחה
            if (txtbName.Text != "" && txtbName.Text.Length >= 2)
            
            try
            {
                c.FC_lastName = txtbName.Text;
            }
            catch (Exception ex1)
            {
                errorProviderLastName.SetError(txtbName, ex1.Message);
                degel = false;
            }
            else
            {
                txtbName.BackColor = Color.LightSalmon;
                degel = false;
            }
            //כתובת
            if (txtbAdress.Text != "")
                try
                {
                    c.FC_address = txtbAdress.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderADDRESS.SetError(txtbAdress, ex1.Message);
                    degel = false;
                }
            else
            {
                txtbAdress.BackColor = Color.LightSalmon;
                degel = false;
            }
            //מייל
            if (txtbMail.Text != "")

                try
                {
                    c.FC_eMail = txtbMail.Text;
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
            //פלאפון
            if (txtbPhone2.Text != "" && txtbPhone2.Text.Length == 7)
                try
            {
                c.FC_pel = cmbPhone2.Text + "-" + txtbPhone2.Text;
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

            return degel;
        }
        private void ClientsAddUpdate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            cctbl = new ClientsTbl();
            FillCBCity();

            if (status != "Add")
            {
                this.Text = "עדכון לקוח";
                DataRow drcity = citiestbl.Find("CI_kod", c.FC_cityKod);
                city = new Cities.Cities(drcity);
                cmbCity.Text = city.FCi_name;
            }
            else
            {
                txtbKodClient.Text = cctbl.GetNext("C_kod").ToString();
                this.Text = "הוספת לקוח";
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

        private void cmbCity_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            if (CheckLegal())
            {
                if (status == "Add")
                {
                    cctbl.AddClients(c);
                }
                else
                {
                    cctbl.UpDateClients(c);
                }
                this.Close();
            }
        }

        private void btnAddCitiy_Click(object sender, EventArgs e)
        {
            CitiesAddUpdate cc = new CitiesAddUpdate();
            cc.ShowDialog();
            cmbCity.SelectedIndexChanged -= cmbCity_SelectedIndexChanged;
            cmbCity.DataSource = citiestbl.getalltable();
            cmbCity.DisplayMember = "שם עיר";
            cmbCity.ValueMember = "קוד עיר";
            cmbCity.SelectedIndexChanged += cmbCity_SelectedIndexChanged;
            cmbCity.SelectedIndex = 0;
            DataRow DR = citiestbl.Find("CI_kod", citiestbl.GetNext("CI_kod") - 1);
            cmbCity.Text = DR["CI_name"].ToString();
        }

        private void txtbID_TextChanged(object sender, EventArgs e)
        {
            if (txtbID.BackColor == Color.LightSalmon)
                txtbID.BackColor = Color.White;
        }

        private void txtbLastName_TextChanged(object sender, EventArgs e)
        {
            if (txtbName.BackColor == Color.LightSalmon)
                txtbName.BackColor = Color.White;
        }

        private void txtbAdress_TextChanged(object sender, EventArgs e)
        {
            if (txtbAdress.BackColor == Color.LightSalmon)
                txtbAdress.BackColor = Color.White;
        }

        private void txtbPhone2_TextChanged(object sender, EventArgs e)
        {
            if (txtbPhone2.BackColor == Color.LightSalmon)
                txtbPhone2.BackColor = Color.White;
        }

        private void txtbMail_TextChanged(object sender, EventArgs e)
        {
            if (txtbMail.BackColor == Color.LightSalmon)
                txtbMail.BackColor = Color.White;
        }
    }
}
        
