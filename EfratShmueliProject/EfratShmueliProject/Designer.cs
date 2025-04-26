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
    public partial class Designer : Form
    {
        public Designer()
        {
            InitializeComponent();
        }

        private void Designer_Load(object sender, EventArgs e)
        {
            pictureBox2.SendToBack();

        }
    }
}
