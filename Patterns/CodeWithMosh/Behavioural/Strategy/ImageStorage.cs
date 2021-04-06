using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Patterns.CodeWithMosh.Strategy
{
    public class ImageStorage
    {
        private readonly ICompressor _compressor;
        private readonly IFilter _filter;

        public ImageStorage(ICompressor compressor,IFilter filter)
        {
            this._compressor = compressor;
            this._filter = filter;
        }

        public void Store(string fileName)
        {
            _compressor.Compress(fileName);
            _filter.Apply(fileName);
        }
    }
}
