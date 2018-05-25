using System;

namespace DataCompression
{
    internal class RepetitionCompressor : ICompressor
    {
        public string Compress(string data)
        {
            return CompressWithRepetitionAlgo(data);
        }

        private string CompressWithRepetitionAlgo(string data)
        {
            // Code implenting the algo
            throw new NotImplementedException();
        }
    }
}
