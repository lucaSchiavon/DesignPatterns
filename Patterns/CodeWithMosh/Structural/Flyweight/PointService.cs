using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight
{
    class PointService
    {
        public List<Point> GetPoints() 
        {
            List<Point> points = new List<Point>();
            var point = new Point(x: 1, y: 2, PointType.Cafe, null);
            points.Add(point);
            return points;
        }
    }
}
