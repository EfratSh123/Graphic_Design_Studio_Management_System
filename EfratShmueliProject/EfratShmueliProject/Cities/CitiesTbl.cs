using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace EfratShmueliProject.Cities
{
    internal class CitiesTbl: GeneralTbl
    {
        public CitiesTbl() : base("Cities")
        { }
        public DataTable getalltable()
        {
            return Dal.GetDisplayTable("SELECT cities.CI_kod AS [קוד עיר], cities.CI_name AS [שם עיר]FROM cities");

        }
        public void UpDateCity(Cities c)
        {
            c.FillDataRow();
            Dal.Save(table.TableName);
        }

        public void DeleteCity(Cities cl)
        {
            cl.dr.Delete();
            Dal.Save(table.TableName);
        }
        public void AddCity(Cities c)
        {
            //יצירת שורה בתבנית של הטבלה
            c.dr = table.NewRow();
            //מכניסה את התכונות של העצם לשורה
            c.FillDataRow();
            //מדביק את השורה שמכילה את התכונות שמכילה העצם החדש לטבלת קטגוריות
            table.Rows.Add(c.dr);
            //עדכון אקסס
            Dal.Save(table.TableName);
        }
    }
}
