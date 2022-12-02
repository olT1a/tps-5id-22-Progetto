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

namespace Rocchi_server_123_stella
{
    public partial class Form1 : Form
    {
        public static string data = null;
        int client_connessi = 0;
        public List<Giocatore> player_list = new List<Giocatore>();

        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void btn_fermi_Click(object sender, EventArgs e)
        {
            pic_arbitro.Image = Image.FromFile(@".\\arbitro2.jpg");

            tmr_controllo.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panel_campo.Visible = false;
            btn_fermi.Visible = false;
        }

        private void tmr_controllo_Tick(object sender, EventArgs e)
        {
            pic_arbitro.Image = Image.FromFile(@".\\arbitro1.jpg");
            tmr_controllo.Stop();
        }

        private void btn_attiva_Click(object sender, EventArgs e)
        {
            panel_campo.Visible = true;
            btn_fermi.Visible = true;
            Thread t = new Thread(new ThreadStart(StartListening));
            t.Start();
        }

        public void StartListening()
        {
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //MessageBox.Show("Timeout : {0} " + listener.ReceiveTimeout);

            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                while (true)
                {
                    Socket handler = listener.Accept();
                    client_connessi++;
                    //MessageBox.Show("CLIENT CONNESSI: " + client_connessi.ToString());
                    ClientManager clientThread = new ClientManager(handler, this, client_connessi, player_list);
                    Thread t = new Thread(new ThreadStart(clientThread.doClient));
                    t.Start();
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }

    }
    public class ClientManager
    {
        Socket clientSocket;
        byte[] bytes = new Byte[1024];
        string data = "";
        Form1 f1;
        int movimento;
        int connected_client = 0;
        bool nick_settati = false;
        List<Giocatore> gio;

        public ClientManager(Socket clientSocket, Form1 f, int c, List<Giocatore> lista)
        {
            this.clientSocket = clientSocket;
            this.f1 = f;
            this.connected_client = c;
            this.gio = lista;

        }

        public void doClient()
        {
            if (nick_settati == false)
            {
                //while (count != 2) {
                data = "";
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
                data = data.Substring(0, data.Length - 1);
                Giocatore g = new Giocatore();

                g.set_nick(data);
                gio.Add(g);
                foreach (Giocatore goi in gio)
                {
                    MessageBox.Show(goi.get_nick());
                }
                MessageBox.Show(gio.Count.ToString());

                MessageBox.Show("valore booleano: " + nick_settati.ToString());
                set_player(gio, connected_client);
                byte[] msg = Encoding.ASCII.GetBytes(data);
                clientSocket.Send(msg);
                nick_settati = true;
                data = "";
            }
            if (nick_settati == true)
            {
                move(gio);
                data = "";
            }
            

            

            //}



        }
        public void set_player(List<Giocatore> p, int count)
        {
            switch (p.Count)
            {
                case 0:
                    break;
                case 1:
                    f1.lbl_g1.Text = p[0].get_nick();
                    break;
                case 2:
                    f1.lbl_g1.Text = p[0].get_nick();
                    f1.lbl_g2.Text = p[1].get_nick();
                    break;
            }
        }

        public void move(List<Giocatore> p)
        {
            //int bytesRec = 0;
            while (data.IndexOf("$") == -1)
            {
                int bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            data = data.Substring(0, data.Length - 1);
            p[0].set_movement(data);
            MessageBox.Show("movimento da eseguire: " + p[0].get_movement()); 
           for (int i = 0; i < Convert.ToInt32(p[0].get_movement()); i++)
           {
                f1.lbl_mov_G1.Text += "-";
                var pause = Task.Delay(1000);
                pause.Wait();
           }
        }
        public bool end_game()
        {
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            return true;
        }
    }

    public class Giocatore
    {
        string nickname;
        string movimento;

        public Giocatore()
        {
            nickname = "";
            movimento = "";
        }
        public void set_nick(string n)
        {
            nickname = n;
        }
        public void set_movement(string m)
        {
            movimento = m;
        }
        public string get_nick()
        {
            return nickname;
        }
        public string get_movement()
        {
            return movimento;
        }

    }
}


