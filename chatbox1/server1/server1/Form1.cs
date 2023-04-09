using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;
using System.Net;
using System.Threading;

namespace server1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnStop.Enabled = false;
            btnSendMss.Enabled = false;
            txtbox.Enabled = false;
            btnClearMss.Enabled = false;
        }

        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private Thread listenThread;

        private void btnStart_Click(object sender, EventArgs e)
        {
            btnStop.Enabled = true;
            btnSendMss.Enabled = true;
            txtbox.Enabled = true;
            btnClearMss.Enabled = true;

            Status.Text = "Online";
            listener = new TcpListener(IPAddress.Any, 1905);
            listener.Start();

            listenThread = new Thread(new ThreadStart(ListenForClients));
            listenThread.Start();

            listBox1.Items.Add("Server started");
            btnStart.Enabled = false;
        }

        private void ListenForClients()
        {
            while (true)
            {
                TcpClient client = listener.AcceptTcpClient();
                clients.Add(client);
                Thread clientThread = new Thread(new ParameterizedThreadStart(HandleClientComm));
                clientThread.Start(client);
            }
        }

        private void HandleClientComm(object client)
        {
            TcpClient tcpClient = (TcpClient)client;
            NetworkStream clientStream = tcpClient.GetStream();

            byte[] message = new byte[4096];
            int bytesRead;

            while (true)
            {
                bytesRead = 0;

                try
                {
                    // read incoming message
                    bytesRead = clientStream.Read(message, 0, 4096);
                }
                catch
                {
                    // a socket error has occurred
                    break;
                }

                if (bytesRead == 0)
                {
                    // the client has disconnected from the server
                    break;
                }

                // message received
                string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                listBox1.Invoke(new Action(() => listBox1.Items.Add("Client: " + data)));
            }

            clients.Remove(tcpClient);
            tcpClient.Close();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            btnStart.Enabled = true;
            btnStop.Enabled = false;
            btnSendMss.Enabled = false;
            txtbox.Enabled = false;
            btnClearMss.Enabled = false;

            Status.Text = "Offline";
            listener.Stop();
            listenThread.Abort();

            foreach (TcpClient client in clients)
            {
                client.Close();
            }

            clients.Clear();

            listBox1.Items.Add("Server stopped");
            btnStop.Enabled = true;
        }

        private void btnSendMss_Click(object sender, EventArgs e)
        {
            string message = "Server: " + txtbox.Text;
            string messagesend = txtbox.Text;
            byte[] data = Encoding.ASCII.GetBytes(messagesend);

            foreach (var client in clients)
            {
                client.GetStream().Write(data, 0, data.Length);
            }

            listBox1.Invoke(new Action(() => listBox1.Items.Add(message)));
            txtbox.Clear();
        }

        private void btnClearMss_Click(object sender, EventArgs e)
        {
            txtbox.Clear();
        }
    }
}

