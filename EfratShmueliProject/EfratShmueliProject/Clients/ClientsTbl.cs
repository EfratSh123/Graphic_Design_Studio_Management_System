using EfratShmueliProject.Cities;
using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Clients
{
    internal class ClientsTbl: GeneralTbl
    {
        public ClientsTbl() : base("Clients")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT clients.C_kod AS [קוד לקוח], clients.C_id AS [תעודת זהות], clients.C_lastName AS [שם], cities.CI_name AS [עיר], clients.C_adress AS [כתובת], clients.C_eMail AS [מייל], clients.C_pel AS [פלאפון], clients.C_status AS [סטטוס] FROM cities INNER JOIN clients ON cities.CI_kod = clients.C_cityKod;");

        }
        public void UpDateClients(Clients cl)
        {
            cl.FillDataRow();
            Dal.Save(table.TableName);
        }
        public void DeleteClient(Clients cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddClients(Clients cl)
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
