using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace client_tcp
{
    struct PacketData
    {
        // 2byte + 2 + 1 = 5byte
        public Int16 DataSize;
        public Int16 PackeID;
        public SByte PacketType;
        public byte[] BodyData;
    }

    public class LoginReqPacket
    {
        byte[] UserID = new byte[PacketDef.MAX_USER_ID_BYTE_LENGTH];
        byte[] UserPW = new byte[PacketDef.MAX_USER_PW_BYTE_LENGTH];
        public void SetValue(string userID, string userPW)
        {
            Encoding.UTF8.GetBytes(userID).CopyTo(UserID, 0);
            Encoding.UTF8.GetBytes(userPW).CopyTo(UserPW, 0);
        }
        public byte[] ToBytes()
        {
            List<byte> dataSource = new List<byte>();
            dataSource.AddRange(UserID);
            dataSource.AddRange(UserPW);
            return dataSource.ToArray();
        }
        public class LoginResPacket
        {
            public Int16 Res;
            public bool FromBytes(byte[] bodyData)
            {
                Res = BitConverter.ToInt16(bodyData, 0);
                return true;
            }
        }
    }
}
