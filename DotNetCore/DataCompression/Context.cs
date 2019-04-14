namespace DataCompression
{
    public class Context
    {
        private readonly ICompressor compressor;

        // We should use a factory To create the right instance to pass to this constructor
        public Context(ICompressor compressor)
        {
            this.compressor = compressor;
        }

        public string Compress(string data)
        {
            return compressor.Compress(data);
        }
    }
}
