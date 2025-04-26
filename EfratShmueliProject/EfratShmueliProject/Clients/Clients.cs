using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Clients
{
    internal class Clients
    {
        public DataRow dr;
        private int C_kod;
        private string C_id;
        private string C_lastName;
        private string C_firstName;
        private int C_cityKod;
        private string C_adress;
        private string C_eMail;
        private string C_pel;
        private string C_status;

        public Clients() { }
        public Clients(DataRow drc)
        {
            this.C_kod = int.Parse(drc["C_kod"].ToString());
            this.C_id = drc["C_id"].ToString();
            this.C_lastName = drc["C_lastName"].ToString();
            this.C_cityKod = int.Parse(drc["C_cityKod"].ToString());
            this.C_adress = drc["C_adress"].ToString();
            this.C_eMail = drc["C_eMail"].ToString();
            this.C_pel = drc["C_pel"].ToString();
            this.C_status = drc["C_status"].ToString();

            this.dr = drc;
        }
        public int FC_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.C_kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.C_kod;
            }
        }
        
        public string FC_eMail
        {
            set
            {
                if (Legal.CheackMail(value))
                    this.C_eMail = value;
                else
                    throw new Exception("הזן כתובת מייל תקינה");
            }
            get
            {
                return this.C_eMail;
            }
        }
        public string FC_id
        {
            set
            {
                if (Legal.LegalId(value))
                    this.C_id = value;
                else
                    throw new Exception("מספר זהות שגוי");
            }
            get
            {
                return this.C_id;
            }
        }
        public string FC_lastName
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.C_lastName = value;
                else
                    throw new Exception("הכנס אותיות עבריות בלבד");
            }
            get
            {
                return this.C_lastName;
            }
        }
        public string FC_firstName
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.C_firstName = value;
                else
                    throw new Exception("הכנס אותיות עבריות בלבד");
            }
            get
            {
                return this.C_firstName;
            }
        }
        public string FC_address
        {
            set
            {
                    this.C_adress = value;
            }
            get
            {
                return this.C_adress;
            }
        }


        public string FC_pel
        {
            set
            {
                if (Legal.IsCellPhone(value))
                    this.C_pel = value;
                else
                    throw new Exception("מספר לא תקין");
            }
            get
            {
                return this.C_pel;
            }
        }
        
        public int FC_cityKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.C_cityKod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.C_cityKod;
            }
        }
        public string FC_status
        {
            set
            {
                this.C_status = value;
            }
            get
            {
                return this.C_status;
            }
        }
        
        public void FillDataRow()
        {
            this.dr["C_kod"] = this.C_kod;
            this.dr["C_id"] = this.C_id;
            this.dr["C_lastName"] = this.C_lastName;
            this.dr["C_firstName"] = this.C_firstName;
            this.dr["C_cityKod"] = this.C_cityKod;
            this.dr["C_adress"] = this.C_adress;
            this.dr["C_eMail"] = this.C_eMail;
            this.dr["C_pel"] = this.C_pel;
            this.dr["C_status"] = this.C_status;


        }
    }
}
