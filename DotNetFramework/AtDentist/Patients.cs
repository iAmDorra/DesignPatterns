namespace AtDentist
{
    public class Patients : IIterable
    {
        private readonly IIterator iterator;

        public Patients(IIterator iterator)
        {
            this.iterator = iterator;
        }
        public IIterator GetIterator()
        {
            return this.iterator;
        }
    }
}