#include "Main.hpp"
#include "Define.hpp"
#include "TcpNetwork.hpp"

#include <iostream>

NLogicLib::Main::Main()
{
}

NLogicLib::Main::~Main()
{
}

bool NLogicLib::Main::Init()
{
	LoadConfig();

	m_pNetwork = std::make_unique<NServerNetLib::TcpNetwork>();
	auto res = m_pNetwork->Init(m_pServerConfig.get());

	if (res == false) {
		std::cout << "Error: " << "network Init" << std::endl;
		return false;
	}

	std::cout << "Main 초기화 성공!" << std::endl;
	return true;
}

void NLogicLib::Main::Run()
{
}

void NLogicLib::Main::Stop()
{
}

void NLogicLib::Main::LoadConfig()
{
	m_pServerConfig =  std::make_unique<NServerNetLib::ServerConfig>();

	m_pServerConfig->port = 3306;
	m_pServerConfig->maxClientCount = 1000;
	m_pServerConfig->extraClientCount = 64;

	m_pServerConfig->maxClientRecvBufferSize = 8192;
	m_pServerConfig->maxClientSendBufferSize = 8192;
}
