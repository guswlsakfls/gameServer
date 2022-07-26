﻿using System;
using System.Net.Sockets;
using System.Net;

namespace client_tcp
{
    public class ClientTcp
    {
        public Socket Sock = null;
        public string LatestErrMsg;

        // sock 연결       
        public bool Connect(string ip, int port)
        {
            try
            {
                IPAddress serverIP = IPAddress.Parse(ip);
                int serverPort = port;

                // 소켓 생성
                Sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                Sock.Connect(new IPEndPoint(serverIP, serverPort));

                if (Sock == null || Sock.Connected == false)
                {
                    return false;
                }

                return true;
            }
            catch (Exception ex)
            {
                LatestErrMsg = ex.Message;
                return false;
            }
        }

        // sock 데이터 받기
        public Tuple<int, byte[]> Receive()
        {
            try
            {
                byte[] ReadBuffer = new byte[2048];
                var nRecv = Sock.Receive(ReadBuffer, 0, ReadBuffer.Length, SocketFlags.None);

                if (nRecv == 0)
                {
                    return null;
                }

                return Tuple.Create(nRecv, ReadBuffer);
            }

            catch (SocketException se)
            {
                LatestErrMsg = se.Message;
            }

            return null;
        }

        // sock 데이터 보내기
        public void Send(byte[] sendData)
        {
            try
            {
                if (Sock != null && Sock.Connected)
                {
                    Sock.Send(sendData, 0, sendData.Length, SocketFlags.None);
                }
                else
                {
                    LatestErrMsg = "채팅에 먼저 접속하세요.";
                }
            }
            catch (SocketException se)
            {
                LatestErrMsg = se.Message;
            }
        }

        // sock 닫기
        public void Close()
        {
            if (Sock != null && Sock.Connected)
            {
                Sock.Close();
            }
        }

        // sock 연결되어 있는지 확인
        public bool IsConnected() { return (Sock != null && Sock.Connected) ? true : false; }
    }
}
