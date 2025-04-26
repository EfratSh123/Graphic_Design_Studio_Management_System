using EfratShmueliProject.Clients;
using EfratShmueliProject.KindOrder;
using EfratShmueliProject.Mittings;
using EfratShmueliProject.OrderDeitals;
using EfratShmueliProject.Payments;
using EfratShmueliProject.Workers;
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

namespace EfratShmueliProject.Orders
{
    public partial class OrdersShow : Designer
    {
        OrdersTbl otbl;
        DataTable odt;
        OrderDeitalsTbl oDtbl = new OrderDeitalsTbl();
        DataTable dtOD;
        KindOrderTbl ktbl = new KindOrderTbl();
        DataTable dtKindO;
        public OrdersShow()
        {
            InitializeComponent();
        }

        private void OrdersShow_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            this.Text = "הזמנות";
            otbl = new OrdersTbl();
            DGOrders.DataSource = otbl.getalltable();
            odt = otbl.getalltable();
        }

        private void הוסףToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersAddUpdate cc = new OrdersAddUpdate();
            cc.ShowDialog();
            DGOrders.DataSource = otbl.getalltable();
        }

        private void btnFresh_Click(object sender, EventArgs e)
        {
            DGOrders.DataSource = odt;
            txtSearch.Text = "הקש ערך לחיפוש";
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
                DGOrders.DataSource = odt;
            else
                DGOrders.DataSource = Classes.SmartSreach.Search(odt, txtSearch.Text);
        }

        private void txtSearch_MouseLeave(object sender, EventArgs e)
        {
            //כשאר העכבר יוצא מתיבת טקסט
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "הקש ערך לחיפוש";
                DGOrders.DataSource = odt;
            }
            else
            if (txtSearch.Text != "הקש ערך לחיפוש")
            {
                string s = txtSearch.Text;
                txtSearch.Text = "הקש ערך לחיפוש";
                DGOrders.DataSource = Classes.SmartSreach.Search(odt, s);
            }
        }

        private void txtSearch_MouseClick(object sender, MouseEventArgs e)
        {
            txtSearch.Text = "";
        }

        private void עדכןToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGOrders.SelectedRows.Count > 0)
            {
                OrdersAddUpdate m = new OrdersAddUpdate(int.Parse(DGOrders.SelectedRows[0].Cells[0].Value.ToString()));
                m.ShowDialog();
                DGOrders.DataSource = otbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void בטל_הזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrdersTbl ooo = new OrdersTbl();
            DataTable dt = ooo.GetTable();
            dtOD = oDtbl.GetTable();
            bool degel = true;
            int sumToPay = 0;
            DataRow drOD;
            //dtKindO = ktbl.GetTable();
            if (DGOrders.SelectedRows.Count > 0)
            {
                //אם הסטטוס של ההזמנה הוא בשלבי עבודה
                if (DGOrders.SelectedRows[0].Cells[7].Value.ToString() == "בשלבי עבודה")
                {
                    DataTable dtODD = oDtbl.GetProductOfOrder(int.Parse(DGOrders.SelectedRows[0].Cells[0].Value.ToString()));
                    //פרטים בהזמנות
                    for (int i = 0; i < dtODD.Rows.Count; i++)
                    {
                        if (dtODD.Rows[i][4].ToString() == "בוצע")
                        {
                            drOD = ktbl.Find("K_kod", dtOD.Rows[i][2]);
                            sumToPay += int.Parse(drOD[2].ToString());
                        }
                    }
                    //כאשר כלום לא בוצע- משלמים מחיר פגישה
                    if (sumToPay == 0)
                    {
                        DataRow dr1 = ktbl.Find("K_kod", 777);
                        sumToPay += int.Parse(dr1[2].ToString());
                    }
                    MessageBox.Show("  כעת יש לשלם" + sumToPay + "  שקלים, לאחר מכן יתבצע מחיקת ההזמנה");

                    DataRow dr = otbl.Find("O_Kod", DGOrders.SelectedRows[0].Cells[0].Value.ToString());
                    Orders o = new Orders(dr);
                    DataTable dtODD1 = oDtbl.GetProductOfOrder(int.Parse(DGOrders.SelectedRows[0].Cells[0].Value.ToString()));

                    //תשלום על פגישה
                    PaymentsAddUpdate pa = new PaymentsAddUpdate(o.FO_Kod, "Add");
                    pa.ShowDialog();
                    PaymentsTbl ptbl = new PaymentsTbl();
                    DataTable dtPay = ptbl.GetTable();
                    //לבדוק האם שילמו
                    bool dPay = false;
                    for (int i = 0; i < dtPay.Rows.Count; i++)
                    {
                        if (dtPay.Rows[i][1].ToString() == o.FO_Kod.ToString())
                        {
                            dPay = true;
                            break;
                        }
                    }
                    if (dPay)
                    {
                        for (int k = 0; k < dtODD1.Rows.Count; k++)
                        {
                            if (dtODD1.Rows[k][1].ToString() == DGOrders.SelectedRows[0].Cells[0].FormattedValue.ToString())
                            {
                                DataRow dr11 = oDtbl.Find("DO_kodOredr", o.FO_Kod);
                                OrderDeitals.OrderDeitals od = new OrderDeitals.OrderDeitals(dr11);
                                oDtbl.DeleteOrderDeitals(od);
                            }
                        }
                        otbl.DeleteOrders(new Orders(dr));
                        DGOrders.DataSource = otbl.getalltable();
                        MessageBox.Show("ההזמנה נמחקה בהצלחה");
                    }
                }
                else
                {
                    //if (MessageBox.Show("האם אתה בטוח שברצונך למחוק הזמנה זו?", "שים לב!", MessageBoxButtons.YesNo,
                    //    MessageBoxIcon.Question, MessageBoxDefaultButton.Button2, MessageBoxOptions.RtlReading) == DialogResult.Yes)
                    //{
                    //    DataRow dr = otbl.Find("O_Kod", DGOrders.SelectedRows[0].Cells[0].Value.ToString());
                    //    Orders o = new Orders(dr);
                    //    DataTable dtODD1 = oDtbl.GetProductOfOrder(int.Parse(DGOrders.SelectedRows[0].Cells[0].Value.ToString()));
                    //}
                    //bool dPay = false;
                    //for (int i = 0; i < dtPay.Rows.Count; i++)
                    //{
                    //    if (dtPay.Rows[i][1].ToString() == o.FO_Kod.ToString())
                    //    {
                    //        dPay = true;
                    //        break;
                    //    }
                    //}
                    //if (dPay)
                    //{
                    //    for (int k = 0; k < dtODD1.Rows.Count; k++)
                    //    {
                    //        if (dtODD1.Rows[k][1].ToString() == DGOrders.SelectedRows[0].Cells[0].FormattedValue.ToString())
                    //        {
                    //            DataRow dr11 = oDtbl.Find("DO_kodOredr", o.FO_Kod);
                    //            OrderDeitals.OrderDeitals od = new OrderDeitals.OrderDeitals(dr11);
                    //            oDtbl.DeleteOrderDeitals(od);
                    //        }
                    //    }
                    //    otbl.DeleteOrders(new Orders(dr));
                    //    DGOrders.DataSource = otbl.getalltable();
                    //    MessageBox.Show("ההזמנה נמחקה בהצלחה");
                    //}
                }
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }

        private void הצגתפרטיהזמנהToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (DGOrders.SelectedRows.Count > 0)
            {
                OrdersAddUpdate m = new OrdersAddUpdate(int.Parse(DGOrders.SelectedRows[0].Cells[0].Value.ToString()) , "Show");
                m.ShowDialog();
                DGOrders.DataSource = otbl.getalltable();
            }
            else
            {
                MessageBox.Show("עליך לבחור שורה");
            }
        }
    }
}