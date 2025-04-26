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
   public class Dal
    {
        //מופע המכיל את הנתיב למסד נתונים
        private static OleDbConnection con;
        //מופע המכיל עותק של הטבלאןת באקסס
        public static DataSet ds;

        public static Hashtable adapters = new Hashtable();
        //פעולה בונה
        static Dal()
        {
            //להתאים את הנתיב לכל מחשב
            string path = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Application.StartupPath + @"\DataBase\efratSmueliProject.mdb;Persist Security Info=True";
            //הגדרת con כאחראי על הנתיב
            con = new OleDbConnection(path);
            //הקצאת מקום לדאטא-סט
            ds = new DataSet();
        }
        public static void AddTable(string tableName)
        {
            if (!ds.Tables.Contains(tableName))
            {
                //נוסע להביא את הטבלה
                OleDbDataAdapter adapter = new OleDbDataAdapter("select * from " + tableName, con);
                //יוצר משפטי הוספה, עדכון ומחיקה
                OleDbCommandBuilder builder = new OleDbCommandBuilder(adapter);

                //הוספה
                adapter.InsertCommand = builder.GetInsertCommand();
                //עדכון
                adapter.UpdateCommand = builder.GetUpdateCommand();
                //מחיקה
                adapter.DeleteCommand = builder.GetDeleteCommand();
                adapters.Add(tableName, adapter);

                //מדביק את הטבלה ומשפטי הסלקט על הדטא-סט
                adapter.Fill(ds, tableName);
            }

        }
        public static DataTable GetTable(string tableName)
        {
            return ds.Tables[tableName];
        }
        public static DataTable GetDisplayTable(string sqlSelect)
        {
            DataTable dt = new DataTable();
            OleDbDataAdapter adapter = new OleDbDataAdapter(sqlSelect, con);
            adapter.Fill(dt);
            return dt;
        }
        public static void Save(string tableName)
        {
            OleDbDataAdapter adapter = (OleDbDataAdapter)adapters[tableName];
            adapter.Update(ds, tableName);
        }
 
    }
}
