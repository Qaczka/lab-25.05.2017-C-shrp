using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace lab_25._05._2017_C_shrp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void moj_port_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void info_feed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void polacz_Click(object sender, EventArgs e)
        {
            string host = adress.Text;
            int p = Convert.ToInt16(moj_port.Value);
            try
            {
                TcpClient client = new TcpClient(host, p);
                info_feed.Items.Add("Nawiazano polaczenie z" + host + " na porcie:" + moj_port);
                client.Close();
            }
            catch (Exception ex)
            {
                info_feed.Items.Add("Nie mmozna polaczyc error: " + ex.ToString());
            }
        }
    }
}
