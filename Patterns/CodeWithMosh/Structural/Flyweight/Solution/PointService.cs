using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Solution
{
    class PointService
    {
        private PointIconFacotry PointIconFacotry;

        public PointService(PointIconFacotry pointIconFacotry)
        {
            PointIconFacotry = pointIconFacotry;
        }

        public List<Point> GetPoints() 
        {
            List<Point> points = new List<Point>();
            var point = new Point(x: 1, y: 2, PointIconFacotry.GetPointIcon(PointType.Cafe));
            points.Add(point);
            return points;
        }
    }
}
