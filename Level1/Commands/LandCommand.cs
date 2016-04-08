using Level1.Responses;
namespace Level1.Commands
{
    internal class LandCommand : CommandBase<LandResponse>
    {
        private readonly int _id;

        public LandCommand(int id)
        {
            _id = id;
        }

        public override string ToString()
        {
            return string.Format("LAND {0}\n", _id); // $"LAND {_id}\n";
        }
    }
}