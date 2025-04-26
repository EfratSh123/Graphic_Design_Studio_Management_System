using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//ייבוא ספריות
using System.Data;
//ספריה המטפלת בניהול נתונים באקסס
using System.Data.OleDb;
using System.Windows.Forms;
//אוספים ספריית ייבוא
using System.Collections;

namespace EfratShmueliProject.Classes
{
    class GeneralTbl
    {
        protected DataTable table;
        public GeneralTbl(string tableName)
        {
            Classes.Dal.AddTable(tableName);
            this.table = Classes.Dal.GetTable(tableName);
        }
        public DataTable GetTable()
        {
            return this.table;
        }
        public int GetNext(string cellName, string tableName)
        {
            int mis = 0;
            DataTable dt = Dal.GetDisplayTable("select max(" + cellName + ") from " + tableName);
            if (dt.Rows.Count > 0)
            {
                mis = int.Parse(dt.Rows[0][0].ToString());
                mis = mis + 1;
            }
            else
                mis = 1;
            return mis;

        }

        public DataRow Find(string cellName, object value)
        {
            foreach (DataRow dr in table.Rows)
            {
                if (dr[cellName].ToString() == value.ToString())
                    return dr;
            }
            return null;
        }
        //פעולה להחזרת ערך המפתח הראשי
        public int GetNext(string cellName)
        {
            DataTable dt = Dal.GetDisplayTable("select max(" + cellName + ") from " + table.TableName);
            if (dt.Rows[0][0] is DBNull)
                return 1;
            int mis = Convert.ToInt32(dt.Rows[0][0]);
            return ++mis;
        }
    }
}
