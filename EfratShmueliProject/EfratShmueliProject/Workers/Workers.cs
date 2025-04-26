using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Workers
{
    internal class Workers
    {
        public DataRow dr;
        private int W_kod;
        private string W_lastName;
        private string W_phone;
        private int W_cityKod;
        private string W_adress;
        private string W_dateOfBirth;
        private string W_Mail;
        private string W_status;
        private string W_password;


    public Workers() { }
        public Workers(DataRow drc)
        {
            this.W_kod = int.Parse(drc["W_kod"].ToString());
            this.W_lastName = drc["W_lastName"].ToString();
            this.W_phone = drc["W_phone"].ToString();
            this.W_cityKod = int.Parse(drc["W_cityKod"].ToString());
            this.W_adress = drc["W_adress"].ToString();
            this.W_dateOfBirth = drc["W_dateOfBirth"].ToString();
            this.W_Mail = drc["W_Mail"].ToString();
            this.W_status = drc["W_status"].ToString();
            this.W_password = drc["W_password"].ToString();

            this.dr = drc;
        }
        public int FW_kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.W_kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.W_kod;
            }
        }
        public int FW_cityKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.W_cityKod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.W_cityKod;
            }
        }
        
        public string FW_lastName
        {
            set
            {
                if (Legal.IsHebrew(value))
                    this.W_lastName = value;
                else
                    throw new Exception("הכנס אותיות עבריות בלבד");
            }
            get
            {
                return this.W_lastName;
            }
        }
        public string FW_phone
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.W_phone = value;
                else
                    throw new Exception("הכנס מספרים בלבד");
            }
            get
            {
                return this.W_phone;
            }
        }
        public string FW_dateOfBirth
        {
            set
            {
                    this.W_dateOfBirth = value;
            }
            get
            {
                return this.W_dateOfBirth;
            }
        }
        public string FW_Mail
        {
            set
            {
                if (Legal.CheackMail(value))
                    this.W_Mail = value;
                else
                    throw new Exception("הזן כתובת מייל תקינה");
            }
            get
            {
                return this.W_Mail;
            }
        }
        public string FW_status
        {
            set
            {
                    this.W_status = value;
            }
            get
            {
                return this.W_status;
            }
        }
        public string FW_password
        {
            set
            {
                this.W_password = value;
            }
            get
            {
                return this.W_password;
            }
        }
        public string FW_adress
        {
            set
            {
                    this.W_adress = value;
            }
            get
            {
                return this.W_adress;
            }
        }
        public void FillDataRow()
        {
            this.dr["W_kod"] = this.W_kod;
            this.dr["W_lastName"] = this.W_lastName;
            this.dr["W_phone"] = this.W_phone;
            this.dr["W_cityKod"] = this.W_cityKod;
            this.dr["W_adress"] = this.W_adress;
            this.dr["W_dateOfBirth"] = this.W_dateOfBirth;
            this.dr["W_Mail"] = this.W_Mail;
            this.dr["W_status"] = this.W_status;
            this.dr["W_password"] = this.W_password;
        }
    }
}
