using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Cities
{
    internal class Cities
    {
        public DataRow dr;
        private int CI_kod;
        private string CI_name;
        public Cities() { }
        public Cities(DataRow drc) 
        {
            this.CI_kod = int.Parse(drc["CI_kod"].ToString());
            this.CI_name = drc["CI_name"].ToString();
            this.dr = drc;
        }
        public int FCi_code
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.CI_kod = value;
                else
                    throw new Exception("הקוד שגוי");
            }
            get
            {
                return this.CI_kod;
            }
        }
        public string FCi_name
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.CI_name = value;
                else
                    throw new Exception("הזן אותיות עבריות בלבד");
            }
            get
            {
                return this.CI_name;
            }
        }
        public void FillDataRow()
        {
            this.dr["CI_kod"] = this.CI_kod;
            this.dr["CI_name"] = this.CI_name;
        }
    }
}
