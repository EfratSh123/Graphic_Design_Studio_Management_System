using EfratShmueliProject.Mittings;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EfratShmueliProject
{
    public partial class WorkingForGrafics : Designer
    {
        WorkersTbl wtbl = new WorkersTbl();
        Orders.OrdersTbl ww;
        int KodGrafic;
        string status;
        DataRow drC;
        OrdersTbl otbl = new OrdersTbl();

        public WorkingForGrafics()
        {
            InitializeComponent();
            status = "A";
        }
        public WorkingForGrafics(int graficKod)
        {
            InitializeComponent();
            KodGrafic = graficKod;
            status = "B";
        }

        private void btnShowWorking_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrdersAddUpdate o = new OrdersAddUpdate(int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()), "Show");
                o.ShowDialog();
                int grafickod = int.Parse(comboBox1.SelectedValue.ToString());
                dataGridView1.DataSource = ww.getOrdersForGrafics(grafickod);
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void WorkingForGrafics_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "עבודות לגרפיקאיות";
            ww = new OrdersTbl();
            //dataGridView1.DataSource = ww.getalltableOrderByDate();
            FillCmbWorkers();
            //במצב פתיחה דרך טופס ראשי
            if(status == "A")
            {
                DataTable dt = wtbl.GetTable();
                KodGrafic = int.Parse(dt.Rows[0][0].ToString());
            }
            drC = wtbl.Find("W_kod", KodGrafic);
            Workers.Workers c = new Workers.Workers(drC);
            comboBox1.Text = c.FW_lastName;
            //dataGridView1.DataSource = ww.getOrdersForGrafics(KodGrafic);
            //הצגת משך זמן עבודה
            string time = "0";
            DataTable dtt = otbl.gettt(int.Parse(comboBox1.SelectedValue.ToString()));
            if (dtt.Rows.Count > 0)
            {
                time = dtt.Rows[0][3].ToString();
                textBox1.Text = time;
            }
            else
                textBox1.Text = "0";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int grafickod = int.Parse(comboBox1.SelectedValue.ToString());
            dataGridView1.DataSource = ww.getOrdersForGrafics(grafickod);
            //הצגת משך זמן עבודה
            string time = "0";
            DataTable dtt = otbl.gettt(int.Parse(comboBox1.SelectedValue.ToString()));
            if (dtt.Rows.Count > 0)
            {
                time = dtt.Rows[0][3].ToString();
                textBox1.Text = time;
            }
            else
                textBox1.Text = "0";
            

        }
        public void FillCmbWorkers()
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = wtbl.GetTable();
            comboBox1.DisplayMember = "W_lastName";
            comboBox1.ValueMember = "W_kod";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 1;
        }
    }
}
