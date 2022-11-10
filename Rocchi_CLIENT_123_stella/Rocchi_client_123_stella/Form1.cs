using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rocchi_client_123_stella
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_invia.Visible = false;
            lbl_nick.Visible = false;
            txt_nick.Visible = false;
        }

        private void btn_connetti_Click(object sender, EventArgs e)
        {
            btn_invia.Visible = true;
            lbl_nick.Visible = true;
            txt_nick.Visible = true;
        }
    }
}
