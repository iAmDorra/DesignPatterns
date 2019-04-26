using System.Collections.Generic;

namespace AtDentist
{
    public class Secretary : IIterator, IWelcomePatient
    {
        // The type of the list depend on how we want to manage the order of patients.
        private Queue<IElement> patients = new Queue<IElement>();

        public bool HasNext()
        {
            return patients.Count > 0;
        }

        public IElement Next()
        {
            return this.patients.Dequeue();
        }

        public void WelcomePatient(IElement patient)
        {
            patients.Enqueue(patient);
        }
    }
}