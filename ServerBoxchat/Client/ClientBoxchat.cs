using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Client
{
    public partial class ClientBoxchat : Form
    {

        // Declare variables for TCP client and network stream
        private TcpClient client;
        private Thread receiveThread;
        private NetworkStream stream;
        private string nickname;
        private string ipAddress;
        private int port;
        public ClientBoxchat(string nickname, string ipAddress, int port)
        {
            InitializeComponent();

            // Save the nickname for later use
            this.nickname = nickname;
            this.ipAddress = ipAddress;
            this.port = port;
            try
            {
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(nickname + " Has connected to the server!!");
                stream.Write(data, 0, data.Length);
                receiveThread = new Thread(new ThreadStart(ReceiveMessages));
                receiveThread.Start();
                listBox1.Items.Add("Connected to the server.");
                Status.Text = $"Online server {ipAddress}:{port}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message);
                this.Close();
            }
            // Set the form title to include the nickname
            this.Text = "Chat Client - " + nickname;

            btnConnect.Enabled = false;
        }


        private void ReceiveMessages()
        {
            // Create a byte array to store incoming message
            byte[] message = new byte[4096];
            int bytesRead;

            // Continuously read incoming messages until socket error or server disconnects
            while (true)
            {
                bytesRead = 0;

                try
                {
                    // Read incoming message from network stream
                    bytesRead = stream.Read(message, 0, 4096);
                }
                catch
                {
                    // A socket error has occurred, break out of the loop
                    break;
                }

                if (bytesRead == 0)
                {
                    // The server has disconnected from the client, break out of the loop
                    break;
                }

                // Message received, convert byte array to string and add it to the list box
                string datareceived = Encoding.ASCII.GetString(message, 0, bytesRead);
                listBox1.Invoke(new Action(() => listBox1.Items.Add(datareceived)));
            }

            // Close the client connection and update the UI
            client.Close();
            
            listBox1.Invoke(new Action(() => listBox1.Items.Add("Disconnected from server")));
        }

        private void btnSendMss_Click(object sender, EventArgs e)
        {
            // Construct message to send and convert to byte array
            if (client.Connected)
            {
                string message = nickname + ": " +txtbox.Text.Trim();
                if (!string.IsNullOrEmpty(message))
                {
                    byte[] data = Encoding.ASCII.GetBytes(message);
                    stream.Write(data, 0, data.Length);
                    listBox1.Items.Add(message);
                    txtbox.Clear();
                }
            }
            else
            {
                btnConnect.Enabled = true;
                btnDisCon.Enabled = false;
                listBox1.Invoke(new Action(() => listBox1.Items.Add("Disconnected from the server.")));
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btnDisCon_Click_1(object sender, EventArgs e)
        {
            // Update UI and close client connection
            Status.Text = "Offline";

            byte[] data = Encoding.ASCII.GetBytes(nickname + " Has disconnected");
            stream.Write(data, 0, data.Length);

            client.Close();
            btnDisCon.Enabled = false;
            btnSendMss.Enabled = false;
            txtbox.Enabled = false;
            btnClearMss.Enabled = false;
            btnConnect.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                client = new TcpClient(ipAddress, port);
                stream = client.GetStream();
                byte[] data = Encoding.ASCII.GetBytes(nickname + " Has connected to the server!!");
                stream.Write(data, 0, data.Length);
                receiveThread = new Thread(new ThreadStart(ReceiveMessages));
                receiveThread.Start();
                listBox1.Items.Add("Connected to the server.");
                btnDisCon.Enabled=true;
                btnConnect.Enabled=false;
                txtbox.Enabled=true;
                btnSendMss.Enabled=true;
                btnClearMss.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to the server: " + ex.Message);
                this.Close();
            }
        }

        private void btnClearMss_Click(object sender, EventArgs e)
        {
            txtbox.Clear();
        }
    }
}
