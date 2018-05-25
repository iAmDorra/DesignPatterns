using System;

namespace DataCompression
{
    internal class EntropicCompressor : ICompressor
    {
        public string Compress(string data)
        {
            return CompressWithEntropicAlgo(data);
        }

        private string CompressWithEntropicAlgo(string data)
        {
            // Code implenting the algo
            throw new NotImplementedException();
        }
    }
}
