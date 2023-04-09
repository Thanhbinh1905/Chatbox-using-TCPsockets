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


namespace ServerBoxchat
{
    public partial class BoxchatAdmin : Form
    {
        TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private Thread listenThread;
        public BoxchatAdmin()
        {
            InitializeComponent();

            txtbox.Enabled = false;
            btnClearMss.Enabled = false;
            btnSendMss.Enabled = false;
            StopServer.Enabled = false;
        }

        private void ListenForClients()
        {
            while (true)
            {
                //listen for new clients and add them to the list of clients
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
                listBox1.Invoke(new Action(() => listBox1.Items.Add(data)));

                // forward message to other clients
                byte[] dataBytes = Encoding.ASCII.GetBytes(data);

                foreach (var otherClient in clients)
                {
                    if (otherClient != tcpClient)
                    {
                        otherClient.GetStream().Write(dataBytes, 0, dataBytes.Length);
                    }
                }
            }

            clients.Remove(tcpClient);
            tcpClient.Close();
        }

        private void btnSendMss_Click(object sender, EventArgs e)
        {
            if (txtbox.Text != "")
            {
                string message = textBox1.Text + "(Admin): " + txtbox.Text;
                byte[] data = Encoding.ASCII.GetBytes(message);

                foreach (var client in clients)
                {
                    client.GetStream().Write(data, 0, data.Length);
                }

                listBox1.Invoke(new Action(() => listBox1.Items.Add(message)));
                txtbox.Clear();
            }
        }

        private void btnClearMss_Click(object sender, EventArgs e)
        {
            txtbox.Clear();
        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            StopServer.Enabled = true;
            txtbox.Enabled = true; btnClearMss.Enabled = true; btnSendMss.Enabled = true;

            string ipAddressStr = txtIP.Text;
            int port = int.Parse(txtPort.Text);

            IPAddress ipAddress;
            if (!IPAddress.TryParse(ipAddressStr, out ipAddress))
            {
                MessageBox.Show("Invalid IP address format");
                return;
            }

            try
            {
                listener = new TcpListener(ipAddress, port);
                listener.Start();

                listenThread = new Thread(new ThreadStart(ListenForClients));
                listenThread.Start();

                MessageBox.Show($"Server started on {ipAddress}:{port}");

                lbStatus.Text = $"Online server {ipAddress}:{port}";

                textBox1.Enabled = false;
                txtIP.Enabled = false;
                txtPort.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}");
            }
        }

        private void StopServer_Click(object sender, EventArgs e)
        {
            Start.Enabled = true; StopServer.Enabled = false; textBox1 .Enabled = true; txtIP.Enabled = true; txtPort.Enabled = true; 
            lbStatus.Text = "Offline";

            listener.Stop();
            listenThread.Abort();

            foreach (var client in clients)
            {
                client.Close();
            }

            clients.Clear();

            listBox1.Items.Add("Server stopped");
        }
    }
}

/*
 * using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerBoxchat
{
    public partial class Form1 : Form
    {
        private TcpListener listener;
        private List<TcpClient> clients = new List<TcpClient>();
        private Thread listenThread;

        public Form1()
        {
            InitializeComponent();

            this.Text = "Server";

            StopServer.Enabled = false;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            Start.Enabled = false;
            StopServer.Enabled = true;

            string nickname = textBox1.Text;
            string ipAddressStr = txtIP.Text;
            int port = int.Parse(txtPort.Text);

            IPAddress ipAddress;
            if (!IPAddress.TryParse(ipAddressStr, out ipAddress))
            {
                MessageBox.Show("Invalid IP address format");
                return;
            }

            try
            {
                listener = new TcpListener(ipAddress, port);
                listener.Start();

                listenThread = new Thread(new ThreadStart(ListenForClients));
                listenThread.Start();

                MessageBox.Show($"Server started on {ipAddress}:{port}");

                lbStatus.Text = $"Online server {ipAddress}:{port}";

                BoxchatAdmin clientForm = new BoxchatAdmin(nickname, listener);
                clientForm.Show();


            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error starting server: {ex.Message}");
            }
        }


        private void StopServer_Click(object sender, EventArgs e)
        {
            Start.Enabled = true; StopServer.Enabled = false;
            lbStatus.Text = "Offline";

            listener.Stop();
            listenThread.Abort();

            foreach (TcpClient client in clients)
            {
                client.Close();
            }

            clients.Clear();
        }
    }
}

 */