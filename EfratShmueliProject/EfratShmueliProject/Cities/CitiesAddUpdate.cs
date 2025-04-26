using EfratShmueliProject.Clients;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace EfratShmueliProject.Cities
{
    public partial class CitiesAddUpdate : Designer
    {
        //ClientsTbl cTbl = new ClientsTbl();
        CitiesTbl cbb = new CitiesTbl();
        Cities c;
        string status;
        public CitiesAddUpdate()
        {
            InitializeComponent();
            status = "Add";
            c = new Cities();

        }
        public CitiesAddUpdate(int CI_name)
        {
            InitializeComponent();
            status = "Update";
            DataRow dr = cbb.Find("CI_kod", CI_name);
            c = new Cities(dr);
            FillForm();
        }
        public void FillForm()
        {
            txtbkodCity.Text = c.FCi_code.ToString();
            txtbNameCity.Text = c.FCi_name.ToString();
            AddCitiy.Text = "עדכון";

        }
        private void CitiesAddUpdate_Load(object sender, EventArgs e)
        {
            CenterToScreen();
            if (status == "Add")
            {
                this.Text = "הוספת עיר";
                txtbkodCity.Text = cbb.GetNext("CI_kod").ToString();
            }
            else
                this.Text = "עדכון עיר";

        }
        private void txtkodCity_TextChanged(object sender, EventArgs e)
        {

        }
        public bool CheckLegal()
        {
            ErpNameCity.Clear();
            bool degel = true;
            c.FCi_code = int.Parse(txtbkodCity.Text);
            if (txtbNameCity.Text != "" && txtbNameCity.Text.Length >= 2)
            {
                try
                {
                    c.FCi_name = txtbNameCity.Text;
                }
                catch (Exception ex1)
                {
                    ErpNameCity.SetError(txtbNameCity, ex1.Message);
                    degel = false;
                }
            }
            else
            {
                txtbNameCity.BackColor = Color.LightSalmon;
                degel = false;
            }
            return degel;
        }
        private void AddCitiy_Click(object sender, EventArgs e)
        {
            if (CheckLegal())
            {
                if (status == "Add")
                {
                    cbb.AddCity(c);
                }
                else
                {
                    cbb.UpDateCity(c);
                }
                this.Close();
            }
        }

        private void txtbNameCity_TextChanged(object sender, EventArgs e)
        {
            if (txtbNameCity.BackColor == Color.LightSalmon)
                txtbNameCity.BackColor = Color.White;
        }
    }
}
