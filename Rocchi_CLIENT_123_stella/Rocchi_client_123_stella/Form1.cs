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
        Player p = new Player();
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

        private void btn_invia_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int num = 0;
            int val; 
            if(txt_nick.Text == "")
            {
                MessageBox.Show("Riempi correttamente i campi");
            }
            else
            {
                p.setNickname(txt_nick.Text);
                //p.getNickname();
                MessageBox.Show(p.getNickname());
            }

            btn_connetti.Visible = false;
            lbl_nick.Visible = false;
            txt_nick.Visible = false;
            val = r.Next(num, 5000);
            MessageBox.Show(val.ToString());
            tmr_durataMovimento.Interval = val;

        }
    }

    class Player
    {
        private string nickname;

        public Player()
        {
            nickname = "";
        }
        public void setNickname(string c)
        {
            if(c != "")
            {
                nickname = c;
            }
        }
        public string getNickname()
        {
            return nickname;
        }
    }
}
