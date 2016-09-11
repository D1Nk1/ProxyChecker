using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProxyChecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            for (i = 0; i < richTextBox1.Lines.Count(); i++)
            {
                Ping pingsend = new Ping();
                PingReply reply = pingsend.Send(richTextBox1.Lines[i]);
                richTextBox2.AppendText("Status: " + reply.Status.ToString() + " Ping: " + reply.RoundtripTime.ToString() + "\n");
            }
        }
    }
}
