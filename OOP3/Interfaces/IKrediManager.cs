using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Interfaces
{
    interface IKrediManager
    {

        public void Hesapla();
        public void Bisiyap();
        /*
         * birbirinin alternatifi olan ama kod içerişkleri farklı olan durumlar 
         * için kullanırız bu yaptığımız örnekde tüm kredilerde hesaplama ortaktır 
         * ama kodları farklıdır(fazi oranı vs.) o yüzden bu projede interface kullandık
         */
    }
}
