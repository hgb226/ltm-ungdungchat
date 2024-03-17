using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ltm_ungdungchat
{
    public partial class udp : Form
    {
        public udp()
        {
            InitializeComponent();
        }

        private void udp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            udp_client udpClientForm = new udp_client();
            udpClientForm.FormClosing += (s, args) => this.Show();
            this.Hide();
            udpClientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udp_server udpServerForm = new udp_server();
            udpServerForm.FormClosing += (s, args) => this.Show();
            this.Hide();
            udpServerForm.Show();
        }
    }
}
