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
    public partial class OrdersNotPayed : Designer
    {
        OrdersTbl otbl;
        public OrdersNotPayed()
        {
            InitializeComponent();
        }

        private void OrdersNotPayed_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            otbl = new OrdersTbl();
            DGOredrs.DataSource = otbl.getReadyOrders();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGOredrs.SelectedRows.Count > 0)
            {
                PaymentsAddUpdate p = new PaymentsAddUpdate(int.Parse(DGOredrs.SelectedRows[0].Cells[0].Value.ToString()), "Add");
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
    }
}
