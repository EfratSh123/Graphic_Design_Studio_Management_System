using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.OrderDeitals
{
    internal class OrderDeitals
    {
        public DataRow dr;
        private int DO_kod;
        private int DO_kodOredr;
        private int DO_KindOredrKod;
        private string DO_Describing;
        private string OD_status;
        public OrderDeitals() { }
        public OrderDeitals(DataRow drc)
        {
            this.DO_kod = int.Parse(drc["DO_kod"].ToString());
            this.DO_kodOredr = int.Parse(drc["DO_kodOredr"].ToString());
            this.DO_KindOredrKod = int.Parse(drc["DO_KindOredrKod"].ToString());
            this.DO_Describing = drc["DO_Describing"].ToString();
            this.OD_status = drc["DO_status"].ToString();
            this.dr = drc;
        }
        public int FDO_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.DO_kod = value;
                else
                    throw new Exception("הקוד שגוי");
            }
            get
            {
                return this.DO_kod;
            }
        }
        public int FDO_kodOredr
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.DO_kodOredr = value;
                else
                    throw new Exception("הקוד שגוי");
            }
            get
            {
                return this.DO_kodOredr;
            }
        }
        public int FDO_KindOredrKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.DO_KindOredrKod = value;
                else
                    throw new Exception("הקוד שגוי");
            }
            get
            {
                return this.DO_KindOredrKod;
            }
        }
        public string FDO_Describing
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.DO_Describing = value;
                else
                    throw new Exception("הזן אותיות עבריות בלבד");
            }
            get
            {
                return this.DO_Describing;
            }
        }
        public string FOD_status
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.OD_status = value;
                else
                    throw new Exception("הזן אותיות עבריות בלבד");
            }
            get
            {
                return this.OD_status;
            }
        }
        public void FillDataRow()
        {
            this.dr["DO_kod"] = this.DO_kod;
            this.dr["DO_KindOredrKod"] = this.DO_KindOredrKod;
            this.dr["DO_Describing"] = this.DO_Describing;
            this.dr["DO_kodOredr"] = this.DO_kodOredr;
            this.dr["DO_status"] = this.OD_status;

        }
    }
}
