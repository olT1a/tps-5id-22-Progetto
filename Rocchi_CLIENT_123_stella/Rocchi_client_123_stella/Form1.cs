using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;

namespace Rocchi_client_123_stella
{
    public partial class Form1 : Form
    {
        Giocatore p = new Giocatore();
        int data_movimento;      //data
        string data_nickname;
        bool nick_confermato = false;
        bool nick_inviato = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_invia.Visible = false;
            lbl_nick.Visible = false;
            txt_nick.Visible = false;
            pnl_pulsantiera.Visible = false;
            btn_conferma.Visible = false;
            list_errori.Visible = false;
        }

        private void btn_connetti_Click(object sender, EventArgs e)
        {
            btn_invia.Visible = true;
            lbl_nick.Visible = true;
            txt_nick.Visible = true;
            btn_conferma.Visible = true;
        }

        private void btn_invia_Click(object sender, EventArgs e)
        {
            /*Random r = new Random();
            int num = 1000;
            int val;*/
            // btn_connetti.Visible = false;
            //lbl_nick.Visible = false;
            // txt_nick.Visible = false;
            //val = r.Next(num, 5000);
            //MessageBox.Show(val.ToString());
            //tmr_durataMovimento.Interval = val;
            list_errori.Visible = true;
            pnl_pulsantiera.Visible = true;
            txt_nick.Visible = false;
            btn_conferma.Visible = false;
            lbl_nickname.Visible = false;
            lbl_nick.Visible = false;
            startClient();


        }

        private void btn_conferma_Click(object sender, EventArgs e)
        {
            if (txt_nick.Text == "")
            {
                MessageBox.Show("Riempi correttamente i campi");
            }
            else
            {
                p.setNickname(txt_nick.Text);
                //lbl_nickname.Text = p.getNickname().ToString();
                lbl_tipo.Text = p.getNickname().ToString();
                data_nickname = p.getNickname() + "$";
                MessageBox.Show(data_nickname);
                nick_confermato = true;
            }

        }

        private void btn_1t_Click(object sender, EventArgs e)
        {
            data_movimento = 1;
            //si muove per 1 secondo
        }

        private void btn_2t_Click(object sender, EventArgs e)
        {
            data_movimento = 2;
            //si muove per 2 secondi
        }

        private void btn_3t_Click(object sender, EventArgs e)
        {
            data_movimento = 3;
            //si muove per 3 secondi
        }

        private void btn_4t_Click(object sender, EventArgs e)
        {
            data_movimento = 4;
            //si muove per 4 secondi
        }

        private void btn_5t_Click(object sender, EventArgs e)
        {
            data_movimento = 5;
            //si muove per 5 secondi
        }

        private void btn_6t_Click(object sender, EventArgs e)
        {
            data_movimento = 6;
            //si muove per 6 secondi
        }

        private void btn_7s_Click(object sender, EventArgs e)
        {
            data_movimento = 7;
            //si muove per 7 secondi
        }

        private void btn_8s_Click(object sender, EventArgs e)
        {
            data_movimento = 8;
            //si muove per 8 secondi
        }

        private void btn_9t_Click(object sender, EventArgs e)
        {
            data_movimento = 9;
            //si muove per 9 secondi
        }

        private void btn_10t_Click(object sender, EventArgs e)
        {
            data_movimento = 10;
            //si muove per 10 secondi
        }

        private void startClient()
        {
            byte[] bytes = new byte[1024];
            string d1 = data_nickname;
            string d2 = data_movimento.ToString() + "$";
            MessageBox.Show("nickname " + d1);
            MessageBox.Show("Movimento " + d2);
            try
            {
                IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
                IPEndPoint remoteEP = new IPEndPoint(ipAddress, 5000);

                Socket sender = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
 
                try
                {
                    if(nick_confermato == true)
                    {
                        if(nick_inviato == false)
                        {
                            send_nick(sender, remoteEP, d1);
                            nick_inviato = true;
                        }
                        if (nick_inviato == true)
                        {
                            send_movement(sender, remoteEP, d2);
                        }

                    }
                    
                }
                catch (ArgumentNullException ane)
                {
                    list_errori.Items.Add("ArgumentNullException : {0}" + ane.ToString());
                }
                catch (SocketException se)
                {
                    list_errori.Items.Add("SocketException : {0}" + se.ToString());
                }
                catch (Exception e)
                {
                    list_errori.Items.Add("Unexpected exception : {0}" + e.ToString());
                }

            }
            catch (Exception e)
            {
                list_errori.Items.Add(e.ToString());
            }
        }
        private void send_nick(Socket sender, IPEndPoint remoteEP, string d)
        {
            byte[] bytes = new byte[1024];
            sender.Connect(remoteEP);

            list_errori.Items.Add("Socket connected to {0}" + sender.RemoteEndPoint.ToString());
            MessageBox.Show("Socket connected to {0}" + sender.RemoteEndPoint.ToString());
            //while (d1 != "Quit$")
            //{
            byte[] msg = Encoding.ASCII.GetBytes(d);              
            int bytesSent = sender.Send(msg);
            // Receive the response from the remote device.  
            while (d.IndexOf("$") == -1)
            {
                int bytesRec = sender.Receive(bytes);
                d += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            list_errori.Items.Add("Messaggio ricevuto: " + d);
            System.Threading.Thread.Sleep(1000);
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

        private void send_movement(Socket sender, IPEndPoint remoteEP, string d)
        {
            byte[] bytes = new byte[1024];
            sender.Connect(remoteEP);
            string data;
            data = d.ToString();
            list_errori.Items.Add("Socket connected to {0}" + sender.RemoteEndPoint.ToString());
            MessageBox.Show("Socket connected to {0}" + sender.RemoteEndPoint.ToString());
            //while (d1 != "Quit$")
            //{
            byte[] msg = Encoding.ASCII.GetBytes(data);
            int bytesSent = sender.Send(msg);
            // Receive the response from the remote device.  
            while (data.IndexOf("$") == -1)
            {
                int bytesRec = sender.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            list_errori.Items.Add("Messaggio ricevuto: " + data);
            System.Threading.Thread.Sleep(1000);
            sender.Shutdown(SocketShutdown.Both);
            sender.Close();
        }

    }

}
    class Giocatore
    {
        private string nickname;

        public Giocatore()
        {
            nickname = "";
        }
        public void setNickname(string c)
        {
            if (c != "")
            {
                nickname = c;
            }
        }
        public string getNickname()
        {
            return nickname;
        }
    }



