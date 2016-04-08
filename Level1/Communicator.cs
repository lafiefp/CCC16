﻿using System;
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
        private TcpClient _client;
        private StreamWriter _writer;

        public Communicator(int port = 7000)
        {
            _client = new TcpClient("localhost", port);

            if (!_client.Connected)
                throw new Exception("Couldn't connect");

            _writer = new StreamWriter(_client.GetStream());
        }

        public InitialResponse GetInitial()
        {
            return new InitialResponse(_client.GetStream());
        }

        public ResponseBase ExecuteCommand(CommandBase cmd)
        {
            _writer.Write(cmd.ToString());
            _writer.Flush();

            return cmd.InterpretResponse(_client.GetStream());
        }

        public int Port { get; set; }
    }
}
