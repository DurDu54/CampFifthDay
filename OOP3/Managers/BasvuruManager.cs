using OOP3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3.Managers
{
    class BasvuruManager
    {

        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            krediManager.Hesapla();
            loggerService.Log();

            //IhtiyacKrediManager ıhtiyacKrediManager = new IhtiyacKrediManager();
            //krediManager.Hesapla();

            //üsttedki kullanım çok yanlış eğer böyle kullanırsak kredinişn tipi
            //ne olursa olsun her zaman ihtiyac kredisi alınıyormuş gibi hesaplayacak


            /*
             * interface imiz tüm classları tutqabildiği için burada
             * metodun alacağı parametreyi ondan oluşturduk bu sayede 
             * hangi tipde gelirse gelsin hesapla yöntemiyle yanlışlık 
             * olmadan hesaplanbilecek
            */
        }
        public void krediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
