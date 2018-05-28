using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolarSystem
{
    public class Sun
    {
        private static Sun instance = new Sun();

        private Sun()
        {
        }

        // The readonly property Instance can be a method too
        //public static Sun GetInstance()
        //{
        //    return instance;
        //}

        public static Sun Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
