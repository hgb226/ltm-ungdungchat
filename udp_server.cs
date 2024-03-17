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
    public partial class udp_server : Form
    {
        public udp_server()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int port = int.Parse(textBox1.Text);
            UdpClient udpClient = new UdpClient(port);
            IPEndPoint IpEnd = new IPEndPoint(IPAddress.Any, 0);
            Byte[] recvBytes = udpClient.Receive(ref IpEnd);
            string Data = Encoding.UTF8.GetString(recvBytes);
            string mess = IpEnd.Address.ToString() + ":" +
            IpEnd.Port.ToString() + ": " + Data.ToString();
            richTextBox1.AppendText(mess + "\n");
            udpClient.Close();
        }

        private void udp_server_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Dispose();
        }
    }
}
