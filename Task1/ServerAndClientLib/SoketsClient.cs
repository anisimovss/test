using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ServerAndClientLib
{
    public class SoketsClient
    {
        public string Id { get; private set; }
        public NetworkStream Stream { get; private set; }
        public string userName;
        public TcpClient client;
        public SoketsServer server;

        public SoketsClient(TcpClient client, SoketsServer server)
        {
            Id = Guid.NewGuid().ToString();
            this.client = client;
            this.server = server;
            server.AddConnection(this);
        }
    }
}
