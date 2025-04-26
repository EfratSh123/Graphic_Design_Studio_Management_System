using EfratShmueliProject.Clients;
using EfratShmueliProject.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.Mittings
{
    public partial class MittingsAddUpdate : Designer
    {
        string status;
        ClientsTbl ctbl = new ClientsTbl();
        Mittings m = new Mittings ();
        MittingsTbl mbb = new MittingsTbl();
        DataRow drr;
        OrdersTbl otbl = new OrdersTbl(); 
        string date;
        //קוד לקוח- אם קבעו את הפגישה דרך היומן דרך עדכון הזמנה
        int kodC; 
        public MittingsAddUpdate()
        {
            InitializeComponent();
            status = "Add";
        }
        public MittingsAddUpdate(int Mittingkod)
        {
            InitializeComponent();
            status = "Update";
            DataRow dr = mbb.Find("M_kod", Mittingkod);
            m = new Mittings(dr);
            FillForm();
        }
        public MittingsAddUpdate(string date, string hour,int  kodClient)
        {
            InitializeComponent();
            status = "Update";
            kodC = kodClient;
            this.date = date;
            dateTimePickerMitting.Value = DateTime.Parse(date);
            string[] str1 = hour.Split(':');
            cmbHour.Text = str1[0];
            cmbMoment.Text = str1[1];
            DataTable dt = mbb.getalltableDateHour(hour, date);
            //במצב של הצגת פרטי פגישה קיימת דרך היומן
            if(dt.Rows.Count > 0)
            {
                DataRow dr1 = mbb.Find("M_kod", dt.Rows[0][0]);
                m = new Mittings(dr1);
                FillForm();
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                btnAddMitting.Text = "סגור";
            }
            //במצב של קביעת פגישה חדשה דרך היומן
            else
            {
                m = new Mittings(date, hour);
                status = "AddFromSchedule";
            }
            //הצגת פרטי פגישה שהיתה דרך היומן
            if (DateTime.Parse(date) < DateTime.Today)
            {
                btnAddMitting.Text = "סגור";
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
            }
        }
        public bool CheckLegal()
        {
            errorProviderDate.Clear();
            errorProviderHour.Clear();
            errorProviderId.Clear();
            errorProviderName.Clear();
            errorProviderPhone.Clear();
            errorProviderStatus.Clear();
            bool degel = true;
            m.FM_kod = int.Parse(txtbkodMitting.Text.ToString());
            m.FM_clientKod = int.Parse(cmbID.SelectedValue.ToString());
            //סטטוס
            if (rbStatusMittingYes.Checked)
                m.FM_status = "בוצע";
            else
                m.FM_status = "לא בוצע";

            //תאריך 
            if (dateTimePickerMitting.Value.DayOfWeek.ToString() == "Saturday" || dateTimePickerMitting.Value.DayOfWeek.ToString() == "Friday")
            {
                degel = false;
                label5.Visible = true;
            }
            else
            {
                try
                {
                    m.FM_date = dateTimePickerMitting.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderDate.SetError(dateTimePickerMitting, ex1.Message);
                    degel = false;
                }
            }
                
            //שעה
            if (cmbMoment.Text.ToString() == "00" || cmbMoment.Text.ToString() == "30")
            {
                if (cmbHour.Text.ToString() == "08" || cmbHour.Text.ToString() == "09" || cmbHour.Text.ToString() == "10" || cmbHour.Text.ToString() == "11" || cmbHour.Text.ToString() == "12" || cmbHour.Text.ToString() == "13" || cmbHour.Text.ToString() == "14")
                {
                    try
                    {
                        m.FM_hour = cmbHour.Text.ToString() + ":" + cmbMoment.Text.ToString();
                    }
                    catch (Exception ex1)
                    {
                        errorProviderHour.SetError(cmbHour, ex1.Message);
                        degel = false;
                    }
                }
                else
                    cmbHour.BackColor = Color.LightSalmon;
            }
            else
            {
                cmbMoment.BackColor = Color.LightSalmon;
                degel = false;
            }

            return degel;
        }
        public void FillForm()
        {
            Clients.Clients cl;
            dateTimePickerMitting.Value = DateTime.Parse(m.FM_date);
            txtbkodMitting.Text = m.FM_kod.ToString();
            cmbHour.Text = m.FM_hour.Substring(0,2);
            cmbMoment.Text = m.FM_hour.Substring(3, 2);

            //שמירת שם לקוח (ולא ת.ז), וגם טלפון

            //שמירת שורה של פרטי הלקוח לפי הקוד שלו בפגישה
            drr = ctbl.Find("C_kod", m.FM_clientKod);
            //שמירת פרטי לקוח בתוך עצם מסוג לקוח
            cl = new Clients.Clients(drr);

            //לתקן- תעודת זהות בחורה לפי נתוני לקוח
            cmbID.SelectedValue = cl.FC_id;
            txtbClientName.Text = cl.FC_lastName;
            txtbClientPhone.Text = cl.FC_pel.ToString();
            if (cl.FC_pel != "")
            {
                txtbClientPhone.Text = cl.FC_pel;
            }

            //סטטוס פגישה
            if (m.FM_status == "בוצעה")
            {
                rbStatusMittingYes.Checked = true;
            }
            else
            {
                rbStatusMittingNo.Checked = true;
            }
                btnAddMitting.Text = "עדכן";
                this.Text = "עדכון פגישה";
        }
        private void MittingsAddUpdate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fillCmbID();
            //במצב קביעת פגישה דרך היומן דרך עדכון הזמנה
            if(kodC != 0)
            {
                cmbID.SelectedValue = kodC;
            }
            if (status == "Add")
            {
                dateTimePickerMitting.Value = DateTime.Now;
                dateTimePickerMitting.MinDate = DateTime.Now;
                txtbkodMitting.Text = mbb.GetNext("M_kod").ToString();
                this.Text = "הוספת פגישה";
                rbStatusMittingNo.Visible = false;
                rbStatusMittingYes.Visible = false;
                lblStatusMitting.Visible = false;
                cmbHour.SelectedIndex = 1;
                cmbMoment.SelectedIndex = 1;
            }
            if (status == "AddFromSchedule")
            {
                dateTimePickerMitting.MinDate = DateTime.Now;
                //dateTimePickerMitting.Value = DateTime.Now;
                txtbkodMitting.Text = mbb.GetNext("M_kod").ToString();
                this.Text = "הוספת פגישה";
                rbStatusMittingNo.Visible = false;
                rbStatusMittingYes.Visible = false;
                lblStatusMitting.Visible = false;
                //cmbHour.SelectedIndex = 1;
                //cmbMoment.SelectedIndex = 1;
                groupBox1.Enabled = false;
            }
            if (status == "Update")
            {
                this.Text = "עדכון פגישה";
                DataRow drC = ctbl.Find("C_kod", m.FM_clientKod);
                Clients.Clients c = new Clients.Clients(drC);
                cmbID.Text = c.FC_id;
            }
            txtbClientName.Enabled = false;
            txtbClientPhone.Enabled = false;
            if (btnAddMitting.Text == "סגור")
            {
                this.Text = "הצגת פרטי פגישה";
                rbStatusMittingNo.Enabled = false;
                rbStatusMittingYes.Enabled = false;
            }
        }

        private void AddMitting_Click(object sender, EventArgs e)
        {
            if (btnAddMitting.Text == "סגור")
            {
                this.Close();
            }
            else
            {
                if (CheckLegal())
                {
                    if (status == "Add" || status == "AddFromSchedule")
                    {
                        mbb.AddMitting(m);
                        //לעדכן בהזמנה עוד פגישה
                        DataRow drr = otbl.Find("O_clientKod", m.FM_clientKod);
                        Orders.Orders o = new Orders.Orders(drr);
                        o.FO_numOfMittings = o.FO_numOfMittings + 1;
                        otbl.UpDateOrder(o);
                    }
                    else
                    {
                        mbb.UpDateMitting(m);
                    }
                    this.Close();
                }
            }
            
        }

        private void cmbID_SelectedIndexChanged(object sender, EventArgs e)
        {
            //נתונים נוספים של הלקוח, משתנה כאשר יש שינוי בתיבת בחירת ת.ז 
            DataRow drc = ctbl.Find("C_kod", cmbID.SelectedValue.ToString());
            Clients.Clients c = new Clients.Clients(drc);
            txtbClientName.Text = c.FC_lastName;
            txtbClientPhone.Text = c.FC_pel;
        }
        public void fillCmbID()
        {
            cmbID.SelectedIndexChanged -= cmbID_SelectedIndexChanged;
            cmbID.DataSource = ctbl.GetTable();
            cmbID.DisplayMember = "C_id";
            cmbID.ValueMember = "C_kod";
            cmbID.SelectedIndexChanged += cmbID_SelectedIndexChanged;
            cmbID.SelectedIndex = 1;
        }

        private void cmbMoment_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbClientName_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientsAddUpdate c1 = new ClientsAddUpdate();
            c1.ShowDialog();
            cmbID.SelectedIndexChanged -= cmbID_SelectedIndexChanged;
            cmbID.DataSource = ctbl.getalltable();
            cmbID.DisplayMember = "תעודת זהות";
            cmbID.ValueMember = "קוד לקוח";
            cmbID.SelectedIndexChanged += cmbID_SelectedIndexChanged;
            cmbID.SelectedIndex = 1;
            DataRow DR = ctbl.Find("C_kod", ctbl.GetNext("C_kod") - 1);
            cmbID.Text = DR["C_id"].ToString();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void lblStatusMitting_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePickerMitting_ValueChanged(object sender, EventArgs e)
        {
            label5.Visible = false;
        }
    }
}
