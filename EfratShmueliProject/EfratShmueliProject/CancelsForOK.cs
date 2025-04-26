using EfratShmueliProject.cancels;
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

namespace EfratShmueliProject
{
    public partial class CancelsForOK : Designer
    {
        CancelsTbl catbl = new CancelsTbl();
        DataTable cdt;
        public CancelsForOK()
        {
            InitializeComponent();
        }

        private void CancelsForOK_Load(object sender, EventArgs e)
        {
            CenterToScreen();

            this.Text = "ביטולים לאישור";
            dataGridView1.DataSource = catbl.getCancelsForOK();
            cdt = catbl.getCancelsForOK();
        }
    }
}
