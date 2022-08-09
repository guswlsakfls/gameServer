﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace client_tcp
{
    public partial class mainForm : Form
    {
        ClientTcp Network = new ClientTcp();

        bool IsNetworkThreadRunning = false;

        System.Threading.Thread NetworkReadThread = null;

        PacketBufferManager PacketBuffer = new PacketBufferManager();
        Queue<PacketData> RecvPacketQueue = new Queue<PacketData> ();
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            PacketBuffer.Init((8096 * 10), PacketDef.PACKET_HEADER_SIZE, 1024);

            IsNetworkThreadRunning = true;
            NetworkReadThread = new System.Threading.Thread(this.NetworkReadProcess);
            NetworkReadThread.Start();
        }

        private void btn_close_click(object sender, EventArgs e)
        {
            Network.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_connect_click(object sender, EventArgs e)
        {
            string address = ipNum.Text;

            int port = Convert.ToInt32(portNum.Text);

            if (Network.Connect(address, port))
            {
                box_log.Items.Add(string.Format("{0} : 서버 접속 중", DateTime.Now));
                btn_connect.Enabled = false;
                btn_close.Enabled = true;
            }
            else
            {
                box_log.Items.Add(string.Format("{0} : 서버 접속 실패", DateTime.Now));
            }
        }

        private void textBox_echo(object sender, EventArgs e)
        {

        }

        private void label_ip(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void sendEcho_Click(object sender, EventArgs e)
        {
            string plusStr = box_textEcho.Text;
            box_log.Items.Add(plusStr);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_text(object sender, EventArgs e)
        {

        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            string id = box_id.Text;
            string pw = box_pw.Text;
            box_log.Items.Add(id);
        }

        private void btn_removeLog_Click(object sender, EventArgs e)
        {
            box_log.Items.Remove(box_log.SelectedItem);
        }
        private void lbox_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (box_log.SelectedIndex == -1)
            {
                btn_removeLog.Enabled = false;
                netStatus.Text = "선택 항목이 없습니다.";
                return;
            }
            btn_removeLog.Enabled = true;
            netStatus.Text = box_log.SelectedItem.ToString();
        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void box_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void portNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void label_port(object sender, EventArgs e)
        {

        }

        void NetworkReadProcess()
        {
            const Int16 PacketHeaderSize = PacketDef.PACKET_HEADER_SIZE;

            while (IsNetworkThreadRunning)
            {
                if (Network.IsConnected() == false)
                {
                    System.Threading.Thread.Sleep(1);
                    continue;
                }

                var recvData = Network.Receive();

                if (recvData != null)
                {
                    while (true)
                    {
                        var data = PacketBuffer.Read();
                        if (data.Count < 1)
                        {
                            break;
                        }

                        var packet = new PacketData();
                        packet.DataSize = (short)(data.Count - PacketHeaderSize);
                        packet.PackeID = BitConverter.ToInt16(data.Array, data.Offset + 2);
                        packet.PacketType = (SByte)data.Array[(data.Offset + 4)];
                        packet.BodyData = new byte[packet.DataSize];
                        Buffer.BlockCopy(data.Array, (data.Offset + PacketHeaderSize), packet.BodyData, 0, (data.Count - PacketHeaderSize));
                        lock (((System.Collections.ICollection)RecvPacketQueue).SyncRoot)
                        {

                        }
                    }
                }

                else
                {
                    Network.Close();
                    Console.WriteLine("서버 접속 종료");
                }
            }
        }

        private void localhost_CheckedChanged(object sender, EventArgs e)
        {
            if (localhost.Checked)
            {
                ipNum.Text = "127.0.0.1";
            }
            else
            {
                ipNum.Text = "0.0.0.0";
            }
        }
    }
}
