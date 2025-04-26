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
    class SmartSreach
    {
        public static DataTable Search(DataTable table, object valueToSearsh)
        {
            DataTable dt = new DataTable();
            for (int i = 0; i < table.Columns.Count; i++)
            {
                dt.Columns.Add(table.Columns[i].ColumnName);
            }
            DataRow dr1;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                dr1 = table.Rows[i];
                if (IsFind(dr1, valueToSearsh))
                    CopyRow(dt, dr1);
            }
            return dt;
        }
        public static void CopyRow(DataTable table, DataRow row)
        {
            object[] values = new object[table.Columns.Count];
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = row[i];
            }
            table.Rows.Add(values);
        }
        public static bool IsFind(DataRow dr, object valueToSearsh1)
        {
            bool ok = false;
            for (int i = 0; i < dr.Table.Columns.Count; i++)
            {

                if (dr[i].ToString().Contains(valueToSearsh1.ToString()))
                {
                    ok = true;
                    break;
                }
            }
            return ok;

        }
    }
}
