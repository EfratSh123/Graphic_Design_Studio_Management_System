using EfratShmueliProject.Cities;
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

namespace EfratShmueliProject.Clients
{
    public partial class ClientsShow : Designer
    {
        ClientsTbl cltbl;
        DataTable dtClient;
        public ClientsShow()
        {
            InitializeComponent();
        }

        private void ClientsShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "לקוחות";

            cltbl = new ClientsTbl();
            DGClients.DataSource = cltbl.getalltable();
            dtClient = cltbl.getalltable();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClientsAddUpdate cc = new ClientsAddUpdate();
            cc.ShowDialog();
            DGClients.DataSource = cltbl.getalltable();
        }

        private void menuStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGClients.SelectedRows.Count > 0)
            {
                ClientsAddUpdate a = new ClientsAddUpdate(DGClients.SelectedRows[0].Cells[1].Value.ToString());
                a.ShowDialog();
                DGClients.DataSource = cltbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGClients.DataSource = dtClient;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                DGClients.DataSource = dtClient;
            else
                DGClients.DataSource = Classes.SmartSreach.Search(dtClient, txtSearch.Text);
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //כשאר העכבר יוצא מתיבת טקסט
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGClients.DataSource = dtClient;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGClients.DataSource = Classes.SmartSreach.Search(dtClient, s);
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
            if (DGClients.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count && d == true; i++)
                {
                    if (dt.Rows[i]["O_clientKod"].ToString() == DGClients.SelectedRows[0].Cells[0].Value.ToString())
                        d = false;
                }
                // 3. מה עושים במקרה שקיים לקוח ובמקרה שלא
                if (!d)
                    MessageBox.Show("לא ניתן למחוק לקוח זה, כיוון שקיימת במערכת הזמנה פעילה על שמו");
                else
                {
                    DataRow dr = cltbl.Find("C_kod", DGClients.SelectedRows[0].Cells[0].Value.ToString());
                    cltbl.DeleteClient(new Clients(dr));
                    DGClients.DataSource = cltbl.getalltable();
                }
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
    }
}
