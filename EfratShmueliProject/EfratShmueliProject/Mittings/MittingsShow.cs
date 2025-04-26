using EfratShmueliProject.cancels;
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

namespace EfratShmueliProject.Mittings
{
    public partial class MittingsShow : Designer
    {
        MittingsTbl mtbl;
        DataTable dt;
        public MittingsShow()
        {
            InitializeComponent();
        }

        private void MittingsShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "פגישות";
            mtbl = new MittingsTbl();
            DGMittings.DataSource = mtbl.getalltable();
            dt = mtbl.getalltable();

        }

        //private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    MittingsAddUpdate cc = new MittingsAddUpdate();
        //    cc.ShowDialog();
        //    DGMittings.DataSource = mtbl.getalltable();
        //}

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGMittings.SelectedRows.Count > 0)
            {
                MittingsAddUpdate m = new MittingsAddUpdate(int.Parse(DGMittings.SelectedRows[0].Cells[0].Value.ToString()));
                m.ShowDialog();
                DGMittings.DataSource = mtbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        //private void עדכןסטטוספגישהToolStripMenuItem_Click(object sender, EventArgs e)
        //{
            
        //    if (DGMittings.SelectedRows.Count > 0)
        //    {
        //        MittingsTbl mittbl = new MittingsTbl();
        //        DataTable dt = mittbl.GetTable();
        //        DataRow dr = mtbl.Find("M_kod", DGMittings.SelectedRows[0].Cells[0].Value.ToString());
        //        Mittings m = new Mittings(dr);
        //        m.FM_status = "בוצעה";
        //        mtbl.UpDateMitting(m);
        //        DGMittings.DataSource = mtbl.getalltable();

        //    }
        //    else
        //    {
        //        MessageBox.Show("עליך לבחור שורה");
        //    }
        //}
        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. הגדרת 3 נתונים
            OrdersTbl o = new OrdersTbl();
            DataTable dt = o.GetTable();
            ClientsTbl ctbl = new ClientsTbl();
            DataRow dtClient;
            bool d = true;

            if (DGMittings.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count && d == true; i++)
                {
                    dtClient = ctbl.Find("C_lastName", DGMittings.SelectedRows[0].Cells[4].Value.ToString());
                    if (dt.Rows[i]["O_clientKod"].ToString() == dtClient[0].ToString())
                        d = false;
                }
                // 3. מה עושים במקרה שקיים לקוח ובמקרה שלא
                if (!d)
                    MessageBox.Show("לא ניתן למחוק פגישה זו, כיוון שיש ללקןח זה הזמנה פתוחה");
                else
                {
                    DataRow dr = mtbl.Find("M_kod", DGMittings.SelectedRows[0].Cells[0].Value.ToString());
                    mtbl.DeleteMitting(new Mittings(dr));
                    DGMittings.DataSource = mtbl.getalltable();
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
                DGMittings.DataSource = dt;
            else
                DGMittings.DataSource = Classes.SmartSreach.Search(dt, txtSearch.Text);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGMittings.DataSource = dt;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGMittings.DataSource = dt;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGMittings.DataSource = Classes.SmartSreach.Search(dt, s);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";

        }
    }
}
