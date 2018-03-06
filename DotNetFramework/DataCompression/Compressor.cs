using System;

namespace DataCompression
{
    public class Compressor : ICompressor
    {
        private CompressionType compressionType;

        public Compressor(CompressionType type)
        {
            this.compressionType = type;
        }

        public string Compress(string data)
        {
            switch (this.compressionType)
            {
                case CompressionType.Repetition:
                    return CompressWithRepetitionAlgo(data);
                case CompressionType.Entropic:
                    return CompressWithEntropicAlgo(data);
                case CompressionType.ByDictionary:
                    return CompressByDictionaryAlgo(data);
                default:
                    return data;
            }
        }

        private string CompressByDictionaryAlgo(string data)
        {
            throw new NotImplementedException();
        }

        private string CompressWithEntropicAlgo(string data)
        {
            throw new NotImplementedException();
        }

        private string CompressWithRepetitionAlgo(string data)
        {
            throw new NotImplementedException();
        }
    }
}
