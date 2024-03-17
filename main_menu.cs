namespace ltm_ungdungchat
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tcp tcpForm = new tcp();
            tcpForm.FormClosing += (s, args) => this.Show();
            this.Hide();
            tcpForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            udp udpForm = new udp();
            udpForm.FormClosing += (s, args) => this.Show();
            this.Hide();
            udpForm.Show();
        }
    }
}
