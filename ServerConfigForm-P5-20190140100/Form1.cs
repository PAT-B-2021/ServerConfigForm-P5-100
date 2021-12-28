using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ServerConfigForm_P5_20190140100
{
    public partial class Form1 : Form
    {
        public ServiceHost Host;
        private object labelOnOrOff;
        private object labelKet;
        private object button1;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            buttonOn.Enabled = true;
            buttonOff.Enabled = false;
            Host.Open();
            this.labelKeterangan.Text = "Klik ON untuk Menjalankan Server";
            this.labelOnOff.Text = "Server OFF";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Host = new ServiceHost(typeof(Matematika));

            this.labelOnOff.Text = "Server ON";
            this.labelKeterangan.Text = "Klik OFF untuk Mematikan Server";
            Host.Close();
            buttonOn.Enabled = false;
            buttonOff.Enabled = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void labelOnOff_Click(object sender, EventArgs e)
        {

        }
    }
}
