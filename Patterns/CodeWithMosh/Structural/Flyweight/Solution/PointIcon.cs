using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Solution
{
    class PointIcon
    {
        public readonly PointType Type;
        private readonly byte[] Icon;

        public PointIcon(PointType type, byte[] icon)
        {
            Type = type;
            Icon = icon;
        }
    }
}
