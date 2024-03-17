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
    public partial class tcp_client : Form
    {
        public tcp_client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (TcpClient tcpClient = new TcpClient())
            {
                IPAddress ipAddress = IPAddress.Parse(textBox1.Text);
                int port = int.Parse(textBox2.Text);
                tcpClient.Connect(ipAddress, port);
                NetworkStream stream = tcpClient.GetStream();
                byte[] sendData = Encoding.UTF8.GetBytes(richTextBox1.Text);
                stream.Write(sendData, 0, sendData.Length);
                richTextBox1.Clear();
                tcpClient.Close();
            }
        }
    }
}
