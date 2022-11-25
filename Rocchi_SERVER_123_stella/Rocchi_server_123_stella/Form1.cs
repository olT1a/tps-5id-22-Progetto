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
        public Form1()
        {
            InitializeComponent();
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
            StartListening();
        }

        public  void StartListening()
        {
            // Establish the local endpoint for the socket.  
            // Dns.GetHostName returns the name of the   
            // host running the application.  
            IPAddress ipAddress = System.Net.IPAddress.Parse("127.0.0.1");
            IPEndPoint localEndPoint = new IPEndPoint(ipAddress, 5000);

            // Create a TCP/IP socket.  
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

                    MessageBox.Show("Waiting for a connection...");

                    // Program is suspended while waiting for an incoming connection.  
                    Socket handler = listener.Accept();

                    ClientManager clientThread = new ClientManager(handler);
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
        String data = "";

        public ClientManager(Socket clientSocket)
        {
            this.clientSocket = clientSocket;
        }

        public void doClient()
        {

            while (data != "Quit$")
            {
                // An incoming connection needs to be processed.  
                data = "";
                while (data.IndexOf("$") == -1)
                {
                    int bytesRec = clientSocket.Receive(bytes);
                    data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                }

                // Show the data on the console.  
                MessageBox.Show("Messaggio ricevuto : {0} " +  data);
                
                // Echo the data back to the client.  
                byte[] msg = Encoding.ASCII.GetBytes(data);

                clientSocket.Send(msg);
            }
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
            data = "";

        }
    }
}


