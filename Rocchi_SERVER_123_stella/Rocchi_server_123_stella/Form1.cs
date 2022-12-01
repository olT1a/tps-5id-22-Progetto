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

        public  void StartListening()
        {  
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);
  
            Socket listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            MessageBox.Show("Timeout : {0} " +  listener.ReceiveTimeout);

            // Bind the socket to the local endpoint and   
            // listen for incoming connections.  
            try
            {
                listener.Bind(localEndPoint);
                listener.Listen(10);

                // Start listening for connections.  
                while (true)
                {
                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();
                    client_connessi++;
                    MessageBox.Show("CLIENT CONNESSI: " + client_connessi.ToString());
                    ClientManager clientThread = new ClientManager(handler, this, client_connessi);
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
        List<string> utenti = new List<string>();
        Form1 f1;
        int movimento;
        int connected_client = 0;
     
        public ClientManager(Socket clientSocket, Form1 f, int c)
        {
            this.clientSocket = clientSocket;
            this.f1 = f;
            this.connected_client = c;
        }

        public void doClient()
        {
            //while (count != 2) {
                data = "";
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }
                data = data.Substring(0, data.Length - 1);
                utenti.Add(data);
                byte[] msg = Encoding.ASCII.GetBytes(data);
                clientSocket.Send(msg);
            //}
            /*clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();*/
            data = "";
            set_player(utenti, connected_client);
            //move();
            



        }
        public void set_player(List<string> p, int count)
        {
            switch (count)
            {
                case 0:
                    break;
                case 1:
                    //if (f1.lbl_g1.Text == "G1")
                    //{
                        f1.lbl_g1.Text = p[0];
                   // }
                    //else
                    //{
                    //    f1.lbl_g2.Text = p[0];
                    //}
                    break;
                case 2:
                    //if (f1.lbl_g1.Text != "G!")
                    //{
                        f1.lbl_g1.Text = p[0];
                        f1.lbl_g2.Text = p[1];
                   // }
                    break;
            }
        }

        public void move()
        {
            int bytesRec = 0;
            while (data.IndexOf("$") == -1)
            {
                bytesRec = clientSocket.Receive(bytes);
                data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
            }
            data = data.Substring(0, data.Length - 1);
            movimento = int.Parse(data);
            for(int i = 0; i < movimento; i++)
            {
                f1.lbl_mov_G1.Text += "-";
                var pause = Task.Delay(1000);
                pause.Wait();
            }
        }
    }
}


