using System;

namespace DataCompression
{
    internal class ByDictionaryCompressor : ICompressor
    {
        public string Compress(string data)
        {
            return CompressByDictionaryAlgo(data);
        }

        private string CompressByDictionaryAlgo(string data)
        {
            // Code of the algorithm
            throw new NotImplementedException();
        }
    }
}
