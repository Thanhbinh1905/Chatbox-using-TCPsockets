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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class ConnectToServer : Form
    {
        public ConnectToServer()
        {
            InitializeComponent();
        }

        private void ConnectToServer_Load(object sender, EventArgs e)
        {

        }

        private async void Connect_Click(object sender, EventArgs e)
        {

            string nickname = textBox1.Text;
            string ipAddressStr = txtIP.Text;
            int port = int.Parse(txtPort.Text);

            try
            {
                // Create a new TCP client and connect to server IP and port
                TcpClient client = new TcpClient();
                await client.ConnectAsync(ipAddressStr, port);

                MessageBox.Show("Connected to the server: " + ipAddressStr + "/" + port);

                // Open the client form and pass the nickname as a parameter
                ClientBoxchat clientForm = new ClientBoxchat(nickname, ipAddressStr, port);
                clientForm.Show();

                // Hide the nickname form
                this.Hide();
            }
            catch (SocketException)
            {
                // failed to connect to server stream
                MessageBox.Show("Failed to connect to the server");
            }
        }
    }
}
