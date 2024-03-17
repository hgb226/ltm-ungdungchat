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
    public partial class udp_client : Form
    {
        public udp_client()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (UdpClient udpClient = new UdpClient())
            {
                IPAddress ipadd = IPAddress.Parse(textBox1.Text);
                int port = Convert.ToInt32(textBox2.Text);
                IPEndPoint ipend = new IPEndPoint(ipadd, port);
                Byte[] sendBytes = Encoding.UTF8.GetBytes(richTextBox1.Text);
                udpClient.Send(sendBytes, sendBytes.Length, ipend);
                richTextBox1.Text = "";
            }
        }

        private void udp_client_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Dispose();
        }
    }
}
