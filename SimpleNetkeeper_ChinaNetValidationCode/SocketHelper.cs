using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace SimpleNetkeeper_ChinaNetValidationCode
{
    class SocketHelper
    {

        private static UdpClient mUdpClient = null;


        /// <summary>
        /// 用于备用的UDP端口号
        /// </summary>
        public static int[] UDP_PORT_LIST = { 23333};

        /// <summary>
        /// 返回UDP实例
        /// </summary>
        /// <returns></returns>
        public static UdpClient getUdpInstance()
        {
            if (mUdpClient == null)
            {
                foreach (int port in UDP_PORT_LIST)
                {
                    try
                    {
                        mUdpClient = new UdpClient(port);
                        break;
                    }
                    catch (Exception) { }
                }
                
            }
            return mUdpClient;
        }

        public static string sendRequest(string req, string addr, int port) {
            if (!string.IsNullOrEmpty(req) && !string.IsNullOrEmpty(addr) && port > 0) {
                UdpClient udp = getUdpInstance();
                if (udp != null) {

                    try
                    {
                        IPEndPoint server = new IPEndPoint(IPAddress.Parse(addr), port);
                        byte[] toSend = Encoding.Default.GetBytes(req);
                        udp.Send(toSend, toSend.Length, server);

                        byte[] rec = udp.Receive(ref server);
                        return Encoding.Default.GetString(rec);
                    }
                    catch (Exception) { 
                        
                    }
                }
            }
            return null;
        }

    }
}
