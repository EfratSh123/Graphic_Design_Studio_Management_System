using EfratShmueliProject.Clients;
using EfratShmueliProject.KindOrder;
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

namespace EfratShmueliProject.cancels
{
    public partial class CancelsShow : Designer
    {
        CancelsTbl catbl;
        DataTable dtCa;
        public CancelsShow()
        {
            InitializeComponent();
        }

        private void CancelsShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "ביטולים";
            catbl = new CancelsTbl();
            DGCancels.DataSource = catbl.getalltable();
            dtCa = catbl.getalltable();
        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelsAddUpDate cc = new CancelsAddUpDate();
            cc.ShowDialog();
            DGCancels.DataSource = catbl.getalltable();
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGCancels.SelectedRows.Count > 0)
            {
                CancelsAddUpDate a = new CancelsAddUpDate(int.Parse(DGCancels.SelectedRows[0].Cells[0].Value.ToString()));
                a.ShowDialog();
                DGCancels.DataSource = catbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CancelsTbl ccc = new CancelsTbl();
            DataTable dt = ccc.GetTable();

            if (DGCancels.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("האם אתה בטוח שברצונך למחוק חופשה זו?", "שים לב!", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                {
                    DataRow dr = catbl.Find("CA_kod", DGCancels.SelectedRows[0].Cells[0].Value.ToString());
                    catbl.DeleteCancels(new Cancels(dr));
                    DGCancels.DataSource = catbl.getalltable();
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
                DGCancels.DataSource = dtCa;
            else
                DGCancels.DataSource = Classes.SmartSreach.Search(dtCa, txtSearch.Text);
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGCancels.DataSource = dtCa;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //כשאר העכבר יוצא מתיבת טקסט
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGCancels.DataSource = dtCa;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGCancels.DataSource = Classes.SmartSreach.Search(dtCa, s);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";

        }
    }
}
