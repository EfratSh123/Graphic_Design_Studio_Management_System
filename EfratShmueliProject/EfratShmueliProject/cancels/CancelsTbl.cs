using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.cancels
{
    internal class CancelsTbl : GeneralTbl
    {
        public CancelsTbl() : base("Cancels")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT cancels.CA_kod AS [קוד ביטול], cancels.CA_workerKod AS [קוד עובד], Workers.W_lastName AS [שם], Workers.W_phone AS פלאפון, cancels.CA_dateOfStart AS [תאריך התחלה], cancels.CA_dateOfEnd AS [תאריך סיום], cancels.CA_status AS סטטוס\r\nFROM Workers INNER JOIN cancels ON Workers.W_kod = cancels.CA_workerKod;");

        }
        public DataTable getCancelsForOK()
        {
            return Dal.GetDisplayTable("SELECT cancels.CA_kod AS [קוד ביטול], cancels.CA_workerKod AS [קוד עובד], cancels.CA_dateOfStart AS [תאריך התחלה], cancels.CA_dateOfEnd AS [תאריך סיום], cancels.CA_status AS[סטטוס] FROM cancels WHERE (((cancels.CA_status)='בקשה'));");

        }
        public DataTable getCaTillTime(int graficKod, DateTime datet1 , DateTime datet2)
        {
            string s = datet1.ToString();
            s = s.Substring(0, 10);
            string s2 = datet2.ToString();
            s2 = s2.Substring(0, 10);
            return Dal.GetDisplayTable("SELECT cancels.CA_kod AS [קוד ביטול], cancels.CA_workerKod AS [קוד עובד], Workers.W_lastName AS שם, Workers.W_phone AS פלאפון, cancels.CA_dateOfStart AS [תאריך התחלה], cancels.CA_dateOfEnd AS [תאריך סיום], cancels.CA_status AS סטטוס\r\nFROM Workers INNER JOIN cancels ON Workers.W_kod = cancels.CA_workerKod WHERE (((cancels.CA_workerKod)="+graficKod+") AND ((cancels.CA_dateOfEnd)<='"+s+ "')) AND ((cancels.CA_dateOfEnd)>='"+s2+"');");
        }
        public void UpDateCancel(Cancels cc)
        {
            cc.FillDataRow();
            Dal.Save(table.TableName);
        }
        public void DeleteCancels(Cancels cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddCancel(Cancels cc)
        {
            //יצירת שורה בתבנית של הטבלה
            cc.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            cc.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(cc.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}
