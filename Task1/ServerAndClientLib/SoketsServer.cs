using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerAndClientLib
{
    public class SoketsServer
    {
        public TcpListener tcpListener; 
        public List<SoketsClient> clients = new List<SoketsClient>();

        protected internal void AddConnection(SoketsClient client)
        {
            clients.Add(client);
        }
    }
}
