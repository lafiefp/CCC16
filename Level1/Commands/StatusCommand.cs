namespace Level1.Commands
{
    internal class StatusCommand : CommandBase<StatusResponse>
    {
        private readonly int _id;

        public StatusCommand(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return string.Format("STATUS {0}\n", _id); // $"STATUS {_id}\n";
        }
    }
}