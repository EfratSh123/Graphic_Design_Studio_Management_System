using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Mittings
{
    internal class MittingsTbl:GeneralTbl
    {
        public MittingsTbl() : base("Mittings")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT mittings.M_kod AS [קוד פגישה], mittings.M_date AS תאריך, mittings.M_hour AS שעה, clients.C_id AS [תעודת זהות לקוח], clients.C_lastName AS [שם], mittings.M_status AS [סטטוס פגישה] FROM clients INNER JOIN mittings ON clients.C_kod = mittings.M_clientKod ;");
        }
        public DataTable getMittingToday()
        {
            return Dal.GetDisplayTable("SELECT mittings.M_kod AS [קוד פגישה], mittings.M_date AS תאריך, mittings.M_hour AS שעה, clients.C_id AS [תעודת זהות לקוח], clients.C_lastName AS [שם], mittings.M_status AS [סטטוס פגישה] FROM clients INNER JOIN mittings ON clients.C_kod = mittings.M_clientKod WHERE (((mittings.M_date)=Date()));");
        }
        //שאילתה שמביאה את הפגישה לפי זמן ותאריך
        public DataTable getalltableDateHour(string hour, string date)
        {
            return Dal.GetDisplayTable("SELECT mittings.M_kod AS [קוד פגישה], mittings.M_date AS תאריך, mittings.M_hour AS שעה, clients.C_kod AS [קוד לקוח], clients.C_lastName AS [שם], mittings.M_status AS [סטטוס פגישה] FROM clients INNER JOIN mittings ON clients.C_kod = mittings.M_clientKod WHERE mittings.M_hour = '" + hour + "' and mittings.M_date ='" + date + "' ");
        }
        public DataTable getAllMeetingsOfOrder(int kod, string date1, string date2)
        {
            return Dal.GetDisplayTable("SELECT mittings.M_kod AS [קוד פגישה], mittings.M_date AS תאריך, mittings.M_hour AS שעה, clients.C_kod AS [קוד לקוח], clients.C_lastName AS [שם], mittings.M_status AS [סטטוס פגישה] FROM clients INNER JOIN mittings ON clients.C_kod = mittings.M_clientKod WHERE mittings.M_clientKod="+kod+" and cDate(mittings.M_date)<='"+date1+ "' and cDate(mittings.M_date)>='"+date2+ "'");
        }
        public void UpDateMitting(Mittings m)
        {
            m.FillDataRow("shalom");
            Dal.Save(table.TableName);
        }
        public void DeleteMitting(Mittings cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddMitting(Mittings m)
        {
            //יצירת שורה בתבנית של הטבלה
            m.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            m.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(m.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}
