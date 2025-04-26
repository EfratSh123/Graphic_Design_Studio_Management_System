using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Orders
{
    internal class OrdersTbl:GeneralTbl
    {
        public OrdersTbl() : base("orders")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT orders.O_Kod AS [קוד הזמנה], clients.C_id AS [תעודת זהות לקוח], clients.C_lastName AS [שם], orders.O_dateOfOrder AS [תאריך ביצוע הזמנה], orders.O_dateOFEnd AS [תאריך הגשת ההזמנה], orders.O_numWorkHour AS [מספר שעות עבודה נוספות], orders.O_amountToPay AS [סכום לתשלום], orders.O_status AS [סטטוס הזמנה], orders.O_numOfMittings AS [מספר פגישות], orders.O_GraphicArtistKod AS[קוד גרפיקאית]\r\nFROM (cities INNER JOIN clients ON cities.CI_kod = clients.C_cityKod) INNER JOIN orders ON clients.C_kod = orders.O_clientKod;");

        }
        public DataTable getReadyOrders()
        {
            return Dal.GetDisplayTable("SELECT orders.O_Kod AS [קוד הזמנה], clients.C_id AS [תעודת זהות לקוח], clients.C_lastName AS [שם], orders.O_dateOfOrder AS [תאריך ביצוע הזמנה], orders.O_dateOFEnd AS [תאריך הגשת ההזמנה], orders.O_numWorkHour AS [מספר שעות עבודה נוספות], orders.O_amountToPay AS [סכום לתשלום], orders.O_status AS [סטטוס הזמנה], orders.O_numOfMittings AS [מספר פגישות], orders.O_GraphicArtistKod AS[קוד גרפיקאית]\r\nFROM (cities INNER JOIN clients ON cities.CI_kod = clients.C_cityKod) INNER JOIN orders ON clients.C_kod = orders.O_clientKod WHERE (((orders.O_status)='בוצע'));");

        }
        public DataTable getalltableOrderByDate()
        {
            return Dal.GetDisplayTable("SELECT orders.O_Kod AS [קוד הזמנה], clients.C_id AS [תעודת זהות לקוח], clients.C_lastName AS [שם], orders.O_dateOfOrder AS [תאריך ביצוע הזמנה], orders.O_dateOFEnd AS [תאריך הגשת ההזמנה], orders.O_numWorkHour AS [מספר שעות עבודה נוספות], orders.O_amountToPay AS [סכום לתשלום], orders.O_status AS [סטטוס הזמנה], orders.O_numOfMittings AS [מספר פגישות], orders.O_GraphicArtistKod AS[קוד גרפיקאית]\r\nFROM (cities INNER JOIN clients ON cities.CI_kod = clients.C_cityKod) INNER JOIN orders ON clients.C_kod = orders.O_clientKod ORDER BY orders.O_dateOfOrder;");

        }
        public DataTable getOrdersForGrafics(int graficKod)
        {
            return Dal.GetDisplayTable("SELECT orders.O_Kod AS [קוד הזמנה], clients.C_id AS [תעודת זהות לקוח], clients.C_lastName AS [שם], orders.O_dateOfOrder AS [תאריך ביצוע הזמנה], orders.O_dateOFEnd AS [תאריך הגשת ההזמנה], orders.O_numWorkHour AS [מספר שעות עבודה נוספות], orders.O_amountToPay AS [סכום לתשלום], orders.O_status AS [סטטוס הזמנה], orders.O_numOfMittings AS [מספר פגישות], orders.O_GraphicArtistKod AS[קוד גרפיקאית]\r\nFROM (cities INNER JOIN clients ON cities.CI_kod = clients.C_cityKod) INNER JOIN orders ON clients.C_kod = orders.O_clientKod WHERE orders.O_GraphicArtistKod = "+graficKod+"");

        }
        public DataTable gettt(int code)
        {
            return Dal.GetDisplayTable("SELECT Workers.W_kod AS[קוד עובד], Workers.W_lastName AS[שם], OrderDetials.DO_status AS[סטטוס פרטי הזמנה], Sum(katalog.k_timeWorking) AS[מספר שעות עבודה שנותרו לה] FROM katalog INNER JOIN (Workers INNER JOIN (orders INNER JOIN OrderDetials ON orders.O_Kod = OrderDetials.DO_kodOredr) ON Workers.W_kod = orders.O_GraphicArtistKod) ON katalog.K_kod = OrderDetials.DO_KindOredrKod GROUP BY Workers.W_kod, Workers.W_lastName, OrderDetials.DO_status HAVING (((Workers.W_kod)=" + code+") AND ((OrderDetials.DO_status)='בשלבי עבודה'));");
        }
        public void DeleteOrders(Orders cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void UpDateOrder(Orders o)
        {
            o.FillDataRow();
            Dal.Save(table.TableName);
        }

        public void AddOrder(Orders o)
        {
            //יצירת שורה בתבנית של הטבלה
            o.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            o.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(o.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}
