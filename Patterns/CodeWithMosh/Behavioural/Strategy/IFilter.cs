using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy
{
    public interface IFilter
    {
        void Apply(string FileName);
    }
}
