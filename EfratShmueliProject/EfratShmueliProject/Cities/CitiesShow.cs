using EfratShmueliProject.Clients;
using EfratShmueliProject.Orders;
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

namespace EfratShmueliProject.Cities
{
    public partial class CitiesShow : Designer
    {
        CitiesTbl ctbl;
        public CitiesShow()
        {
            InitializeComponent();
        }

        private void CitiesShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            this.Text = "ערים";
            ctbl = new CitiesTbl();
            DGCities.DataSource = ctbl.getalltable();
        }

        private void DGCities_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CitiesAddUpdate cc = new CitiesAddUpdate();
            cc.ShowDialog();
            DGCities.DataSource = ctbl.getalltable();
        }

        private void עדכוןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGCities.SelectedRows.Count > 0)
            {
                CitiesAddUpdate a = new CitiesAddUpdate(int.Parse(DGCities.SelectedRows[0].Cells[0].Value.ToString()));
                a.ShowDialog();
                DGCities.DataSource = ctbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void מחקToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 1. הגדרת 3 נתונים
            ClientsTbl ccc = new ClientsTbl();
            WorkersTbl www = new WorkersTbl();
            DataTable dt = ccc.GetTable();
            DataTable dt2 = www.GetTable();
            bool d = true;
            // 2. בדיקה האם קיימים לקוחות או עובדים המקושרים לעיר זו
            if (DGCities.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dt.Rows.Count && d == true; i++)
                {
                    if (dt.Rows[i]["C_kod"].ToString() == DGCities.SelectedRows[0].Cells[0].Value.ToString())
                        d = false;
                }
                for (int k = 0; k < dt.Rows.Count && d == true; k++)
                {
                    if (dt2.Rows[k]["W_kod"].ToString() == DGCities.SelectedRows[0].Cells[0].Value.ToString())
                        d = false;
                }
                // 3. מה עושים במקרה שקיים לקוח ובמקרה שלא
                if (!d)
                    MessageBox.Show("לא ניתן למחוק עיר זו כיוון שקיימים לקוחות / עובדים במערכת המקושרים לעיר זו");
                else
                {
                    DataRow dr = ctbl.Find("CI_kod", DGCities.SelectedRows[0].Cells[0].Value.ToString());
                    ctbl.DeleteCity(new Cities(dr));
                    DGCities.DataSource = ctbl.getalltable();
                }
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
    }
}
