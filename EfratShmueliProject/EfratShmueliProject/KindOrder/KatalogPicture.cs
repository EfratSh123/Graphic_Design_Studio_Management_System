using EfratShmueliProject.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfratShmueliProject.KindOrder
{
    public partial class KatalogPicture : Form
    {
        int codeKatalog;
        public KatalogPicture(int katalogKod)
        {
            InitializeComponent();
            codeKatalog = katalogKod;
        }
        private void KatalogPicture_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (codeKatalog == 111)
                pictureBox9.Visible = true;
            if (codeKatalog == 112)
                pictureBox18.Visible = true;
            if (codeKatalog == 113)
                pictureBox3.Visible = true;
            if (codeKatalog == 114)
                pictureBox6.Visible = true;
            if (codeKatalog == 115)
                pictureBox15.Visible = true;
            if (codeKatalog == 116)
                pictureBox14.Visible = true;
            if (codeKatalog == 117)
                pictureBox4.Visible = true;
            if (codeKatalog == 118)
                pictureBox13.Visible = true;
            if (codeKatalog == 119)
                pictureBox8.Visible = true;
            if (codeKatalog == 120)
                pictureBox10.Visible = true;
            if (codeKatalog == 121)
                pictureBox11.Visible = true;
            if (codeKatalog == 122)
                pictureBox7.Visible = true;
            if (codeKatalog == 123)
            {
                pictureBox12.Visible = true;
                pictureBox16.Visible = true;
            }
            if (codeKatalog == 124)
                pictureBox17.Visible = true;
            if (codeKatalog == 125)
                pictureBox5.Visible = true;

        }
    }
}
