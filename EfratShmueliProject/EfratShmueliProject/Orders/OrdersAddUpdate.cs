using EfratShmueliProject.AllTheUsers;
using EfratShmueliProject.Cities;
using EfratShmueliProject.Classes;
using EfratShmueliProject.Clients;
using EfratShmueliProject.KindOrder;
using EfratShmueliProject.Mittings;
using EfratShmueliProject.OrderDeitals;
using EfratShmueliProject.Payments;
using EfratShmueliProject.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EfratShmueliProject.Orders
{
    public partial class OrdersAddUpdate : Designer
    {
        DataTable dt;
        MittingsTbl mtbl = new MittingsTbl();
        Orders o = new Orders();
        string status;
        OrdersTbl otbl = new OrdersTbl();
        ClientsTbl ctbl = new ClientsTbl();
        KindOrderTbl ktbl = new KindOrderTbl();
        OrderDeitalsTbl oDtbl = new OrderDeitalsTbl();
        WorkersTbl wtbl = new WorkersTbl();
        cancels.CancelsTbl catbl = new cancels.CancelsTbl();
        string clientName;
        public int mone1 = 0;
        public int mone2 = 0;
        public OrdersAddUpdate()
        {
            InitializeComponent();
            status = "Add";
        }
        public OrdersAddUpdate(int code)
        {
            InitializeComponent();
            status = "UpDate";
            DataRow dro = otbl.Find("O_kod", code);
            o = new Orders(dro);
            dt = oDtbl.GetProductOfOrder(o.FO_Kod);
            FillFrom();
        }
        //בהוספת הזמנה לאחר פגישת הכרות
        public OrdersAddUpdate(string ClientName, int s)
        {
            InitializeComponent();
            status = "AddWithMitting";
            clientName = ClientName;
            //במצב של פתיחת הזמנה בשביל לשלם על הפגישה
            if (s == 0)
            {
                status = "AddForPay";
            }
        }
        public OrdersAddUpdate(int code, string s)
        {
            InitializeComponent();
            status = "Show";
            DataRow dro = otbl.Find("O_kod", code);
            o = new Orders(dro);
            dt = oDtbl.GetProductOfOrder(o.FO_Kod);
            FillFrom();
        }
        public void FillFrom()
        {
            //שינוי שמות לפקדים
            btnAddOrder.Text = "עדכון הזמנה";
            this.Text = "עדכון הזמנה";
            //מילוי פקדים של הזמנה
            txtbKodOrder.Text = o.FO_Kod.ToString();
            dateTimePickerMake.Value = DateTime.Parse(o.FO_dateOfOrder);
            dateTimePickerTarget.Value = DateTime.Parse(o.FO_dateOFEnd);
            txtbNumHoursWorking.Text = o.FO_numWorkHour;
            txtbNumMittings.Text = o.FO_numOfMittings;
            txtbSumToPay.Text = o.FO_amountToPay;
            if (o.FO_status == "בוצע")
                rbStatusOrderFinish.Checked = true;
            else
                rbStatusOrderIn.Checked = true;
            //הצגת מוצרים בהזמנה
            //for (int i = 0; i < dt.Rows.Count; i++)
            //{
            //    OrderDeitals.OrderDeitals od = new OrderDeitals.OrderDeitals(dt.Rows[i]);
            //    DataRow dtp = ktbl.Find("K_kod", od.FDO_KindOredrKod);
            //    KindOrder.KindOrder p = new KindOrder.KindOrder(dtp);
            //    flowLayoutPanel1.Controls.Add(new UserKatalog(od.FDO_kod));
            //}
        }
        private void OrdersAddUpdate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            fillCmbName();
            if (status == "Add" || status == "AddWithMitting" || status == "AddForPay")
            {
                gbGrafic.Enabled = false;
                //תאריך שליחה בעוד 7 ימים
                dateTimePickerMake.MinDate = DateTime.Now;
                dateTimePickerTarget.MinDate = dateTimePickerMake.Value.AddDays(7);
                txtbKodOrder.Text = otbl.GetNext("O_Kod").ToString();
                this.Text = "הוספת הזמנה";
                rbStatusOrderFinish.Visible = false;
                rbStatusOrderIn.Visible = false;
                lblStatusOrder.Visible = false;
            }
            if (status == "UpDate")
            {
                label14.Visible = true;
                btnSchedule.Visible = true;
                this.Text = "עדכון הזמנה";
                DataRow drC = ctbl.Find("C_kod", o.FO_clientKod);
                Clients.Clients c = new Clients.Clients(drC);
                cmbName.Text = c.FC_lastName;
                DataRow dr1 = wtbl.Find("W_kod", o.FO_GraphicArtistKod);
                Workers.Workers w = new Workers.Workers(dr1);
                cmbGrafics.Text = w.FW_lastName.ToString();
            }
            if (status == "Show")
            {
                groupBox2.Visible = false;
                btnTimeMitting.Visible = false;
                gbGrafic.Visible = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Enabled = false;
                groupBox4.Enabled = false;
                rbStatusOrderFinish.Enabled = false;
                rbStatusOrderIn.Enabled = false;
                btnAddClient.Enabled = false;
                btnSchedule.Enabled = false;
                btnAddOrder.Enabled = true;
                btnAddOrder.Text = "סגור";
            }
            if (status == "AddWithMitting" || status == "AddForPay")
            {
                DataRow drC = ctbl.Find("C_lastName", clientName);
                Clients.Clients c = new Clients.Clients(drC);
                cmbName.Text = c.FC_lastName;
                txtbNumMittings.Text = "1";
                DataRow drK = ktbl.Find("K_kod", int.Parse("777"));
                KindOrder.KindOrder kk = new KindOrder.KindOrder(drK);
                txtbSumToPay.Text = (int.Parse(kk.FK_price.ToString()) + int.Parse(txtbSumToPay.Text)).ToString();
            }
            txtbId.Enabled = false;
            txtbPhone.Enabled = false;

            DataTable dt = Dal.GetDisplayTable("SELECT katalog.K_kod, katalog.K_describing, katalog.K_price, katalog.k_timeWorking, katalog.K_picture FROM katalog;");
            DataTable dtOrderDeitals = Dal.GetTable("OrderDetials");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                UserKatalog u = new UserKatalog(int.Parse(dt.Rows[i][0].ToString()), this);
                //----------
                if (dt.Rows[i]["K_kod"].ToString() == "555" || dt.Rows[i]["K_kod"].ToString() == "777")
                    u.Visible = false;
                //במצב עדכון, לסמן מה הזמינו
                if (status == "UpDate" || status == "Show")
                {
                    for (int k = 0; k < dtOrderDeitals.Rows.Count; k++)
                    {
                        if (dtOrderDeitals.Rows[k][1].ToString() == txtbKodOrder.Text && dtOrderDeitals.Rows[k][2].ToString() == u.GetCode().ToString())
                        {
                            u.ChangeCheckedcheckBox1();
                            if (dtOrderDeitals.Rows[k][4].ToString() == "בוצע")
                                u.ChangeCheckedcheckBox2();
                        }
                    }
                }
                flowLayoutPanel1.Controls.Add(u);

                //}
            }
            groupBox2.Visible = false;
            btnTimeMitting.Visible = false;
            if (status == "AddForPay")
            {
                cmbGrafics.Text = "1";
                SaveOrder();
            }
            Checked();
            
        }
        public void Checked()
        {
            mone1 = 0;
            mone2 = 0;
            foreach (UserKatalog u in flowLayoutPanel1.Controls)
            {
                if (u.checkBox1.Checked)
                {
                    if (u.checkBox2.Checked)
                        mone2++;
                    mone1++;
                }
            }
            if (mone1 == mone2)
                rbStatusOrderFinish.Checked = true;
            else
                rbStatusOrderIn.Checked = true;
        }

        public bool CheckLegal()
        {
            errorProviderDateOfEnd.Clear();
            errorProviderKodOredr.Clear();
            errorProviderMittings.Clear();
            errorProviderNumWorking.Clear();
            errorProviderStatus.Clear();
            errorProviderSum.Clear();
            bool degel = true;
            o.FO_Kod = int.Parse(txtbKodOrder.Text);
            o.FO_clientKod = int.Parse(cmbName.SelectedValue.ToString());
            //סטטוס
            if (rbStatusOrderIn.Checked)
                o.FO_status = "בוצע";
            else
                o.FO_status = "בשלבי עבודה";
            //מס שעות עבודה נוספות
            if (txtbNumHoursWorking.Text != "")
            {
                try
                {
                    o.FO_numWorkHour = txtbNumHoursWorking.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderNumWorking.SetError(txtbNumHoursWorking, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txtbNumHoursWorking.BackColor = Color.LightSalmon;
                degel = false;
            }
            //מס פגישות
            if (txtbNumMittings.Text != "")
            {
                try
                {
                    o.FO_numOfMittings = txtbNumMittings.Text;
                }
                catch (Exception ex1)
                {
                    errorProviderMittings.SetError(txtbNumMittings, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txtbNumMittings.BackColor = Color.LightSalmon;
                degel = false;
            }
            if (cmbGrafics.Text == "" && status != "AddForPay")
            {
                degel = false;
                MessageBox.Show("נא בחר גרפיקאית לביצוע ההזמנה");
            }
            return degel;
        }
        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            if (btnAddOrder.Text == "סגור")
                this.Close();
            else
            {
                if (cmbGrafics.Text == "" && status != "AddForPay")
                {
                    MessageBox.Show("נא בחר גרפיקאית לביצוע ההזמנה");
                }

                else
                {
                    if (groupBox2.Visible == false && status != "AddWithMitting" && status != "UpDate")
                        if (MessageBox.Show("האם התקיימה פגישת הכרות לפני ביצוע ההזמנה?", "שים לב!", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                        {
                            o.FO_numOfMittings = o.FO_numOfMittings + 1;
                            groupBox2.Visible = true;
                            btnTimeMitting.Visible = true;
                            cmbHour.SelectedIndex = 0;
                            cmbMoment.SelectedIndex = 0;
                            btnAddOrder.Enabled = false;
                            btnAddOrder.BackColor = Color.LightSkyBlue;
                        }
                        else
                            SaveOrder();
                    else
                        SaveOrder();
                }
            }
        }
        private void SaveOrder()
        {
            if (CheckLegal())
            {
                o.FO_Kod = int.Parse(txtbKodOrder.Text);
                o.FO_clientKod = int.Parse(cmbName.SelectedValue.ToString());
                //סטטוס
                if (!rbStatusOrderIn.Checked)
                    o.FO_status = "בוצע";
                else
                    o.FO_status = "בשלבי עבודה";
                o.FO_dateOfOrder = dateTimePickerMake.Text;
                o.FO_dateOFEnd = dateTimePickerTarget.Text;
                o.FO_numWorkHour = txtbNumHoursWorking.Text;
                o.FO_amountToPay = txtbSumToPay.Text;
                if (groupBox2.Visible == false && status != "AddWithMitting" && status != "UpDate")
                {
                    DataTable dtMittings = mtbl.GetTable();
                    //for (int i = 0; i < dtMittings.Rows.Count; i++)
                    //{
                    //    if (dtMittings.Rows[i][])
                    //}
                }
                else
                    o.FO_numOfMittings = txtbNumMittings.Text;
                //גרפיקאית
                //אם רק משלמים על הפגישה- העובד יהיה המנהל
                if (status == "AddForPay")
                    o.FO_GraphicArtistKod = '1'.ToString();
                else
                {
                    DataRow dr11 = wtbl.Find("W_lastName", cmbGrafics.Text);
                    Workers.Workers w1 = new Workers.Workers(dr11);
                    o.FO_GraphicArtistKod = w1.FW_kod.ToString();
                }

                int[] arr;
                if (status == "Add" || status == "AddForPay" || status == "AddWithMitting")
                {
                    otbl.AddOrder(o);
                    arr = new int[1];
                }
                else
                {
                    otbl.UpDateOrder(o);
                    arr = new int[dt.Rows.Count];
                }
                bool d = true;
                //הוספת הזמנה
                foreach (UserKatalog u in flowLayoutPanel1.Controls)
                {
                    if (u.checkBox1.Checked)
                    {
                        OrderDeitals.OrderDeitals od = new OrderDeitals.OrderDeitals();
                        //הוספת מוצר בהזמנה
                        if (status == "Add" || status == "AddWithMitting")
                            od.FDO_kod = oDtbl.GetNext("DO_kod");
                        else
                        {
                            for (int j = 0; j < dt.Rows.Count; j++)
                            {
                                if (dt.Rows[j][2].ToString() == u.GetCode().ToString())
                                {
                                    od.FDO_kod = int.Parse(dt.Rows[j][0].ToString());
                                    od.dr = dt.Rows[j];
                                    arr[j] = 1;
                                    d = false;
                                    j = dt.Rows.Count;
                                }
                            }
                            if (d)
                                od.FDO_kod = oDtbl.GetNext("DO_kod");
                        }
                        od.FDO_kodOredr = o.FO_Kod;
                        od.FDO_KindOredrKod = u.GetCode();
                        //האם המוצר בוצע
                        if (u.checkBox2.Checked)
                            od.FOD_status = "בוצע";
                        else
                            od.FOD_status = "בשלבי עבודה";
                        if (status == "Add" || d || status == "AddWithMitting" || status == "AddForPay")
                            oDtbl.AddOrderDeitals(od);
                        else
                            oDtbl.UpDateOrderDeitals(od);
                    }
                }
                if (status != "AddForPay")
                {
                    otbl.UpDateOrder(o);
                    MessageBox.Show("ההזמנה נשמרה בהצלחה");

                }
                this.Close();
            }

        }
        private void btnTimeMitting_Click(object sender, EventArgs e)
        {
            DataTable dt = mtbl.getalltableDateHour((cmbHour.Text + ":" + cmbMoment.Text).ToString(), dateTimePickerMitting.Text);
            if (dt.Rows.Count > 0)
            {

                DataRow dr = mtbl.Find("M_kod", dt.Rows[0][0]);
                Mittings.Mittings m = new Mittings.Mittings(dr);
                m.FM_clientKod = int.Parse(cmbName.SelectedValue.ToString());
                mtbl.UpDateMitting(m);
                btnAddOrder.Enabled = true;
                btnAddOrder.BackColor = Color.Gold;
                MessageBox.Show(".עדכון זמן הפגישה בוצע בהצלחה \r\n .כעת יש לשמור את ההזמנה");
            }
            else
                MessageBox.Show("במערכת לא קיימת פגישה בזמן זה \r\n .בדוק שהנתונים שהזנת נכונים");
        }
        public void fillCmbName()
        {
            cmbName.SelectedIndexChanged -= cmbName_SelectedIndexChanged;
            cmbName.DataSource = ctbl.getalltable();
            cmbName.DisplayMember = "שם";
            cmbName.ValueMember = "קוד לקוח";
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            cmbName.SelectedIndex = 1;
        }

        private void cmbName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //נתונים נוספים של הלקוח, משתנה כאשר יש שינוי בתיבת בחירה 
            DataRow drc = ctbl.Find("C_kod", cmbName.SelectedValue);
            Clients.Clients c = new Clients.Clients(drc);
            txtbId.Text = c.FC_id;
            txtbPhone.Text = c.FC_pel;
        }
        //-------------
        public void SumAndTime()
        {
            int sumToPay = 0;
            double timeWorking = 0;
            KindOrder.KindOrder k = new KindOrder.KindOrder();
            DataRow drM = ktbl.Find("K_kod", 555);
            DataRow drT = ktbl.Find("K_kod", 777);
            KindOrder.KindOrder KNumHoursWorking = new KindOrder.KindOrder(drT);
            KindOrder.KindOrder KNumMittings = new KindOrder.KindOrder(drM);
            foreach (UserKatalog u in flowLayoutPanel1.Controls)
            {
                if (u.checkBox1.Checked == true)
                {
                    sumToPay += int.Parse(u.lblPrice.Text.ToString());
                    timeWorking += double.Parse(u.txtbTimeWorking.Text.ToString());
                }
            }
            txtbSumToPay.Text = sumToPay.ToString();
            //חישוב סכום לתשלום
            txtbSumToPay.Text = ((int.Parse(KNumHoursWorking.FK_price) * int.Parse(txtbNumHoursWorking.Text)) + (int.Parse(KNumMittings.FK_price) * int.Parse(txtbNumMittings.Text)) + int.Parse(txtbSumToPay.Text)).ToString();
            lblTextSumTimeWorking.Text = timeWorking.ToString();
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            ClientsAddUpdate c1 = new ClientsAddUpdate();
            c1.ShowDialog();
            cmbName.SelectedIndexChanged -= cmbName_SelectedIndexChanged;
            cmbName.DataSource = ctbl.getalltable();
            cmbName.DisplayMember = "שם";
            cmbName.ValueMember = "קוד לקוח";
            cmbName.SelectedIndexChanged += cmbName_SelectedIndexChanged;
            cmbName.SelectedIndex = 1;
            DataRow DR = ctbl.Find("C_kod", ctbl.GetNext("C_kod") - 1);
            cmbName.Text = DR["C_lastName"].ToString();
        }

        private void dateTimePickerMake_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerTarget.Value = dateTimePickerMake.Value.AddDays(7);
            dateTimePickerTarget.MinDate = dateTimePickerMake.Value.AddDays(7);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbGrafics.Items.Clear();
            DataTable dtCa;
            DataTable dt1 = wtbl.GetTable();
            for (int i = 0; i < dt1.Rows.Count; i++)
            {
                int kod = int.Parse(dt1.Rows[i][0].ToString());
                //אם הקוד של המנהל- שיעקוף עליו
                if (kod != 1)
                {
                    dtCa = catbl.getCaTillTime(kod, dateTimePickerTarget.Value.Date, dateTimePickerMake.Value.Date);
                    DataTable dt2 = otbl.gettt(kod);
                    // חישוב מספר ימים עד להגשת הפרויקט
                    int mone = 0;
                    DateTime d2 = dateTimePickerTarget.Value;
                    DateTime d1 = dateTimePickerMake.Value;
                    while (d1 <= d2)
                    {
                        if (d1.DayOfWeek.ToString() == "Friday" || d1.DayOfWeek.ToString() == "Saturday")
                        {
                            mone--;
                        }
                        mone++;
                        d1 = d1.AddDays(1);
                    }
                    mone -= dtCa.Rows.Count;
                    //מספר שעות העבודה עד הגשת הפרויקט הזה
                    double mis1 = mone * 8 * 60;
                    //זמן עבודה נדרש להזמנה
                    double mis2 = double.Parse(lblTextSumTimeWorking.Text);
                    //זמן לתיקונים- 5 אחוז
                    mis2 = mis2 + mis2 * 0.05;
                    for (int j = 0; j < dt2.Rows.Count; j++)
                    {
                        int mis = int.Parse(dt2.Rows[j][3].ToString());
                        if (mis + mis2 < mis1)
                        {

                            cmbGrafics.Items.Add(dt2.Rows[j][1].ToString());
                        }

                    }
                    cmbGrafics.SelectedIndex = 0;
                }
            }
        }

        private void btnWorkingForGrafics_Click(object sender, EventArgs e)
        {
            DataRow drC = wtbl.Find("W_lastName", cmbGrafics.Text);
            Workers.Workers c = new Workers.Workers(drC);
            WorkingForGrafics ww = new WorkingForGrafics(int.Parse(c.FW_kod.ToString()));
            ww.ShowDialog();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule.ViewSchedule sc = new Schedule.ViewSchedule(o.FO_clientKod);
            sc.ShowDialog();
            DataTable dt1 = mtbl.getAllMeetingsOfOrder(o.FO_clientKod, o.FO_dateOfOrder, o.FO_dateOFEnd);
            txtbNumMittings.Text= dt1.Rows.Count.ToString();
        }

        private void dateTimePickerMake_ValueChanged_1(object sender, EventArgs e)
        {
            dateTimePickerTarget.MinDate = dateTimePickerMake.Value.AddDays(7);
        }
    }
}

