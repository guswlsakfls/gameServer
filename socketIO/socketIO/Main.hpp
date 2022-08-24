#pragma once

#include <memory>

namespace NServerNetLib
{
	struct ServerConfig;
	class TcpNetwork;
}

namespace NLogicLib 
{
	class Main
	{
	public:
		Main();
		~Main();

		bool Init();

		void Run();

		void Stop();

	private:
		void LoadConfig();

	private:
		bool m_isRun = false;

		std::unique_ptr<NServerNetLib::ServerConfig> m_pServerConfig;
		std::unique_ptr<NServerNetLib::TcpNetwork> m_pNetwork;
	};
}