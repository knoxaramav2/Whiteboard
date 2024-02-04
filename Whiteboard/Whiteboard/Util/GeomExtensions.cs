namespace Whiteboard.Util
{
    internal static class GeomExtensions
    {
        public static Point Add(this Point a, Point b) => new(a.X+b.X, a.Y+b.Y);
        public static Point Sub(this Point a, Point b) => new(a.X - b.X, a.Y - b.Y);
    }
}
