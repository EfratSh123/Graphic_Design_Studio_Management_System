using EfratShmueliProject.Mittings;
using EfratShmueliProject.OrderDeitals;
using EfratShmueliProject.Orders;
using EfratShmueliProject.Payments;
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
    public partial class MittingsForToday : Designer
    {
        MittingsTbl ptbl;
        OrdersTbl otbl = new OrdersTbl();
        public MittingsForToday()
        {
            InitializeComponent();
        }

        private void MittingsForToday_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            ptbl = new MittingsTbl();
            dataGridView1.DataSource = ptbl.getMittingToday();
        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrdersAddUpdate o = new OrdersAddUpdate(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), int.Parse("0"));
                o.ShowDialog();
                OrdersTbl ootbl = new OrdersTbl();
                DataRow dr = ootbl.Find("O_Kod", o.txtbKodOrder.Text.ToString());
                Orders.Orders oo = new Orders.Orders(dr);
                PaymentsAddUpdate p = new PaymentsAddUpdate(oo.FO_Kod, "Add");
                p.ShowDialog();
                this.Close();
                PaymentsShow pShow = new PaymentsShow();
                pShow.ShowDialog();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void לפתיחתהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrdersAddUpdate o = new OrdersAddUpdate(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), int.Parse("1"));
                o.ShowDialog();
                dataGridView1.DataSource = ptbl.getMittingToday();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrdersAddUpdate o = new OrdersAddUpdate(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), int.Parse("0"));
                o.ShowDialog();
                OrdersTbl ootbl = new OrdersTbl();
                DataRow dr = ootbl.Find("O_Kod", o.txtbKodOrder.Text.ToString());
                Orders.Orders oo = new Orders.Orders(dr);
                PaymentsAddUpdate p = new PaymentsAddUpdate(oo.FO_Kod, "Add");
                p.ShowDialog();
                this.Close();
                PaymentsShow pShow = new PaymentsShow();
                pShow.ShowDialog();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                OrdersAddUpdate o = new OrdersAddUpdate(dataGridView1.SelectedRows[0].Cells[4].Value.ToString(), int.Parse("1"));
                o.ShowDialog();
                OrdersShow OShow = new OrdersShow();
                OShow.ShowDialog();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
    }
}
