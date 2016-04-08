using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Level1
{
    public class Communicator
    {
        private readonly TcpClient _client;
        private readonly StreamWriter _writer;

        public Communicator(int port = 7000)
        {
            _client = new TcpClient("localhost", port);

            if (!_client.Connected)
                throw new Exception("Couldn't connect");

            _writer = new StreamWriter(_client.GetStream());
        }

        public InitialResponse GetInitial()
        {
            var resp = new InitialResponse();
            resp.Parse(_client.GetStream());
            return resp;
        }

        public T ExecuteCommand<T>(CommandBase<T> cmd) where T : ResponseBase, new()
        {
            _writer.Write(cmd.ToString());
            _writer.Flush();

            cmd.InterpretResponse(_client.GetStream());
            return cmd.Response;
        }
    }
}
