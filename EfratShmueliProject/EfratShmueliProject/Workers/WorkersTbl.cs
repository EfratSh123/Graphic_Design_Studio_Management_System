using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Workers
{
    internal class WorkersTbl:GeneralTbl
    {
        public WorkersTbl() : base("Workers")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT Workers.W_kod AS[קוד עובד], Workers.W_lastName AS[שם], Workers.W_phone AS[פלאפון], Workers.W_cityKod AS[קוד עיר], Workers.W_adress AS[כתובת], Workers.W_dateOfBirth AS[תאריך לידה], Workers.W_Mail AS[מייל], Workers.W_status AS[סטטוס], Workers.W_password AS[סיסמת עובד] FROM Workers;");
        }
        public void UpDateWorkers(Workers cl)
        {
            cl.FillDataRow();
            Dal.Save(table.TableName);
        }
        public void DeleteWorkers(Workers cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddWorkwrs(Workers cl)
        {
            //יצירת שורה בתבנית של הטבלה
            cl.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            cl.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(cl.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}
