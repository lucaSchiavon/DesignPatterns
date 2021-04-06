using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.Generic;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Solution
{
    

    class PointIconFacotry
    {
        Dictionary<PointType, PointIcon> icons = new Dictionary<PointType, PointIcon>();

        public PointIcon GetPointIcon(PointType pointType)
        {
            if (!icons.ContainsKey(pointType))
            {
                //in una reale applicazione dobbiamo leggere il dato da qualche parte nel file system e metterlo qui sotto mforma di array di dati
                var icon = new PointIcon(pointType, icon: null);
                icons.Add(pointType, icon);
                
            }
           
                return icons[pointType];

        }
    }
}
