using EfratShmueliProject.Mittings;
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
    public partial class ReadyOrders : Designer
    {
        OrdersTbl otbl;
        public ReadyOrders()
        {
            InitializeComponent();
        }

        private void ReadyOrders_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            otbl = new OrdersTbl();
            DGOredrs.DataSource = otbl.getReadyOrders();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (DGOredrs.SelectedRows.Count > 0)
            {
                DataRow dr = otbl.Find("O_Kod", DGOredrs.SelectedRows[0].Cells[0].Value.ToString());
                Orders.Orders o = new Orders.Orders(dr);
                o.FO_status = "לא פעיל";
                otbl.UpDateOrder(o);
                PaymentsAddUpdate pay = new PaymentsAddUpdate(o.FO_Kod, "Add");
                pay.ShowDialog();
                DGOredrs.DataSource = otbl.getReadyOrders();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
    }
}
