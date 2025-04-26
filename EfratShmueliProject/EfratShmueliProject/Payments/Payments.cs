using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Payments
{
    internal class Payments
    {
        public DataRow dr;
        private int P_kod;
        private int P_orderKod;
        private string P_numPayments;
        private string P_paymentMethod;
        private string P_fileAttached;
        private string P_creditCard;
        private string P_validity;
        private string P_CVC;
        private string P_status;
        public Payments() { }
        public Payments(DataRow drc)
        {
            this.P_kod = int.Parse(drc["P_kod"].ToString());
            this.P_orderKod = int.Parse(drc["P_orderKod"].ToString());
            this.P_numPayments = drc["P_numPayments"].ToString();
            this.P_paymentMethod = drc["P_paymentMethod"].ToString();
            this.P_fileAttached = drc["P_fileAttached"].ToString();
            this.P_creditCard = drc["P_creditCard"].ToString();
            this.P_validity = drc["P_validity"].ToString();
            this.P_CVC = drc["P_CVC"].ToString();
            this.P_status = drc["P_status"].ToString();
            this.dr = drc;
        }
        public string FP_status
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.P_status = value;
                else
                    throw new Exception("הכנס אותיות עבריות בלבד");
            }
            get
            {
                return this.P_status;
            }
        }
        public string FP_fileAttached
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.P_fileAttached = value;
                else
                    throw new Exception("הכנס מספר בלבד");
            }
            get
            {
                return this.P_fileAttached;
            }
        }
        public string FP_paymentMethod
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.P_paymentMethod = value;
                else
                    throw new Exception("הכנס אותיות עבריות בלבד");
            }
            get
            {
                return this.P_paymentMethod;
            }
        }
        public int FP_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.P_kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.P_kod;
            }
        }
        public int FP_orderKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.P_orderKod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.P_orderKod;
            }
        }
        public string FP_numPayments
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.P_numPayments = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.P_numPayments;
            }
        }
        public string FP_creditCard
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.P_creditCard = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.P_creditCard;
            }
        }
        public string FP_CVC
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.P_CVC = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.P_CVC;
            }
        }
        
        public string FP_validity
        {
            set
            {
                this.P_validity = value;
            }
            get
            {
                return this.P_validity;
            }
        }
        
        public void FillDataRow()
        {
            this.dr["P_kod"] = this.P_kod;
            this.dr["P_orderKod"] = this.P_orderKod;
            this.dr["P_numPayments"] = this.P_numPayments;
            this.dr["P_fileAttached"] = this.P_fileAttached;
            this.dr["P_creditCard"] = this.P_creditCard;
            this.dr["P_validity"] = this.P_validity;
            this.dr["P_CVC"] = this.P_CVC;
            this.dr["P_status"] = this.P_status;
            this.dr["P_paymentMethod"] = this.P_paymentMethod;

        }
    }
}
