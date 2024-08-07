namespace ClassPoint;

class Program
{
    public class Point2D
    {
        private float x;
        private float y;

        public Point2D()
        {
            this.x = 0.0f;
            this.y = 0.0f;
        }

        public Point2D(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float GetX()
        {
            return x;
        }

        public void SetX(float x)
        {
            this.x = x;
        }

        public float GetY()
        {
            return y;
        }

        public void SetY(float y)
        {
            this.y = y;
        }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public float[] GetXY()
        {
            return new float[] { x, y };
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }
    }
    public class Point3D : Point2D
    {
        private float z;

        public Point3D() : base()
        {
            this.z = 0.0f;
        }

        public Point3D(float x, float y, float z) : base(x, y)
        {
            this.z = z;
        }

        public float GetZ()
        {
            return z;
        }

        public void SetZ(float z)
        {
            this.z = z;
        }

        public void SetXYZ(float x, float y, float z)
        {
            SetXY(x, y);
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[] { GetX(), GetY(), z };
        }

        public override string ToString()
        {
            return $"({GetX()}, {GetY()}, {z})";
        }
    }
    static void Main(string[] args)
    {
        Point2D point2D = new Point2D(3.5f, 4.5f);
        Console.WriteLine(point2D.ToString());
        point2D.SetX(5.5f);
        point2D.SetY(6.5f);
        Console.WriteLine($"Updated Point2D: {point2D.ToString()}");
        point2D.SetXY(7.5f, 8.5f);
        float[] coordinates2D = point2D.GetXY();
        Console.WriteLine($"Coordinates: ({coordinates2D[0]}, {coordinates2D[1]})");
        Point3D point3D = new Point3D(1.0f, 2.0f, 3.0f);
        Console.WriteLine(point3D.ToString());
        point3D.SetX(4.0f);
        point3D.SetY(5.0f);
        point3D.SetZ(6.0f);
        Console.WriteLine($"Updated Point3D: {point3D.ToString()}");
        point3D.SetXYZ(7.0f, 8.0f, 9.0f);
        float[] coordinates3D = point3D.GetXYZ();
        Console.WriteLine($"Coordinates: ({coordinates3D[0]}, {coordinates3D[1]}, {coordinates3D[2]})");
    }
}
