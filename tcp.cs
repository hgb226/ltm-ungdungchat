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
    public partial class tcp : Form
    {
        public tcp()
        {
            InitializeComponent();
        }

        private void tcp_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcp_client tcpClientForm = new tcp_client();
            tcpClientForm.FormClosing += (s, args) => this.Show();
            this.Hide();
            tcpClientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tcp_server tcpServerForm = new tcp_server();
            tcpServerForm.FormClosing += (s, args) => this.Show();
            this.Hide();
            tcpServerForm.Show();
        }
    }
}
