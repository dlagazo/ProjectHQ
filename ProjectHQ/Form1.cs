using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace ProjectHQ
{
    public partial class Form1 : Form
    {
        SerialPort sp;
        public Form1()
        {
            InitializeComponent();
            sp = spCom;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if(!sp.IsOpen)
            {
                sp = new SerialPort(txtPort.Text, 57600, Parity.None,8, StopBits.One);
                sp.ReadBufferSize = sp.ReadBufferSize * 10;
                sp.Handshake = Handshake.None;
                //sp.PortName = "COM" + txtPort.Text;
                sp.Open();
                sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
                if(sp.IsOpen)
                {
                    rtfData.Text += "Port open" + "\r\n";
                }
                
            }
        }

        void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                string data = sp.ReadExisting();
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
                //rtfData.Text += "\r\n" + data;
                
            }
            catch(Exception ex)
            {
                rtfData.Text += "Bad data " + "\r\n";
            }
        }

        private void si_DataReceived(string data)
        {
            rtfData.Text += data +"\n";
        }
        private delegate void SetTextDeleg(string text);

        private void btnSend_Click(object sender, EventArgs e)
        {
            sp.WriteLine(rtfOutbox.Text + ".");
            rtfData.Text += "HQ: " + rtfOutbox.Text + "\n";
            rtfOutbox.Text = "";
        }
    }
    
}
