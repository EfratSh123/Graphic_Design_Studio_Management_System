using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Mittings
{
    internal class Mittings
    {
        public DataRow dr;
        private int M_kod;
        private string M_date;
        private string M_hour;
        private int M_clientKod;
        private string M_status;
        
        public Mittings() { }
        public Mittings(string date1, string hour1)
        {
            this.M_date = date1;
            this.M_hour = hour1;
        }

        public Mittings(DataRow drc)
        {
            this.M_kod = int.Parse(drc["M_kod"].ToString());
            this.M_date = drc["M_date"].ToString();
            this.M_hour = drc["M_hour"].ToString();
            this.M_clientKod = int.Parse(drc["M_clientKod"].ToString());
            this.M_status = drc["M_status"].ToString();

            this.dr = drc;
        }
        public Mittings(DataRow drc, string s)
        {
            this.M_kod = int.Parse(drc[0].ToString());
            this.M_date = drc[1].ToString();
            this.M_hour = drc[2].ToString();
            this.M_clientKod = int.Parse(drc[3].ToString());
            this.M_status = drc[5].ToString();
            this.dr = drc;
        }
        public int FM_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.M_kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.M_kod;
            }
        }
        public string FM_hour
        {
            set
            {
                this.M_hour = value;
            }
            get
            {
                return this.M_hour;
            }
        }
        public int FM_clientKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.M_clientKod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.M_clientKod;
            }
        }
        public string FM_date
        {
            set
            {
                this.M_date = DateTime.Parse(value).ToShortDateString().ToString();
            }
            get
            {
                return this.M_date;
            }
        }
        public string FM_status
        {
            set
            {
                this.M_status = value;
            }
            get
            {
                return this.M_status;
            }
        }
        public void FillDataRow()
        {
            this.dr["M_kod"] = this.M_kod;
            this.dr["M_date"] = this.M_date;
            this.dr["M_hour"] = this.M_hour;
            this.dr["M_clientKod"] = this.M_clientKod;
            this.dr["M_status"] = this.M_status;
        }
        public void FillDataRow(string s)
        {
            this.dr[0] = this.M_kod;
            this.dr[1] = this.M_date;
            this.dr[2] = this.M_hour;
            this.dr[3] = this.M_clientKod;
            this.dr[4] = this.M_status;
        }
    }
}
