namespace MathPoints
{
    public class CartesianPoint
    {
        private double x;
        private double y;

        public CartesianPoint(double x=0.0, double y=0.0)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get { return x; }
        }

        public double Y
        {
            get { return y; }
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

        static public double DistanceBetween(CartesianPoint a, CartesianPoint b)
        {
            return DistanceBetween(a.x, a.y, b.x, b.y);
        }

        static public double DistanceBetween(double x1, double y1, double x2, double y2)
        {
            double x_diff = System.Math.Abs(x2 - x1);
            double y_diff = System.Math.Abs(y2 - y1);
            double rhs = System.Math.Pow(x_diff, 2) + System.Math.Pow(y_diff, 2);
            return System.Math.Sqrt(rhs);
        }

        public double DistanceTo(CartesianPoint p)
        {
            return DistanceBetween(x, y, p.x, p.y);
        }

        public double DistanceTo(double x, double y)
        {
            return DistanceBetween(this.x, this.y, x, y);
        }

        public double Magnitude()
        {
            return DistanceBetween(0, 0, x, y);
        }
    }
}
