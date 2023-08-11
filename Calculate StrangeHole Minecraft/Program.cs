using System;
using System.Drawing;


public class Program
{


    public static Point CalculateIntersection(Point point1, double angle1, Point point2, double angle2)
    {
        // Convert angles to radians
        double angle1_rad = Math.PI * angle1 / 180.0;
        double angle2_rad = Math.PI * angle2 / 180.0;

        // Calculate slope of the lines
        double slope1 = Math.Tan(angle1_rad);
        double slope2 = Math.Tan(angle2_rad);

        // Calculate y-intercepts
        double y_intercept1 = point1.Y - slope1 * point1.X;
        double y_intercept2 = point2.Y - slope2 * point2.X;

        // Calculate x-coordinate of the intersection point
        double x_intersect = (y_intercept2 - y_intercept1) / (slope1 - slope2);

        // Calculate y-coordinate of the intersection point
        double y_intersect = slope1 * x_intersect + y_intercept1;

        return new Point((int)x_intersect, (int)y_intersect);
    }
    static void Main(string[] args)
    {
        Point firstPosition = new Point(-2258, 433);
        double firstAngle = 164.8;
        Point secondPosition = new Point(-2150, 233);
        double secondAngle = 141.6;

        Point intersectionPoint = CalculateIntersection(firstPosition, firstAngle, secondPosition, secondAngle);

        Console.WriteLine($"Intersection Point: ({intersectionPoint.X}, {intersectionPoint.Y})");
    }
}
