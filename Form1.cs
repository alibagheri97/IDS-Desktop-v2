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
using System.Threading;
using System.Timers;

namespace IDS_v2
{
    public partial class Form1 : Form
    {
        
        SerialPort pCom = new SerialPort();
        string str;
        delegate void SetTextCallback(string text);
        int inx = 0;
        string O2, hbpm, temp ;
        string text2;
        int indx = 0;
        string p, p1, p2;
        bool stateButtton = true;
        string[] strM;
        string[] strM2;
        int test;
        string testS = "no";
        string testMain;
        bool start = false;
        
        public Form1()
        {
            InitializeComponent();
            notePort.Text = " . . . Press Start";
            label9.Visible = false;
            label10.Visible = false;
            label11.Visible = false;
            lungsPict.Visible = true;
            heartPict.Visible = true;
            tempPict.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!pCom.IsOpen && start == true )
            {
                notePort.Text = " . . . In Processing";
                strM = SerialPort.GetPortNames();
                strM2 = strM.Distinct().ToArray();
                strM = strM2;
                for (int i = 1; i <= strM.Length; i++)
                {
                    try
                    {
                        pCom.DtrEnable = true;
                        pCom.RtsEnable = true;
                        pCom.BaudRate = 115200;
                        pCom.DataBits = 8;
                        pCom.PortName = strM[i - 1];
                        pCom.Open();
                        var t1 = new Thread(threadJob);
                        testMain = strM[i - 1];
                        if (pCom.IsOpen)
                        {
                            pCom.Close();
                        }
                        pCom.DtrEnable = true;
                        pCom.RtsEnable = true;
                        pCom.BaudRate = 115200;
                        pCom.DataBits = 8;
                        pCom.PortName = testMain;
                        pCom.Open();
                        testS = "yes";
                        t1.Start();
                        break;
                       
                    }
                    catch
                    {
                        pCom.Close();
                        testS = "no";
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                        openButton.Text = "Restart";
                        notePort.Text = " . . . Couldn't Find IDS token";
                    }
                }
                if (testS == "no")
                {
                    Array.Clear(strM,0,strM.Length) ;
                    pCom.Close();
                    openButton.Text = "Restart";
                    label9.Visible = false;
                    label10.Visible = false;
                    label11.Visible = false;
                    notePort.Text = " . . . Couldn't Find IDS token";
                }
            }

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {

            if (start == true)
            {
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                lungsPict.Visible = true;
                heartPict.Visible = true;
                tempPict.Visible = true;
                notePort.Text = " . . . Disconnected";
                openButton.Text = "Start";
                notePort.Text = " . . . Press Start";
                Array.Clear(strM, 0, strM.Length);
                start = false;
            }
            else
            {

                start = true;
            }
        }

        private void webSiteWwwwsidsirToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void threadJob()
        {
            while (start)
            {
                if (pCom.IsOpen)
                {
                    str = "";
                    byte[] readbytes = new byte[pCom.BytesToRead];
                    pCom.Read(readbytes, 0, readbytes.Length);
                    foreach (byte i in readbytes)
                    {
                        str += Convert.ToChar(i);
                    }
                    SetText(str);
                    str = "";
                    System.Threading.Thread.Sleep(1000);
                }
            }
        }
        private void SetText(string text)
        {
            try
            {
                if (this.hLy.InvokeRequired)
                {
                    SetTextCallback d = new SetTextCallback(SetText);
                    this.Invoke(d, new object[] { text });
                }
                else
                {
                    if (text != "" && text != null && text[0] == 'w')
                    {
                        for (int i = 1; i <= text.Length - 1;i++)
                        {
                            text2 += text[i]; 
                        }
                        text = text2;
                        indx = 0;
                        while (true)
                        {
                            hbpm += text[inx];
                            if (inx == 2)
                            {
                                inx++;
                                break;
                            }
                            inx++;
                        }
                        
                        while (true)
                        {
                            O2 += text[inx];
                            if (inx == 5)
                            {
                                inx++;
                                break;
                            }
                            inx++;
                        }
                        while (true)
                        {
                            temp += text[inx];
                            if (inx == 7)
                            {
                                inx = 0;
                                break;
                            }
                            inx++;
                        }
                        if (hbpm[0] == '0')
                        {

                            while (true)
                            {
                                p += hbpm[indx + 1];
                                if (indx == 1)
                                {
                                    indx = 0;
                                    hbpm = p;
                                    break;
                                }
                                indx++;
                            }
                        }
                        else
                        {

                            while (true)
                            {
                                p += hbpm[indx];
                                p2 += O2[indx];
                                if (indx == 2)
                                {
                                    indx = 0;
                                    hbpm = p;
                                    O2 = p2;
                                    break;
                                }
                                indx++;
                            }
                        }
                        while (true)
                        {
                            p1 += temp[indx];
                            if (indx == 1)
                            {
                                indx = 0;
                                temp = p1;
                                break;
                            }
                            indx++;
                        }
                        if (O2 == "000")
                        {
                            O2 = "0";
                        }
                        this.hLy.Text = "";
                        this.oLy.Text = "";
                        this.tLy.Text = "";
                        try
                        {
                            test = Convert.ToInt32(hbpm);
                            testS = "yes";
                            this.hLy.Text = hbpm;
                            this.oLy.Text = O2;
                            this.tLy.Text = temp;
                            this.notePort.Text = " . . .Connected to IDS token on " + testMain;
                            openButton.Text = "Stop";
                            label9.Visible = true;
                            label10.Visible = true;
                            label11.Visible = true;
                            lungsPict.Visible = false;
                            heartPict.Visible = false;
                            tempPict.Visible = false;
                        }
                        catch
                        {
                            Array.Clear(strM, 0, strM.Length);
                            pCom.Close();
                            openButton.Text = "Restart";
                            label9.Visible = false;
                            label10.Visible = false;
                            label11.Visible = false;
                            lungsPict.Visible = true;
                            heartPict.Visible = true;
                            tempPict.Visible = true;
                            notePort.Text = " . . . Disconnected";
                            testS = "no";
                        }

                        hbpm = "";
                        O2 = "";
                        temp = "";
                        p = "";
                        p1 = "";
                        p2 = "";
                        text2 = "";
                        text = "";
                        indx = 0;
                        label9.Visible = false;
                        label10.Visible = false;
                        label11.Visible = false;
                    }
                    text = "";
                }
                text = "";
            }
            catch {
                label9.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                lungsPict.Visible = true;
                heartPict.Visible = true;
                tempPict.Visible = true;
                notePort.Text = " . . . Disconnected";
                openButton.Text = "Restart";
            }
        }
    }
}
