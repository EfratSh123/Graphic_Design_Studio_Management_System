using EfratShmueliProject.Cities;
using EfratShmueliProject.Clients;
using EfratShmueliProject.OrderDeitals;
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

namespace EfratShmueliProject.KindOrder
{
    public partial class KindOrderShow : Designer
    {
        KindOrderTbl ktbl;
        DataTable tdKatalog;
        public KindOrderShow()
        {
            InitializeComponent();
        }

        private void KindOrderShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "קטלוג";
            ktbl = new KindOrderTbl();
            DGKindOrders.DataSource = ktbl.getalltable();
            tdKatalog = ktbl.getalltable();
        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KindOrderAddUpdate cc = new KindOrderAddUpdate();
            cc.ShowDialog();
            DGKindOrders.DataSource = ktbl.getalltable();
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGKindOrders.SelectedRows.Count > 0)
            {
                KindOrderAddUpdate a = new KindOrderAddUpdate(int.Parse(DGKindOrders.SelectedRows[0].Cells[0].Value.ToString()));
                a.ShowDialog();
                DGKindOrders.DataSource = ktbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. הגדרת 3 נתונים
            OrderDeitalsTbl oD = new OrderDeitalsTbl();
            DataTable dt = oD.GetTable();
            bool d = true;
            // 2. בדיקה האם קיימות הזמנות עם סוג מוצר בקטלוג זה
            if (DGKindOrders.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count && d == true; i++)
                {
                    if (dt.Rows[i]["DO_KindOredrKod"].ToString() == DGKindOrders.SelectedRows[0].Cells[0].Value.ToString())
                        d = false;
                }
                // 3. מה עושים במקרה שקיים לקוח ובמקרה שלא
                if (!d)
                    MessageBox.Show("לא ניתן למחוק מוצר זה מהקטלוג, כיוון שיש פרטים בהזמנות המקושרים למוצר זה");
                else
                {
                    DataRow dr = ktbl.Find("K_kod", DGKindOrders.SelectedRows[0].Cells[0].Value.ToString());
                    ktbl.DeleteKindOrder(new KindOrder(dr));
                    DGKindOrders.DataSource = ktbl.getalltable();
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
                DGKindOrders.DataSource = tdKatalog;
            else
                DGKindOrders.DataSource = Classes.SmartSreach.Search(tdKatalog, txtSearch.Text);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGKindOrders.DataSource = tdKatalog;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            // כשאר העכבר יוצא מתיבת טקסט
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGKindOrders.DataSource = tdKatalog;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGKindOrders.DataSource = Classes.SmartSreach.Search(tdKatalog, s);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }
    }
}
