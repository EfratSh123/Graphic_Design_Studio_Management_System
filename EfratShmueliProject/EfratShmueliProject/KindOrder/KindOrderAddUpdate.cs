using EfratShmueliProject.Cities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.KindOrder
{
    public partial class KindOrderAddUpdate : Designer
    {
        string status;
        KindOrderTbl kTbl = new KindOrderTbl();
        KindOrder k;
        public KindOrderAddUpdate()
        {
            InitializeComponent();
            status = "Add";
            k = new KindOrder();
        }
        public KindOrderAddUpdate(int K_kod)
        {
            InitializeComponent();
            status = "UpDate";
            DataRow dr = kTbl.Find("K_kod", K_kod);
            k = new KindOrder(dr);
            FillForm();
        }
        public void FillForm()
        {
            txtbKodKindOrder.Text = k.FK_kod.ToString();
            txtbNameKindOrder.Text = k.FK_describing.ToString();
            txtbPriceKindOrder.Text = k.FK_price.ToString();
            txttimeWorking.Text = k.Fk_timeWorking.ToString();

            AddKindOrder.Text = "עדכון";

        }


        private void KindOrderAddUpdate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (status == "Add")
            {
                this.Text = "הוספת מוצר לקטלוג";
                txtbKodKindOrder.Text = kTbl.GetNext("K_kod").ToString();
            }
            else
                this.Text = "עדכון מוצר בקטלוג";
        }
        public bool CheckLegal()
        {
            ErpDescribKindOrder.Clear();
            erpPriceKindOrder.Clear();
            bool degel = true;
            k.FK_kod = int.Parse(txtbKodKindOrder.Text);
            if (txtbNameKindOrder.Text != "" && txtbNameKindOrder.Text.Length >= 2)
            {
                try
                {
                    k.FK_describing = txtbNameKindOrder.Text;
                }
                catch (Exception ex1)
                {
                    ErpDescribKindOrder.SetError(txtbNameKindOrder, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txtbNameKindOrder.BackColor = Color.LightSalmon;
                degel = false;
            }
            if (txtbPriceKindOrder.Text != "" && txtbPriceKindOrder.Text.Length >= 2)
            {
                try
                {
                    k.FK_price = txtbPriceKindOrder.Text;
                }
                catch (Exception ex1)
                {
                    erpPriceKindOrder.SetError(txtbPriceKindOrder, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txtbPriceKindOrder.BackColor = Color.LightSalmon;
                degel = false;
            }
            if (txttimeWorking.Text != "" && txttimeWorking.Text.Length >= 1)
            {
                try
                {
                    k.Fk_timeWorking = txttimeWorking.Text;
                }
                catch (Exception ex1)
                {
                    erpPriceKindOrder.SetError(txttimeWorking, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txttimeWorking.BackColor = Color.LightSalmon;
                degel = false;
            }
            return degel;
        }
        private void AddKindOrder_Click(object sender, EventArgs e)
        {
            if (CheckLegal())
            {
                if (status == "Add")
                {
                    kTbl.AddKindOrder(k);
                }
                else
                {
                    kTbl.UpDateKindOrder(k);
                }
                this.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbNameKindOrder_TextChanged(object sender, EventArgs e)
        {
            if (txtbNameKindOrder.BackColor == Color.LightSalmon)
                txtbNameKindOrder.BackColor = Color.White;
        }

        private void txtbPriceKindOrder_TextChanged(object sender, EventArgs e)
        {
            if (txtbPriceKindOrder.BackColor == Color.LightSalmon)
                txtbPriceKindOrder.BackColor = Color.White;
        }

        private void txttimeWorking_TextChanged(object sender, EventArgs e)
        {
            if (txttimeWorking.BackColor == Color.LightSalmon)
                txttimeWorking.BackColor = Color.White;
        }
    }
}
