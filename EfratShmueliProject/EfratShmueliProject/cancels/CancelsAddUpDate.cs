using EfratShmueliProject.Cities;
using EfratShmueliProject.KindOrder;
using EfratShmueliProject.Orders;
using EfratShmueliProject.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.cancels
{
    public partial class CancelsAddUpDate : Designer
    {
        string status;
        WorkersTbl wtbl = new WorkersTbl();
        CancelsTbl caTbl = new CancelsTbl();
        Cancels ca;
        OrdersTbl otbl = new OrdersTbl();
        Workers.Workers worker;
        public CancelsAddUpDate()
        {
            InitializeComponent();
            status = "Add";
            ca = new Cancels();
        }
        public CancelsAddUpDate(int CA_kod)
        {
            InitializeComponent();
            status = "UpDate";
            DataRow dr = caTbl.Find("CA_kod", CA_kod);
            ca = new Cancels(dr);
            FillForm();
        }
        public void FillForm()
        {
            txtKodCancel.Text = ca.FCA_kod.ToString();
            cmbName.ValueMember = ca.FCA_workerKod.ToString();
            dateTimePicker1.Text = ca.FCA_dateOfStart.ToString();
            if (ca.FCA_status == "בקשה")
            {
                rbStatusWate.Checked = true;
                rbStatusNo.Checked = false;
                rbStatusYes.Checked = false;
            }
            if (ca.FCA_status == "מאושר")
            {
                rbStatusWate.Checked = false;
                rbStatusNo.Checked = false;
                rbStatusYes.Checked = true;
            }
            if (ca.FCA_status == "לא מאושר")
            {
                rbStatusWate.Checked = false;
                rbStatusNo.Checked = true;
                rbStatusYes.Checked = false;
            }
            AddKindOrder.Text = "עדכון";

        }
        private void CancelsAddUpDate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fillCmbName();
            if (status == "Add")
            {
                dateTimePicker1.MinDate = DateTime.Today;
                dateTimePicker2.MinDate = dateTimePicker1.Value;
                rbStatusNo.Visible = false;
                rbStatusWate.Visible = false;
                rbStatusYes.Visible = false;
                lblStatus.Visible = false;
                dateTimePicker1.Value = DateTime.Now;
                dateTimePicker2.Value = DateTime.Now;
                this.Text = "הוספת ביטול";
                txtKodCancel.Text = caTbl.GetNext("CA_kod").ToString();
                cmbName.SelectedIndex = 0;
            }
            else
            {
                dataGridView1.Visible = true;
                this.Text = "עדכון ביטול";
                DataRow drC = wtbl.Find("W_kod", ca.FCA_workerKod);
                Workers.Workers w = new Workers.Workers(drC);
                cmbName.Text = w.FW_lastName;
                dateTimePicker1.Text = ca.FCA_dateOfStart.ToString();
                dateTimePicker2.Text = ca.FCA_dateOfEnd.ToString();
                dataGridView1.DataSource = otbl.gettt(int.Parse(cmbName.SelectedValue.ToString()));
            }
        }
        public bool CheckLegal()
        {
            errorProviderWorkerKod.Clear();
            bool degel = true;
            ca.FCA_kod = int.Parse(txtKodCancel.Text);
            ca.FCA_workerKod = int.Parse(cmbName.SelectedValue.ToString());
            //סטטוס
            if (rbStatusYes.Checked)
                ca.FCA_status = "מאושר";
            else
            {
                if (rbStatusNo.Checked)
                    ca.FCA_status = "לא מאושר";
                else
                    ca.FCA_status = "בקשה";
            }
            try
            {
                ca.FCA_dateOfStart = dateTimePicker1.Text;
            }
            catch (Exception ex1)
            {
                errorProviderDATE.SetError(dateTimePicker1, ex1.Message);
                degel = false;
            }
            try
            {
                ca.FCA_dateOfEnd = dateTimePicker2.Text;
            }
            catch (Exception ex1)
            {
                errorProviderDATE.SetError(dateTimePicker2, ex1.Message);
                degel = false;
            }

            return degel;
        }

        private void AddKindOrder_Click(object sender, EventArgs e)
        {
            if (CheckLegal())
            {
                if (status == "Add")
                {
                    caTbl.AddCancel(ca);
                }
                else
                {
                    caTbl.UpDateCancel(ca);
                }
                this.Close();
            }
        }
        public void fillCmbName()
        {
            cmbName.SelectedIndexChanged -= cmbID_SelectedIndexChanged;
            cmbName.DataSource = wtbl.getalltable();
            cmbName.DisplayMember = "שם";
            cmbName.ValueMember = "קוד עובד";
            cmbName.SelectedIndexChanged += cmbID_SelectedIndexChanged;
            cmbName.SelectedIndex = 1;
        }
        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //נתונים נוספים של עובד, משתנה כאשר יש שינוי בתיבת בחירת ת.ז 
            DataRow drc = wtbl.Find("W_kod", cmbName.SelectedValue.ToString());
            Workers.Workers w = new Workers.Workers(drc);
            txtbWorkerPhone.Text = w.FW_phone;
            dataGridView1.DataSource = otbl.gettt(int.Parse(cmbName.SelectedValue.ToString()));
        }

        private void btnWorkingForGrafics_Click(object sender, EventArgs e)
        {
            DataRow drC = wtbl.Find("W_lastName", cmbName.Text);
            Workers.Workers c = new Workers.Workers(drC);
            WorkingForGrafics ww = new WorkingForGrafics(int.Parse(c.FW_kod.ToString()));
            ww.ShowDialog();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;

        }
    }
}
