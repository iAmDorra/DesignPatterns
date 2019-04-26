using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AtDentist;
using NFluent;

namespace DesignPatterns.Tests
{
    [TestClass]
    public class DentistTest
    {
        [TestMethod]
        public void Should_Not_receive_any_patient_if_there_is_not()
        {
            var iterator = new Secretary();
            var patients = new Patients(iterator);
            var dentist = new Dentist(patients);
            dentist.EnterNext();
            Check.That(dentist.ReceivedPatients).IsEqualTo(0);
        }

        [TestMethod]
        public void Should_receive_one_patient_if_there_is_one()
        {
            var iterator = new Secretary();
            iterator.WelcomePatient(new Patient());
            var patients = new Patients(iterator);
            var dentist = new Dentist(patients);
            dentist.EnterNext();
            Check.That(dentist.ReceivedPatients).IsEqualTo(1);
        }


        [TestMethod]
        public void Should_receive_two_patients_if_there_is_two()
        {
            var iterator = new Secretary();
            Patient patient1 = new Patient();
            iterator.WelcomePatient(patient1);
            Patient patient2 = new Patient();
            iterator.WelcomePatient(patient2);
            var patients = new Patients(iterator);
            var dentist = new Dentist(patients);
            dentist.EnterNext();
            Check.That(dentist.ReceivedPatients).IsEqualTo(1);
            dentist.EnterNext();
            Check.That(dentist.ReceivedPatients).IsEqualTo(2);
            // If we ask to enter an other patients, nothing happened because ther is no patient
            dentist.EnterNext();
            Check.That(dentist.ReceivedPatients).IsEqualTo(2);
        }
    }
}
