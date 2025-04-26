using EfratShmueliProject.cancels;
using EfratShmueliProject.KindOrder;
using EfratShmueliProject.Mittings;
using EfratShmueliProject.Schedule;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace EfratShmueliProject.AllTheUsers
{
    public partial class UserMeeting : UserControl
    {
        string date;
        string hour;
        ViewSchedule sch;
        DataTable dt;
        MittingsTbl mtbl=new MittingsTbl ();


        int codeClient;
        Clients.Clients c;
        int kodOrder;
        Orders.OrdersTbl oTbl = new Orders.OrdersTbl();
        Clients.ClientsTbl cTbl = new Clients.ClientsTbl();
        Orders.Orders o= new Orders.Orders();
        CancelsTbl catbl = new CancelsTbl();
        WorkersTbl Wtbl = new WorkersTbl();
        Workers.Workers wPrincipal = new Workers.Workers();
        bool dd = true;
        public UserMeeting()
        {
            InitializeComponent();
        }
        public UserMeeting(string date, string hour, ViewSchedule sch)
        {
            InitializeComponent();
            this.date = date;
            this.hour = hour;
            this.sch = sch;
            //בדיקה אם יש למנהל ביטול באותו יום
            DataTable dtCancels = catbl.GetTable();
            DataRow data = Wtbl.Find("W_lastName", "מנהל");
            for (int i = 0; i < dtCancels.Rows.Count && dd; i++)
            {
                //אם הביטול של המנהל
                if (dtCancels.Rows[i][1].ToString() == data[0].ToString())
                    //אם הוא בטווח תאריכים של התאריך ביומן
                    if (DateTime.Parse(dtCancels.Rows[i][2].ToString()) <= DateTime.Parse(date)
                        && DateTime.Parse(dtCancels.Rows[i][3].ToString()) >= DateTime.Parse(date))
                    {
                        labelCa.Visible = true;
                        dd = false;
                        break;
                    }
            }
        }
        private void UserMeeting_Load(object sender, EventArgs e)
        {
            this.Enabled = true;
            
            //שאילתה שמביאה את הפגישה לפי זמן ותאריך
            dt = mtbl.getalltableDateHour(hour, date);
            if (dt.Rows.Count > 0 )
            {
                DataRow dr1 = dt.Rows[0];
                Mittings.Mittings m = new Mittings.Mittings(dr1, "shalom:)");
                //מילוי פקדים
                linkLabel2.Visible = false;
                //DataRow dr = oTbl.Find("O_Kod", kodOrder);
                //o = new Orders.Orders(dr);
                //kodOrder = int.Parse(dr["O_Kod"].ToString());
                DataRow drc = cTbl.Find("C_kod", m.FM_clientKod);
                c = new Clients.Clients(drc);
                labelName.Text = drc["C_lastName"].ToString();
                btnMittingDeitals.Visible = true;
                label1.Visible = true;
                labelName.Visible = true;
                dd = false;
            }
            else
            //בודק האם התאריך והשעה עברו- אם כן א"א ללחוץ על קביעת פגישה
            if (DateTime.Parse(date) <= DateTime.Today)
                linkLabel2.Enabled = false;
            if (dd)
                linkLabel2.Visible = true;
            else
                linkLabel2.Visible = false;
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //במצב הוספת פגישה דרך היומן שנפתח בעדכון הזמנה
            if(sch.d == true)
            {
                MittingsAddUpdate c11 = new MittingsAddUpdate(date, hour, sch.kodC);
                c11.ShowDialog();
                sch.DateChange();
            }
            else
            {
                MittingsAddUpdate c4 = new MittingsAddUpdate(date, hour, 0);
                c4.ShowDialog();
                sch.DateChange();
            }
            
        }

        private void btnMittingDeitals_Click(object sender, EventArgs e)
        {
            MittingsAddUpdate m1 = new MittingsAddUpdate(date, hour, 0);
            m1.ShowDialog();
            sch.DateChange();
        }
    }
}
