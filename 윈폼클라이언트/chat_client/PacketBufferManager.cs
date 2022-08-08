using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_tcp
{
    class PacketBufferManager
    {
        int BufferSize = 0;
        int ReadPos = 0;
        int WritePos = 0;

        int HeaderSize = 0;
        int MaxPacketSize = 0;
        byte[] PacketData;
        byte[] PacketDataTemp;

        public bool Init(int size, int headerSize, int maxPacketSize)
        {
            if (size < (maxPacketSize * 2) || size < 1 || headerSize < 1 || maxPacketSize < 1)
            {
                return false;
            }

            BufferSize = size;
            PacketData = new byte[size];
            PacketDataTemp = new byte[size];
            HeaderSize = headerSize;
            MaxPacketSize = maxPacketSize;

            return true;
        }

        public ArraySegment<byte> Read()
        {
            var enableReadSize = WritePos - ReadPos;

            if (enableReadSize < HeaderSize)
            {
                return new ArraySegment<byte>();
            }

            var packetDataSize = BitConverter.ToInt16(PacketData, ReadPos);
            if (enableReadSize < packetDataSize)
            {
                return new ArraySegment<byte>();
            }

            var completPacketData = new ArraySegment<byte>(PacketData, ReadPos, packetDataSize);
            ReadPos += packetDataSize;
            return completPacketData;
        }
    }
}
