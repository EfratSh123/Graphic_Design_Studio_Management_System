using EfratShmueliProject.AllTheUsers;
using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.Schedule
{
    public partial class ViewSchedule : Designer
    {
        string[] dates = new string[5];
        public int kodOrder;
        DateTime date;
        public int kodC;
        string status;
        string kindTor;
        int misT = 0;
        //כדי לבדוק האם פתיחת היומן והוספת פגישה היא דרך עדכון הזמנה
        public bool d = false;
        Orders.OrdersAddUpdate addS;
        public ViewSchedule(string kodO, int kodC, string kindTor, Orders.OrdersAddUpdate addS, int misT)
        {
            InitializeComponent();
            this.kodOrder = int.Parse(kodO);
            this.kodC = kodC;
            this.kindTor = kindTor;
            this.addS = addS;
            this.misT = misT;
        }
        public ViewSchedule(string kodO, int kodC, string kindTor)
        {
            InitializeComponent();
            this.kodOrder = int.Parse(kodO);
            this.kodC = kodC;
            this.kindTor = kindTor;
        }
        public ViewSchedule(int kodC)
        {
            InitializeComponent();
            this.kodC = kodC;
            tableLayoutPanel1.Enabled = true;
            d = true; 
        }
        public ViewSchedule()
        {
            InitializeComponent();
            tableLayoutPanel1.Enabled = true;
        }
        private void AddUpdateSchdule_Load(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
        }
        public void FillSchedule()
        {
            int i = 0;
            string time = "0";

            for (int k = 0; k < tableLayoutPanel1.RowCount; i++, k++)
                for (int j = 0; j < tableLayoutPanel1.ColumnCount; j++)
                {
                    //שעה
                    if (int.Parse(label16.Tag.ToString()) == i)
                    {
                        time = "09:00";
                    }
                    else
                                if (int.Parse(label17.Tag.ToString()) == i)
                    {

                        time = "09:30";
                    }
                    else
                                    if (int.Parse(label18.Tag.ToString()) == i)
                    {
                        time = "10:00";
                    }
                    else
                                        if (int.Parse(label19.Tag.ToString()) == i)
                    {
                        time = "10:30";
                    }
                    else
                                            if (int.Parse(label20.Tag.ToString()) == i)
                        time = "11:00";

                    else
                        if (int.Parse(label11.Tag.ToString()) == i)
                    {
                        time = "11:30";
                    }
                    else
                            if (int.Parse(label12.Tag.ToString()) == i)
                    {
                        time = "12:00";
                    }
                    else
                                if (int.Parse(label13.Tag.ToString()) == i)
                    {

                        time = "12:30";
                    }
                    else
                                    if (int.Parse(label21.Tag.ToString()) == i)
                    {
                        time = "13:00";
                    }
                    else
                                        if (int.Parse(label23.Tag.ToString()) == i)
                    {
                        time = "13:30";
                    }
                    else
                                     if (int.Parse(label22.Tag.ToString()) == i)
                    {
                        time = "14:00";
                    }
                    else
                                        if (int.Parse(label24.Tag.ToString()) == i)
                    {
                        time = "14:30";
                    }

                    UserMeeting u = new UserMeeting(dates[j], time, this);
                    tableLayoutPanel1.Controls.Add(u, j, i);
                }
        }
        private void ViewSchedule_Load(object sender, EventArgs e)
        {
            this.Text = "יומן פגישות";
            dateTimePicker1.MinDate = DateTime.Now;
            CenterToScreen();
            DateChange();
            //DataTable dt = Dal.GetDisplayTable("SELECT mittings.M_kod, mittings.M_date, mittings.M_hour, mittings.M_clientKod, mittings.M_status FROM mittings;");
            //for(int i = 0; i < dt.Rows.Count; i++)
            //{
            //    UserMeeting u = new UserMeeting(dateTimePicker1.Text, label16.Text, this);
            //    tableLayoutPanel1.Controls.Add(u);
            //}
        }
        public void DateChange()
        {
            int mone = 0;
            string day = dateTimePicker1.Value.DayOfWeek.ToString();
            if (label1.Tag.ToString() == day)
            {
                label1.Text = dateTimePicker1.Value.ToShortDateString();
                mone++;
                label2.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                mone++;
                label3.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                mone++;
                label4.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                mone++;
                label5.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                mone++;

            }
            else
            {
                mone--;
                if (label2.Tag.ToString() == day)
                {
                    label2.Text = dateTimePicker1.Value.ToShortDateString();
                    label1.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                    mone++;
                    mone++;
                    label3.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                    mone++;
                    label4.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                    mone++;
                    label5.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                    mone++;

                }
                else
                {
                    mone--;//-2
                    if (label3.Tag.ToString() == day)//יום שלישי? לא
                    {
                        label3.Text = dateTimePicker1.Value.ToShortDateString();
                        label1.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                        mone++;
                        label2.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                        mone++;
                        mone++;
                        label4.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                        mone++;
                        label5.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                        mone++;

                    }
                    else
                    {
                        mone--;//-3
                        if (label4.Tag.ToString() == day)//יןם רביעי?
                        {
                            label4.Text = dateTimePicker1.Value.ToShortDateString();//יום רביעי שווה להיום
                            label1.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();//יום ראשון שוה ליום ראשון
                            mone++;//-2
                            label2.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                            mone++;//-1
                            label3.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                            mone++;//0
                            mone++;//1
                            label5.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                            mone++;

                        }
                        else
                        {
                            mone--;
                            if (label5.Tag.ToString() == day)
                            {
                                label5.Text = dateTimePicker1.Value.ToShortDateString();
                                label1.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label2.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label3.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label4.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                mone++;

                            }

                            else
                            {
                                mone--;

                                label1.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label2.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label3.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label4.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;
                                label5.Text = (dateTimePicker1.Value.AddDays(mone)).ToShortDateString();
                                mone++;

                            }

                        }
                    }
                }
            }
            dates[0] = label1.Text;
            dates[1] = label2.Text;
            dates[2] = label3.Text;
            dates[3] = label4.Text;
            dates[4] = label5.Text;
            tableLayoutPanel1.Controls.Clear();
            FillSchedule();

        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateChange();
        }
    }
}
