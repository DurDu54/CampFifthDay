using OOP3.Interfaces;
using OOP3.Managers;
using OOP3.Services;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyackrediManager = new IhtiyacKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();
            IKrediManager tasitKrediManager =new TasitKrediManager();

            /* 
            interfacelerdetıpkı base classlar gibi o interface
            implemente edilen classın referans numarasını  tutabilir.
            */

            ILoggerService databaseLogger = new DatabesLoggerService();
            ILoggerService fileLogger = new FileLoggerService(); 

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtiyackrediManager, new DatabesLoggerService());// bu şekildede kullanılabilir  burada yeni bir log servisi oluşturduk
            basvuruManager.BasvuruYap(tasitKrediManager, fileLogger);                  // bu şekildede kullanılabilir üstte tanımlanarak  
            basvuruManager.BasvuruYap(new KonutKrediManager(),new SmsLoggerService());                                                                       

            List<IKrediManager> krediler = new List<IKrediManager>() {ihtiyackrediManager , konutKrediManager, tasitKrediManager };
            //basvuruManager.krediOnBilgilendirmesiYap(krediler);

        }
    }
}