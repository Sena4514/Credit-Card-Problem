using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace credit_card_problem
{
    public class Visa : IKrediKarti
    {
        public int vBirinciRakam = 4;
        public int vToplamRakamUzunlugu { get; set; }
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
            Console.WriteLine("Visa Kullanildi");
        }
    }
}
