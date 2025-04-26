using EfratShmueliProject.cancels;
using EfratShmueliProject.Cities;
using EfratShmueliProject.Clients;
using EfratShmueliProject.KindOrder;
using EfratShmueliProject.Mittings;
using EfratShmueliProject.OrderDeitals;
using EfratShmueliProject.Orders;
using EfratShmueliProject.Payments;
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

namespace EfratShmueliProject
{
    public partial class Form1 : Form
    {
        string mishtamesh;
        public Form1(string mishtamesh)
        {
            InitializeComponent();
            this.mishtamesh = mishtamesh;
        }
        
        private void btncities_Click(object sender, EventArgs e)
        {
            CitiesShow c1 = new CitiesShow();
            c1.ShowDialog();
        }

        private void btnclients_Click(object sender, EventArgs e)
        {
            ClientsShow c2 = new ClientsShow();
            c2.ShowDialog();
        }

        private void btnkindorder_Click(object sender, EventArgs e)
        {
            KindOrderShow c3 = new KindOrderShow();
            c3.ShowDialog();
        }

        private void btnmittings_Click(object sender, EventArgs e)
        {
            MittingsShow c4 = new MittingsShow();
            c4.ShowDialog();
        }

        private void btnorders_Click(object sender, EventArgs e)
        {
            OrdersShow c5 = new OrdersShow();
            c5.ShowDialog();
        }

        private void btnpayments_Click(object sender, EventArgs e)
        {
            PaymentsShow c6 = new PaymentsShow();
            c6.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (mishtamesh == "Pricipal")
            {
                btnCancels.Enabled = true;
                btnCancelsForOK.Enabled = true;
                btnkindorder.Enabled = true;
                btnmittings.Enabled = true;
                btnMittingsOfToday.Enabled = true;
                btnOrdersNotPayed.Enabled = true;
                btnReadyOrders.Enabled = true;
                btnWorkers.Enabled = true;
                btnWorkingForGrafics.Enabled = true;
                //הזמנות
                button1.Enabled = true;
                //לקוחות
                button3.Enabled = true;
                //יומן
                button4.Enabled = true;
                //button5.Enabled = true;
                button2.BackColor = Color.LightGray;
            }
            else
                if (mishtamesh == "secretary")
                {
                    btnCancels.Enabled = true;
                    btnCancelsForOK.BackColor = Color.LightGray;
                    btnkindorder.Enabled = true;
                    btnmittings.Enabled = true;
                    btnMittingsOfToday.Enabled = true;
                    btnOrdersNotPayed.Enabled = true;
                    btnReadyOrders.Enabled = true;
                    btnWorkers.Enabled = true;
                    btnWorkingForGrafics.Enabled = true;
                    //תשלומים
                    button2.Enabled = true;
                    //הזמנות
                    button1.Enabled = true;
                    //לקוחות
                    button3.Enabled = true;
                    //יומן
                    button4.Enabled = true;
                }
                else
                {
                btnCancels.Enabled = true;
                btnCancelsForOK.BackColor = Color.LightGray;
                btnmittings.BackColor = Color.LightGray;
                btnMittingsOfToday.BackColor = Color.LightGray;
                btnOrdersNotPayed.BackColor = Color.LightGray;
                btnReadyOrders.BackColor = Color.LightGray;
                btnWorkers.BackColor = Color.LightGray;
                btnWorkingForGrafics.Enabled = true;
                //תשלומים
                button2.BackColor = Color.LightGray;
                //הזמנות
                button1.Enabled = true;
                //לקוחות
                button3.BackColor = Color.LightGray;
                //יומן
                button4.BackColor = Color.LightGray;

                btnCancels.Enabled = true;
                btnkindorder.Enabled = true;
                btnWorkingForGrafics.Enabled = true;
                    //הזמנות
                    button1.Enabled = true;
                }
            this.Text = "דף הבית";
            CenterToScreen();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            ViewSchedule ss = new ViewSchedule();
            ss.ShowDialog();
        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            WorkersShow c7 = new WorkersShow();
            c7.ShowDialog();
        }

        private void btnOrdetDeitals_Click(object sender, EventArgs e)
        {
            OrderDeitalsShow c8 = new OrderDeitalsShow();
            c8.ShowDialog();
        }

        private void btnCancels_Click(object sender, EventArgs e)
        {
            CancelsShow c9 = new CancelsShow();
            c9.ShowDialog();
        }

        private void btnWorkingForGrafics_Click(object sender, EventArgs e)
        {
            WorkingForGrafics w1 = new WorkingForGrafics();
            w1.ShowDialog();
        }

        private void btnCancelsForOK_Click(object sender, EventArgs e)
        {
            CancelsForOK cc = new CancelsForOK();
            cc.ShowDialog();
        }

        private void btnMittingsOfToday_Click(object sender, EventArgs e)
        {
            MittingsForToday c1 = new MittingsForToday();
            c1.ShowDialog();
        }

        private void btnReadyOrders_Click(object sender, EventArgs e)
        {
            ReadyOrders rd = new ReadyOrders();
            rd.ShowDialog();
        }

        private void btnOrdersNotPayed_Click(object sender, EventArgs e)
        {
            OrdersNotPayed r = new OrdersNotPayed();
            r.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            OrderDeitalsShow o = new OrderDeitalsShow(); 
            o.ShowDialog(); 
        }
    }
}
