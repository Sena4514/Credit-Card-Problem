using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace credit_card_problem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            /*Faktory tasarim kalibinda, istemciyi normal sekilde nesne olusturma mantigina
            maruz birakmadan, nesne olusturmasi saglanir ve yeni yaratilan nesneye ortak arayuz 
            kullanilarak erisilebilir.*/

            KrediKartiFactory krediKartiFactory = new KrediKartiFactory();

            IKrediKarti krediKarti = krediKartiFactory.getKrediKarti(KrediKartiFactory.enKrediKarti.enMasterCard);
            krediKarti.Kullan();
            //bu noktada mastercard sinifina gittim oradaki kullan fonksiyonuna dustum

            IKrediKarti krediKarti2 = krediKartiFactory.getKrediKarti(KrediKartiFactory.enKrediKarti.enVisa);
            krediKarti.Kullan();
            //bu noktada visa sinifina gittim oradaki kullan fonksiyonuna dustum

            IKrediKarti krediKarti3 = krediKartiFactory.getKrediKarti(KrediKartiFactory.enKrediKarti.enAmericanExpress);
            krediKarti.Kullan();
            //bu noktada americanexpress sinifina gittim oradaki kullan fonksiyonuna dustum


        }
    }
}
