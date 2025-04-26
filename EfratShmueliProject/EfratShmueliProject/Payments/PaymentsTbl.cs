using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Payments
{
    internal class PaymentsTbl:GeneralTbl
    {
        public PaymentsTbl() : base("Payments")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT payments.P_kod AS [קוד תשלום], payments.P_orderKod AS [קוד הזמנה], clients.C_id AS [תעודת זהות לקוח מזמין], clients.C_lastName AS [שם], payments.P_numPayments AS [מספר תשלומים], payments.P_paymentMethod AS [אמצעי תשלום], payments.P_fileAttached AS [מספר אסמכתא], payments.P_creditCard AS [מספר כרטיס אשראי], payments.P_validity AS [תוקף כרטיס אשראי], payments.P_CVC AS [CVC כרטיס אשראי] ,payments.P_status AS [סטטוס תשלום] FROM clients INNER JOIN (orders INNER JOIN payments ON orders.O_Kod = payments.P_orderKod) ON clients.C_kod = orders.O_clientKod;");

        }
        public void UpDatePayment(Payments p)
        {
            p.FillDataRow();
            Dal.Save(table.TableName);
        }
        public void DeletePayments(Payments cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddPayment(Payments p)
        {
            //יצירת שורה בתבנית של הטבלה
            p.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            p.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(p.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}
