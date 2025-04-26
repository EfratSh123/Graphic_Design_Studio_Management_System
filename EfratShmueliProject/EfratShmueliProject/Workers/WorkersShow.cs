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

namespace EfratShmueliProject.Workers
{
    public partial class WorkersShow : Designer
    {
        WorkersTbl wtbl;
        DataTable dtWorker;
        public WorkersShow()
        {
            InitializeComponent();
        }
        private void WorkersShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "עובדים";
            wtbl = new WorkersTbl();
            DGWorkers.DataSource = wtbl.getalltable();
            dtWorker = wtbl.getalltable();
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void הוסףToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            WorkersAddUpDate cc = new WorkersAddUpDate();
            cc.ShowDialog();
            DGWorkers.DataSource = wtbl.getalltable();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void עדכןToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            if (DGWorkers.SelectedRows.Count > 0)
            {
                WorkersAddUpDate a = new WorkersAddUpDate(int.Parse(DGWorkers.SelectedRows[0].Cells[0].Value.ToString()));
                a.ShowDialog();
                DGWorkers.DataSource = wtbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGWorkers.DataSource = dtWorker;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                DGWorkers.DataSource = dtWorker;
            else
                DGWorkers.DataSource = Classes.SmartSreach.Search(dtWorker, txtSearch.Text);
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //כשאר העכבר יוצא מתיבת טקסט
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGWorkers.DataSource = dtWorker;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGWorkers.DataSource = Classes.SmartSreach.Search(dtWorker, s);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";

        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. הגדרת 3 נתונים
            OrdersTbl ooo = new OrdersTbl();
            DataTable dt = ooo.GetTable();
            bool d = true;
            // 2. בדיקה האם קיימת הזמנה פעילה ללקוח זה
            if (DGWorkers.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count && d == true; i++)
                {
                    if (dt.Rows[i]["O_GraphicArtistKod"].ToString() == DGWorkers.SelectedRows[0].Cells[0].Value.ToString() && dt.Rows[i]["O_status"].ToString() == "בשלבי עבודה")
                        d = false;
                }
                // 3. מה עושים במקרה שקיים לקוח ובמקרה שלא
                if (!d)
                    MessageBox.Show("לא ניתן למחוק עובד זה, כיון שקיימת הזמנה שצריך לעצב והיא לא בוצעה.");
                else
                {
                    DataRow dr = wtbl.Find("W_kod", DGWorkers.SelectedRows[0].Cells[0].Value.ToString());
                    wtbl.DeleteWorkers(new Workers(dr));
                    DGWorkers.DataSource = wtbl.getalltable();
                }
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
    }
}
