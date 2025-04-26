using EfratShmueliProject.Clients;
using EfratShmueliProject.Orders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.Payments
{
    public partial class PaymentsShow : Designer
    {
        PaymentsTbl ptbl;
        DataTable dtClient;

        public PaymentsShow()
        {
            InitializeComponent();
        }

        private void PaymentsShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "תשלומים";
            ptbl = new PaymentsTbl();
            DGPayments.DataSource = ptbl.getalltable();
            dtClient = ptbl.getalltable();

        }

        //private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    PaymentsAddUpdate cc = new PaymentsAddUpdate(85, "Add");
        //    cc.ShowDialog();
        //    DGPayments.DataSource = ptbl.getalltable();
        //}

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGPayments.SelectedRows.Count > 0)
            {
                PaymentsAddUpdate pa = new PaymentsAddUpdate(int.Parse(DGPayments.SelectedRows[0].Cells[1].Value.ToString()), "Update");
                pa.ShowDialog();
                DGPayments.DataSource = ptbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. הגדרת 3 נתונים
            PaymentsTbl ooo = new PaymentsTbl();
            DataTable dt = ooo.GetTable();
            bool d = true;
            // 2.  בדיקה האם קיימת ההזמנה בוצעה 
            if (DGPayments.SelectedRows.Count > 0)
            {
                if (DGPayments.SelectedRows[0].Cells[10].Value.ToString() == "לא שולם")
                    MessageBox.Show(".לא ניתן למחוק תשלום זה כיון שהיא אינו שולם");
                else
                {
                    DataRow dr = ptbl.Find("P_kod", DGPayments.SelectedRows[0].Cells[0].Value.ToString());
                    ptbl.DeletePayments(new Payments(dr));
                    DGPayments.DataSource = ptbl.getalltable();
                }
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                DGPayments.DataSource = dtClient;
            else
                DGPayments.DataSource = Classes.SmartSreach.Search(dtClient, txtSearch.Text);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGPayments.DataSource = dtClient;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //כשאר העכבר יוצא מתיבת טקסט
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGPayments.DataSource = dtClient;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGPayments.DataSource = Classes.SmartSreach.Search(dtClient, s);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";

        }
    }
}
