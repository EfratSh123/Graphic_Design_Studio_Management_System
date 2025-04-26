using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.cancels
{
    internal class Cancels
    {
        public DataRow dr;
        private int CA_kod;
        private int CA_workerKod;
        private string CA_dateOfStart;
        private string CA_dateOfEnd;
        private string CA_status;


        public Cancels() { }
        public Cancels(DataRow drc)
        {
            this.CA_kod = int.Parse(drc["CA_kod"].ToString());
            this.CA_workerKod = int.Parse(drc["CA_workerKod"].ToString());
            this.CA_dateOfStart = drc["CA_dateOfStart"].ToString();
            this.CA_dateOfEnd = drc["CA_dateOfEnd"].ToString();
            this.CA_status = drc["CA_status"].ToString();

            this.dr = drc;
        }
        public int FCA_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.CA_kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.CA_kod;
            }
        }
        public int FCA_workerKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.CA_workerKod = value;
                else
                    throw new Exception("הכנס מספר בלבד");
            }
            get
            {
                return this.CA_workerKod;
            }
        }
        
        public string FCA_dateOfStart
        {
            set
            {
                this.CA_dateOfStart = DateTime.Parse(value).ToShortDateString().ToString();
            }
            get
            {
                return this.CA_dateOfStart;
            }
        }
        public string FCA_status
        {
            set
            {
                this.CA_status = value.ToString();
            }
            get
            {
                return this.CA_status;
            }
        }
        public string FCA_dateOfEnd
        {
            set
            {
                this.CA_dateOfEnd = DateTime.Parse(value).ToShortDateString().ToString();
            }
            get
            {
                return this.CA_dateOfEnd;
            }
        }
        public void FillDataRow()
        {
            this.dr["CA_kod"] = this.CA_kod;
            this.dr["CA_workerKod"] = this.CA_workerKod;
            this.dr["CA_dateOfEnd"] = this.CA_dateOfEnd;
            this.dr["CA_dateOfStart"] = this.CA_dateOfStart;
            this.dr["CA_status"] = this.CA_status;

        }
    }
}
