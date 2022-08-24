#pragma once

namespace NServerNetLib
{
	struct ServerConfig
	{
		unsigned short port;

		int maxClientCount;
		int extraClientCount;

		short maxClientRecvBufferSize;
		short maxClientSendBufferSize;
	};

	struct ClientSession
	{
		bool IsConnected() { sockFd != 0 ? true : false; };

		void Clear()
		{
			recvSize = 0;
			sendSize = 0;
			sockFd = 0;
		}

		int index = 0;
		int sockFd = 0;

		char* recvBuffer = nullptr;
		char* sendBuffer = nullptr;
		int recvSize = 0;
		int sendSize = 0;
	};

	struct RecvPacketInfo
	{
		int sessionIndex = 0;
		short packetBodySize = 0;
		short packetId = 0;
		char* packBodyData = 0;
	};
}