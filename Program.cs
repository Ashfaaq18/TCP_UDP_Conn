using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;

namespace TCP_UDP_Conn
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TCP_Table.TCP_Connection> tcp_table = TCP_Table.GetAllConnections();
            List<UDP_Table.MIB_UDPROW_OWNER_PID> udp_table = UDP_Table.GetAllUDPConnections();

            Console.WriteLine("  Proto  Local Address          Foreign Address        State        PID");
            foreach (var tcpCon in tcp_table)
            {
                Console.WriteLine("  TCP    {0,-23}{1,-23}{2,-23}{3}", tcpCon.LocalAddress, tcpCon.RemoteAddress, tcpCon.State, tcpCon.OwningPid);
            }

            Console.WriteLine("  Proto  Local Address          PID");
            foreach (var udpCon in udp_table)
            {
                Console.WriteLine("  UDP    {0,-23}{1,-23}", udpCon.LocalAddress, udpCon.ProcessId);
            }

            Console.Read();
        }

    }
}
