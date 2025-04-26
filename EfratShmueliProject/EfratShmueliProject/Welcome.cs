using EfratShmueliProject.Cities;
using EfratShmueliProject.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject
{
    public partial class Welcome : Form
    {
        Form1 f1;
        WorkersTbl wtbl = new WorkersTbl();
        public Welcome()
        {
            InitializeComponent();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            pictureBox1.SendToBack();
            this.Text = "ברוכים הבאים";
            comboBox1.Visible = false;
            FillCmbGrafics();
        }

        private void rbGrafics_CheckedChanged(object sender, EventArgs e)
        {
            if (rbGrafics.Checked)
                comboBox1.Visible = true;
            else
                comboBox1.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void FillCmbGrafics()
        {
            comboBox1.SelectedIndexChanged -= comboBox1_SelectedIndexChanged;
            comboBox1.DataSource = wtbl.getalltable();
            comboBox1.DisplayMember = "שם";
            comboBox1.ValueMember = "קוד עובד";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            comboBox1.SelectedIndex = 0;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {                    
            if (rbPricipal.Checked)
            {
                if (textBox1.Text == Properties.Settings.Default.s1)
                {
                    f1 = new Form1("Pricipal");
                    f1.ShowDialog();
                    textBox1.Text = "";
                    //this.Close();
                }
                else
                {
                    MessageBox.Show(".סיסמת מנהל שגויה, נסה שנית");
                    textBox1.Text = "";
                }
            }
            else
            {
                if(rbsecretary.Checked)
                {
                    if (textBox1.Text == Properties.Settings.Default.s2)
                    {
                        f1 = new Form1("secretary");
                        f1.ShowDialog();
                        textBox1.Text = "";
                        //this.Close();

                    }
                    else
                    {
                        MessageBox.Show(".סיסמת מזכירה שגויה, נסה שנית");
                        textBox1.Text = "";
                    }
                }
                else
                {
                    DataRow dr = wtbl.Find("W_lastName", comboBox1.Text);
                    if (textBox1.Text == dr[9].ToString())
                    {
                        f1 = new Form1(dr[1].ToString());
                        f1.ShowDialog();
                        textBox1.Text = "";
                        //this.Close();

                    }
                    else
                    {
                        MessageBox.Show(".סיסמת גרפיקאית שגויה, נסה שנית");
                        textBox1.Text = "";
                    }
                }
            }
        }
    }
}
