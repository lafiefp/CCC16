namespace Level1.Commands
{
    public class TickCommand : CommandBase<TickResponse>
    {
        public static int Tick { get; set; } = 1;

        public override string ToString()
        {
            return string.Format("TICK {0}\n", Tick);
        }
    }
}