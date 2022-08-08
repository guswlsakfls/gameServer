using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_tcp
{
    internal class PacketDef
    {
        public const Int16 PACKET_HEADER_SIZE = 5;
        public const Int16 MAX_USER_ID_BYTE_LENGTH = 16;
        public const Int16 MAX_USER_PW_BYTE_LENGTH = 16;
    }

    public enum PACKET_ID : ushort
    {
        LOGIN_REQ = 21,
        LOGIN_RES = 22,
    }

    public enum ERROR_CODE : Int16
    {
        ERROR_NONE = 0,
    }
}
