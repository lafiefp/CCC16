namespace Level1
{
    public struct Triple
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Z { get; set; }

        public override string ToString()
        {
            return string.Format("{{X: {0}, Y:{1}, Z{2}}}", X, Y, Z);
        }
    }
}