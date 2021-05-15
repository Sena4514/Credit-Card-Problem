using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public class AmericanExpress : IKrediKarti
    {
        public int aeBirinciRakam = 3;
        public int aeIkinciRakam { get; set; }

        public int aeToplamRakamUzunlugu = 15;
        public string KartSahibi { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }

        private int kartNo;
        public int KartNumarasi
        {
            get
            {
                return kartNo;
            }
            set
            {
                throw new NotImplementedException();
            }
        }
        public void Kullan()
        {
            Console.WriteLine("Amerikan Express Kullanildi");
        }
    }
}
