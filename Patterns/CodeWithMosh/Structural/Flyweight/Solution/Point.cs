using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Solution
{
    public enum PointType { 
    Hospital,
    Cafe,
    Restaurant
    }
    class Point
    {
      
        private int x;
        private int y;
        private PointIcon pointIcon;
      
        public Point(int x, int y, PointIcon pointIcon)
        {
            this.x = x;
            this.y = y;
            this.pointIcon = pointIcon;


        }

        public void Draw()
        {
            Console.WriteLine("{0} at ({1}, {2}",pointIcon.Type,x,y);
        }
    }
}
