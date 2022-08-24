#pragma once
#include "Define.hpp"
#include <vector>
#include <deque>

namespace NServerNetLib
{
	class TcpNetwork
	{
	public:
		TcpNetwork();
		virtual ~TcpNetwork();

		bool Init(const ServerConfig* pConfig);
		bool InitServer();

		int CreateSessionPool(int maxClientCount);

	private:
		ServerConfig m_config;

		int m_conntectedSessionCount = 0;
		std::vector<ClientSession> m_clientSessionPool;
		std::deque<int> m_clientSessionPoolIndex;
		std::deque<RecvPacketInfo> m_packQueue;

		SOCKET m_serverSockFd;
		fd_set m_readFds;
	};
}