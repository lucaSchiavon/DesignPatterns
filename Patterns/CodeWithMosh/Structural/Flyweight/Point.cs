using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight
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
        private PointType Type;
        private byte[] Icon;

        public Point(int x, int y, PointType type, byte[] icon)
        {
            this.x = x;
            this.y = y;
            Type = type;
            Icon = icon;
        }

        public void Draw()
        {
            Console.WriteLine("{0} at ({1}, {2}",Type,x,y);
        }
    }
}
