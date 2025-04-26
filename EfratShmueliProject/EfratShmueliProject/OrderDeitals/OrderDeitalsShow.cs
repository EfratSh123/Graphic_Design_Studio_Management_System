using EfratShmueliProject.KindOrder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.OrderDeitals
{
    public partial class OrderDeitalsShow : Designer
    {
        OrderDeitalsTbl ctbl;
        public OrderDeitalsShow()
        {
            InitializeComponent();
        }
        private void OrderDeitalsShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "פרטים בהזמנות";
            ctbl = new OrderDeitalsTbl();
            DGOrderDeitals.DataSource = ctbl.getalltable();
        }
    }
}
