using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.OrderDeitals
{
    internal class OrderDeitalsTbl :GeneralTbl
    {
        public OrderDeitalsTbl() : base("OrderDetials")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT OrderDetials.DO_kod AS[קוד], OrderDetials.DO_kodOredr AS[קוד הזמנה], OrderDetials.DO_KindOredrKod AS[קוד סוג הזמנה], OrderDetials.DO_Describing AS[תאור], OrderDetials.DO_status AS[סטטוס], OrderDetials.DO_timeWorking AS[משך זמן עבודה] FROM OrderDetials\r\n");
        }
        public void UpDateOrderDeitals(OrderDeitals od)
        {
            od.FillDataRow();
            Dal.Save(table.TableName);
        }
        public DataTable GetProductOfOrder(int code)
        {
            return Dal.GetDisplayTable("SELECT OrderDetials.* FROM OrderDetials where DO_kodOredr=" + code);

        }
        public void DeleteOrderDeitals(OrderDeitals cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddOrderDeitals(OrderDeitals cl)
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
