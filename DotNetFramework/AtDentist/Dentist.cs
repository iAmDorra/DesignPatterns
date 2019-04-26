namespace AtDentist
{
    public class Dentist
    {
        private IIterable patients;
        // This property is used to count patients received by the dentist, it's not mandatory
        private int numberPatients;
        public int ReceivedPatients => numberPatients;

        public Dentist(IIterable patientIterable)
        {
            this.numberPatients = 0;
            this.patients = patientIterable;
        }

        public void EnterNext()
        {
            IIterator iterator = this.patients.GetIterator();
            if (iterator.HasNext())
            {
                this.Receive(iterator.Next());
            }
        }

        private void Receive(IElement element)
        {
            // This property is used to count patients received by the dentist
            this.numberPatients++;
            // Put here the behavior of receiving patient
        }
    }
}
