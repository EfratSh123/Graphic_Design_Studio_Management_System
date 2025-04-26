using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.KindOrder
{
    internal class KindOrderTbl : GeneralTbl
    {
        public KindOrderTbl() : base("katalog")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT katalog.K_kod AS [קוד מוצר בקטלוג], katalog.K_describing AS [תאור ], katalog.K_price AS [מחיר], katalog.k_timeWorking AS [מספר שעות עבודה]\r\nFROM katalog;\r\n");

        }
        public void UpDateKindOrder(KindOrder k)
        {
            k.FillDataRow();
            Dal.Save(table.TableName);
        }
        public void DeleteKindOrder(KindOrder cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddKindOrder(KindOrder k)
        {
            //יצירת שורה בתבנית של הטבלה
            k.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            k.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(k.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}