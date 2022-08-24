#pragma once
#pragma comment(lib, "ws2_32")
#include <winSock2.h>

#include "TcpNetwork.hpp"
#include <cstring>
#include <iostream>

namespace NServerNetLib
{
	TcpNetwork::TcpNetwork()
	{
	}

	TcpNetwork::~TcpNetwork()
	{
	}

	bool TcpNetwork::Init(const ServerConfig* pConfig)
	{
		std::memcpy(&m_config, pConfig, sizeof(pConfig));

		if (InitServer() == false)
			return false;
		
		FD_ZERO(&m_readFds);
		FD_SET(m_serverSockFd, &m_readFds);

		auto sessionPoolSize = CreateSessionPool(m_config.maxClientCount + m_config.extraClientCount);
		return true;
	}

	bool TcpNetwork::InitServer()
	{
		int retval;

		// 윈속 초기화
		WSADATA wsa;
		if (WSAStartup(MAKEWORD(2, 2), &wsa) != 0)
			return 1;

		// socket()
		SOCKET listen_sock = socket(AF_INET, SOCK_STREAM, 0);
		if (listen_sock == INVALID_SOCKET) {
			std::cout << "Error: " << "socket()" << std::endl;
			return false;
		}

		//bind()
		SOCKADDR_IN serveraddr;
		ZeroMemory(&serveraddr, sizeof(serveraddr));
		serveraddr.sin_family = AF_INET;
		serveraddr.sin_addr.s_addr = htonl(INADDR_ANY);
		serveraddr.sin_port = htons(m_config.port);
		retval = bind(listen_sock, (SOCKADDR*)&serveraddr, sizeof(serveraddr));
		if (retval == SOCKET_ERROR) {
			std::cout << "Error: " << "bind()" << std::endl;
			return false;
		}

		//listen()
		retval = listen(listen_sock, SOMAXCONN);
		if (retval == SOCKET_ERROR) {
			std::cout << "Error: " << "listen()" << std::endl;
			return false;
		}

		// 넌블로킹 소켓으로 전환
		u_long on = 1;
		retval = ioctlsocket(listen_sock, FIONBIO, &on);
		if (retval == SOCKET_ERROR) {
			std::cout << "Error: " << "ioctl()" << std::endl;
			return false;
		}

		std::cout << "윈속 초기화 완료!! 연결 대기 중~!" << std::endl;
	}

	int TcpNetwork::CreateSessionPool(int maxClientCount)
	{
		for (int i = 0; i < maxClientCount; i++)
		{
			ClientSession session;
			session.Clear();
			session.index = i;
			session.recvBuffer = new char[m_config.maxClientRecvBufferSize];
			session.sendBuffer = new char[m_config.maxClientSendBufferSize];

			m_clientSessionPool.push_back(session);
			m_clientSessionPoolIndex.push_back(session.index);
		}
	}
}
