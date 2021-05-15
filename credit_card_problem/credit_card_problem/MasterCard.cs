using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public class MasterCard : IKrediKarti
    {     
        public int mcBirinciRakam = 5;
        public int mcIkinciRakam { get; set; }

        public int mcToplamRakamUzunlugu = 16;
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
            Console.WriteLine("Master Card Kullanildi");
        }
    }
}
