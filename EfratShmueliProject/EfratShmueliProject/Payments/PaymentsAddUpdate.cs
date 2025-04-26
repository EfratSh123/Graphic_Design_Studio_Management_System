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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EfratShmueliProject.Payments
{
    public partial class PaymentsAddUpdate : Designer
    {
        string status;
        int orderKodd;
        Payments p;
        PaymentsTbl ptbl = new PaymentsTbl();
        public PaymentsAddUpdate(int orderKod, string orderStatus)
        {
            InitializeComponent();
            status = orderStatus;
            rbCreditCard.Checked = true;
            orderKodd= orderKod;
            //הוספה
            if(status == "Add")
            {
                p = new Payments();
                p.FP_orderKod= orderKod;
            }
            //עדכון
            else
            {
                DataRow dr = ptbl.Find("P_orderKod", orderKod);
                p = new Payments(dr);
                FillForm();
            }
        }
        //public PaymentsAddUpdate()
        //{
        //    InitializeComponent();
        //    status = "Add";
        //    rbCreditCard.Checked = true;
        //    p = new Payments();
        //}
        public void FillForm()
        {
            txtbCVC.Text = p.FP_CVC.ToString();
            txtbKodPayment.Text = p.FP_kod.ToString();
            txtbNumCreditCard.Text = p.FP_creditCard.ToString();
            
            if(p.FP_paymentMethod == "כרטיס אשראי")
            {
                rbCreditCard.Checked = true;
                cmbMonth.Text = p.FP_validity.Substring(0, 2);
                cmbYear.Text = p.FP_validity.Substring(3, 4);
                groupBox2.Visible=false;
                groupBox1.Visible = true;

            }
            else
            {
                rbBankTransfer.Checked = true;
                groupBox1.Visible = false;
                groupBox2.Visible = true;
                txtAsmachta.Text = p.FP_fileAttached.ToString();

            }
            txtKodOrder.Text = p.FP_orderKod.ToString();
            //מה יהיה בחור במספר תשלומים
            cmbNumPayments.Text = p.FP_numPayments.ToString();
            txtKodOrder.Enabled = false;
            txtbKodPayment.Enabled = false;

            //סימון סטטוס- שולם או לא שולם
            if (p.FP_status == "שולם")
            {
                rbStatusPaymentYes.Checked = true;
            }
            else
            {
                rbStatusPaymentNo.Checked = true;
            }
            AddPayment.Text = "עדכון";
        }
        private void PaymentsAddUpdate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            ///////////////////////////
            txtKodOrder.Text = orderKodd.ToString();
            if (status == "Add")
            {
                txtbKodPayment.Text = ptbl.GetNext("P_kod").ToString();
                this.Text = "הוספת תשלום";
                rbStatusPaymentYes.Visible = false;
                rbStatusPaymentNo.Visible = false;
                lblStatusPayment.Visible = false;

                cmbNumPayments.SelectedIndex = 0;
                cmbMonth.SelectedIndex = 0;
                cmbYear.SelectedIndex = 0;
            }
            else
                this.Text = "עדכון תשלום";
            
            //בהעברה בנקאית- הפקדים של אשראי מוסתרים
            if (rbBankTransfer.Checked)
            {
                lblNumPayments.Visible = false;
                cmbNumPayments.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = true;

            }
            //באשראי- הפקדים של העברה בנקאית מוסתרים
            if (rbCreditCard.Checked)
            {
                lblNumPayments.Visible = true;
                cmbNumPayments.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = false;

            }
        }

        public bool CheckLegal()
        {
            errorProviderCVC.Clear();
            errorProviderFileAttached.Clear();
            errorProviderMonth.Clear();
            errorProviderNumCredetCard.Clear();
            errorProviderYear.Clear();
            bool d = true;
            //קוד תשלום והזמנה
            p.FP_kod = int.Parse(txtbKodPayment.Text);
            p.FP_orderKod = int.Parse(txtKodOrder.Text);

            // בדיקת קוד הזמנה
            if (txtKodOrder.Text != "")
            {
                try
                {
                    p.FP_orderKod = int.Parse(txtKodOrder.Text);
                }
                catch (Exception exp1)
                {
                    errorProviderKodOrder.SetError(txtKodOrder, exp1.Message);
                    d = false;
                }
            }
            else
            {
                txtKodOrder.BackColor = Color.LightCoral;
                d = false;
            }

            //אמצעי תשלום
            if (rbBankTransfer.Checked)
            {
                p.FP_paymentMethod = "העברה בנקאית";
                if (txtAsmachta.Text != "")
                {
                    try
                    {
                        p.FP_fileAttached = txtAsmachta.Text;
                    }
                    catch (Exception exp1)
                    {
                        errorProviderFileAttached.SetError(txtAsmachta, exp1.Message);
                        d = false;
                    }
                }
                else
                {
                    txtAsmachta.BackColor = Color.LightSalmon;
                    d = false;
                }
            }
            else
            {
                p.FP_paymentMethod = "כרטיס אשראי";
                // מספר כרטיס
                if (txtbNumCreditCard.Text != "" && txtbNumCreditCard.Text.Length == 16)
                {
                    try
                    {
                        p.FP_creditCard = txtbNumCreditCard.Text;
                    }
                    catch (Exception exp1)
                    {
                        errorProviderNumCredetCard.SetError(txtbNumCreditCard, exp1.Message);
                        d = false;
                    }
                }
                else
                {
                    txtbNumCreditCard.BackColor = Color.LightSalmon;
                    d = false;
                }
                // תוקף
                if (cmbYear.Text != "")
                    try
                    {
                        p.FP_validity = cmbMonth.Text + "/" + cmbYear.Text;
                    }
                    catch (Exception ex1)
                    {
                        errorProviderValidity.SetError(cmbYear, ex1.Message);
                        d = false;
                    }
                else
                {
                    cmbYear.BackColor = Color.LightSalmon;
                    d = false;
                }
                // 3 ספרות בגב הכרטיס
                if (txtbCVC.Text != "" && txtbCVC.Text.Length == 3)
                {
                    try
                    {
                        p.FP_CVC = txtbCVC.Text;
                    }
                    catch (Exception exp1)
                    {
                        errorProviderCVC.SetError(txtbCVC, exp1.Message);
                        d = false;
                    }
                }
                else
                {
                    txtbCVC.BackColor = Color.LightSalmon;
                    d = false;
                }
                // מספר תשלומים
                p.FP_numPayments = cmbNumPayments.Text;
            }
            // סטטוס
            if (rbStatusPaymentYes.Checked)
                p.FP_status = "שולם";
            else
                p.FP_status = "לא שולם";

            return d;
        }
        private void AddPayment_Click(object sender, EventArgs e)
        {
            if (CheckLegal())
            {
                if (status == "Add")
                {
                    ptbl.AddPayment(p);
                    MessageBox.Show("התשלום נשמר בהצלחה");
                }
                else
                {
                    ptbl.UpDatePayment(p);
                }
                this.Close();
            }
        }

        private void rbBankTransfer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbBankTransfer.Checked)
            {
                lblNumPayments.Visible = false;
                cmbNumPayments.Visible = false;
                groupBox1.Visible = false;
                groupBox2.Visible = true;

            }
        }

        private void rbCreditCard_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCreditCard.Checked)
            {
                lblNumPayments.Visible = true;
                cmbNumPayments.Visible = true;
                groupBox1.Visible = true;
                groupBox2.Visible = false;

            }
        }

        private void txtbNumCreditCard_TextChanged(object sender, EventArgs e)
        {
            if (txtbNumCreditCard.BackColor == Color.LightSalmon)
                txtbNumCreditCard.BackColor = Color.White;
        }

        private void txtbCVC_TextChanged(object sender, EventArgs e)
        {
            if (txtbCVC.BackColor == Color.LightSalmon)
                txtbCVC.BackColor = Color.White;
        }
    }
}
