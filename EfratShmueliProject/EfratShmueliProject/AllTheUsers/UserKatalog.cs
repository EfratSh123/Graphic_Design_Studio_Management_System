using EfratShmueliProject.KindOrder;
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

namespace EfratShmueliProject.AllTheUsers
{
    public partial class UserKatalog : UserControl
    {
        KindOrderTbl ktbl = new KindOrderTbl();
        KindOrder.KindOrder k;
        OrdersAddUpdate orderAU;
        int codeOrder;
        string describing;
        string price;
        static int mone = 0;

        public UserKatalog(int codeKatalog, OrdersAddUpdate o)
        {
            InitializeComponent();
            this.orderAU = o;
            k = new KindOrder.KindOrder(ktbl.Find("K_kod", codeKatalog));
            FillUser();
        }
        public UserKatalog(int code)
        {
            InitializeComponent();

        }
        public void FillUser()
        {
            lblKodCatalog.Text = k.FK_kod.ToString();
            textBox1.Text = k.FK_describing;
            lblPrice.Text = k.FK_price;
            txtbTimeWorking.Text = k.Fk_timeWorking;
        }
        private void btnPicture_Click(object sender, EventArgs e)
        {
            KatalogPicture kp = new KatalogPicture(k.FK_kod);
            kp.ShowDialog();
        }

        private void UserKatalog_Load(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                checkBox2.Enabled = true;
            else
                checkBox2.Enabled = false;
        }
        public int GetCode()
        {
            return int.Parse(lblKodCatalog.Text);
        }
        public bool GetCheckedCheckBox2()
        {
            return checkBox2.Checked;
        }
        public void ChangeCheckedcheckBox1()
        {
            checkBox1.Checked = true;
        }
        public void ChangeCheckedcheckBox2()
        {
            checkBox2.Checked = true;
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            orderAU.SumAndTime();

            if (checkBox1.Checked)
            {
                checkBox2.Enabled = true;
                mone++;
                orderAU.gbGrafic.Enabled = true;
            }
            else
            {
                checkBox2.Enabled = false;
                mone--;
                if (mone == 0)
                    orderAU.gbGrafic.Enabled = false;
            }
            orderAU.Checked();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            orderAU.Checked();
        }
    }
}
