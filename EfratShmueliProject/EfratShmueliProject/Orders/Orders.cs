using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Orders
{
    internal class Orders
    {
        public DataRow dr;
        private int O_Kod;
        private int O_clientKod;
        private string O_dateOfOrder;
        private string O_dateOFEnd;
        private string O_numWorkHour;
        private string O_amountToPay;
        private string O_status;
        private string O_GraphicArtistKod;
        private string O_numOfMittings;
        public Orders() { }
        public Orders(DataRow drc)
        {
            this.O_Kod = int.Parse(drc["O_Kod"].ToString());
            this.O_clientKod = int.Parse(drc["O_clientKod"].ToString());
            this.O_dateOfOrder = drc["O_dateOfOrder"].ToString();
            this.O_dateOFEnd =drc["O_dateOFEnd"].ToString();
            this.O_numWorkHour = drc["O_numWorkHour"].ToString();
            this.O_amountToPay = drc["O_amountToPay"].ToString();
            this.O_status = drc["O_status"].ToString();
            this.O_GraphicArtistKod = drc["O_GraphicArtistKod"].ToString();
            this.O_numOfMittings = drc["O_numOfMittings"].ToString();

            this.dr = drc;
        }

        public string FO_dateOFEnd
        {
            set
            {
                this.O_dateOFEnd = DateTime.Parse(value).ToShortDateString().ToString();
            }
            get
            {
                return this.O_dateOFEnd;
            }
        }
        public string FO_dateOfOrder
        {
            set
            {
                this.O_dateOfOrder = DateTime.Parse(value).ToShortDateString().ToString();
            }
            get
            {
                return this.O_dateOfOrder;
            }
        }
        public string FO_numWorkHour
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.O_numWorkHour = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.O_numWorkHour;
            }
        }
        public string FO_numOfMittings
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.O_numOfMittings = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.O_numOfMittings;
            }
        }
        public string FO_GraphicArtistKod
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.O_GraphicArtistKod = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.O_GraphicArtistKod;
            }
        }
        public string FO_amountToPay
        {
            set
            {
                if (Legal.IsNumber(value))
                    this.O_amountToPay = value;
                else
                    throw new Exception("הזן מספר בלבד");
            }
            get
            {
                return this.O_amountToPay;
            }
        }
        public int FO_Kod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.O_Kod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.O_Kod;
            }
        }
        public int FO_clientKod
        {
            set
            {
                if (Legal.IsNumber(value.ToString()))
                    this.O_clientKod = value;
                else
                    throw new Exception("קוד לא תקין");
            }
            get
            {
                return this.O_clientKod;
            }
        }
        public string FO_status
        {
            set
            {
                this.O_status = value;
            }
            get
            {
                return this.O_status;
            }
        }
        public void FillDataRow()
        {
            this.dr["O_Kod"] = this.O_Kod;
            this.dr["O_clientKod"] = this.O_clientKod;
            this.dr["O_dateOfOrder"] = this.O_dateOfOrder;
            this.dr["O_dateOFEnd"] = this.O_dateOFEnd;
            this.dr["O_numWorkHour"] = this.O_numWorkHour;
            this.dr["O_amountToPay"] = this.O_amountToPay;
            this.dr["O_status"] = this.O_status;
            this.dr["O_GraphicArtistKod"] = this.O_GraphicArtistKod;
            this.dr["O_numOfMittings"] = this.O_numOfMittings;

        }
    }
}
