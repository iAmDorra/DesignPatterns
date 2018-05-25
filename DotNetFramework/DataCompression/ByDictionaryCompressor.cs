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
            // Code implenting the algo
            throw new NotImplementedException();
        }
    }
}
