using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Structural.Flyweight.Exercise.Solution
{
    public class CellPropertiesFactory
    {
        Dictionary<string, CellProperties> cellProperties = new Dictionary<string, CellProperties>();
       
        public CellProperties GetCellProperties(string propertiesKey)
        {
            if (!cellProperties.ContainsKey(propertiesKey))
            {
                string[] props = propertiesKey.Split("|");
                CellProperties cellProps = new CellProperties(props[0], Convert.ToInt16(props[1]), Convert.ToBoolean(props[2]));
                cellProperties[propertiesKey] = cellProps;
            }
            return cellProperties[propertiesKey];
        }
    }
}
