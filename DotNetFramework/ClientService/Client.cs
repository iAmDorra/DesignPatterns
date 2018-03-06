using System;

namespace ClientService
{
    public class Client
    {
        private Adress adress;

        internal void SetAdress(Adress newAdress)
        {
            this.adress = newAdress;
        }
    }
}