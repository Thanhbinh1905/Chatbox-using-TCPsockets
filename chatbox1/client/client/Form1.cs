using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnDisCon.Enabled = false;
            btnSendMss.Enabled = false;
            txtbox.Enabled = false;
            btnClearMss.Enabled = false;
        }


        private TcpClient client;
        private NetworkStream clientStream;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            btnDisCon.Enabled = true;
            btnSendMss.Enabled = true;
            txtbox.Enabled = true;
            btnConnect.Enabled = false;
            btnClearMss.Enabled = true;
            Status.Text = "Online";
            client = new TcpClient();
            client.Connect(IPAddress.Parse("127.0.0.1"), 1905);
            clientStream = client.GetStream();

            Thread clientThread = new Thread(new ThreadStart(ReceiveMessages));
            clientThread.Start();

            listBox1.Items.Add("Connected to server");
            
        }

        private void ReceiveMessages()
        {
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
                    // the server has disconnected from the client
                    break;
                }

                // message received
                string data = Encoding.ASCII.GetString(message, 0, bytesRead);
                listBox1.Invoke(new Action(() => listBox1.Items.Add("Server: " + data)));
            }

            client.Close();
            btnConnect.Invoke(new Action(() => btnConnect.Enabled = true));
            listBox1.Invoke(new Action(() => listBox1.Items.Add("Disconnected from server")));
        }

        private void btnSendMss_Click(object sender, EventArgs e)
        {
            string message = "Client: " + txtbox.Text;
            string messagesend = txtbox.Text;
            byte[] data = Encoding.ASCII.GetBytes(messagesend);

            clientStream.Write(data, 0, data.Length);
            clientStream.Flush();

            listBox1.Invoke(new Action(() => listBox1.Items.Add(message)));
            txtbox.Clear();
        }

        private void btnClearMss_Click(object sender, EventArgs e)
        {
            txtbox.Clear();
        }

        private void btnDisCon_Click(object sender, EventArgs e)
        {
            Status.Text = "Offline";
            client.Close();
            listBox1.Invoke(new Action(() => listBox1.Items.Add("Disconnected from server")));
            btnConnect.Enabled = true;
            btnDisCon.Enabled = false;
            btnSendMss.Enabled = false;
            txtbox.Enabled = false;
            btnClearMss.Enabled = false;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
