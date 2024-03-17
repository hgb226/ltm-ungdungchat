using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltm_ungdungchat
{
    public partial class tcp_server : Form
    {
        public tcp_server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = int.Parse(textBox1.Text);
            TcpListener tcpListener = new TcpListener(IPAddress.Any, port);
            tcpListener.Start();
            TcpClient client = tcpListener.AcceptTcpClient();
            NetworkStream stream = client.GetStream();
            byte[] receiveData = new byte[1024];
            int bytesRead = stream.Read(receiveData, 0, receiveData.Length);
            string receivedMessage = Encoding.UTF8.GetString(receiveData, 0, bytesRead);
            richTextBox1.AppendText(receivedMessage + "\n");
            client.Close();
            tcpListener.Stop();
        }
    }
}
