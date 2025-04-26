using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.KindOrder
{
    internal class KindOrder
    {
        public DataRow dr;
        private int K_kod;
        private string K_describing;
        private string K_price;
        private string k_timeWorking;
        private string K_picture;
        public KindOrder() { }
        public KindOrder(DataRow drc)
        {
            this.K_kod = int.Parse(drc["K_kod"].ToString());
            this.K_describing = drc["K_describing"].ToString();
            this.K_price = drc["K_price"].ToString();
            this.k_timeWorking = drc["k_timeWorking"].ToString();
            this.dr = drc;
        }
        public int FK_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.K_kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.K_kod;
            }
        }
        public string FK_describing
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.K_describing = value;
                else
                    throw new Exception("הכנס אותיות עבריות בלבד");
            }
            get
            {
                return this.K_describing;
            }
        }
        public string FK_price
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.K_price = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.K_price;
            }
        }
        public string Fk_timeWorking
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.k_timeWorking = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.k_timeWorking;
            }
        }
        public void FillDataRow()
        {
            this.dr["K_kod"] = this.K_kod;
            this.dr["K_describing"] = this.K_describing;
            this.dr["K_price"] = this.K_price;
            this.dr["k_timeWorking"] = this.k_timeWorking;

        }
    }
}
