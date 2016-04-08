namespace Level1
{
    internal class Drone
    {
        public int Id { get; set; }
        public Triple Position { get; set; }
        public Triple Velocity { get; set; }
        public Triple ThrustDirection { get; set; }

        public float Height { get; }
    }
}